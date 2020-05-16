using Hackovid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Hackovid_Database.Classes
{
    public partial class Eventos : Form
    {
        JsonDatabase Database;
        Evento selectedEvento;
        string cod;
        List<Efeito> efeitos;
        List<Noticia> noticias;

        public Eventos()
        {
            InitializeComponent();
        }

        private void botaoPesquisar(object sender, EventArgs e)
        {
            LoadEventosTable();
            if(selectedEvento != null)
            {
                listBoxNoticia.Items.Clear();
                listBox1.Items.Clear();
                txtCod.Text = selectedEvento.Cod_Evento;
                txtDesc.Text = selectedEvento.Descricao;
                txtTitulo.Text = selectedEvento.Titulo;
                textBox2.Text = selectedEvento.Probab_Acontecer.ToString();
                
              foreach (Noticia noticia in selectedEvento.Noticias)
                {
                    if (noticia != null)
                        listBoxNoticia.Items.Add(noticia.Cod_noticia);
                }

            }


        }

        private void botaoSalvar(object sender, EventArgs e)
        {
            Database = Database.ReadJson();
            Evento evento = new Evento();

            evento.Cod_Evento = txtCod.Text;
            evento.Descricao = txtDesc.Text;
            evento.Probab_Acontecer = decimal.Parse(textBox2.Text);
            evento.Titulo = txtTitulo.Text;

            foreach (string n in listBoxNoticia.Items)
            {
                evento.Noticias.Add(Globals.GetNoticia(n));
            }

            evento.Efeitos = efeitos;
            List<Evento> eventos = Database.eventos;
            eventos.Remove(eventos.Where(ed => ed.Cod_Evento == cod).FirstOrDefault());
            eventos.Add(evento);
            Database.eventos = eventos;
            Database.WriteJson(Database);

            MessageBox.Show("Salvo com sucesso!");
            ClearFields();
        }

        private void ClearFields()
        {
            txtCod.Text = "";
            listBoxNoticia.Items.Clear();
            listBox1.Items.Clear();
            txtDesc.Text = "";
            textBox2.Text = "";
            txtTitulo.Text = "";
        }

        private void LoadEventosTable()
        {
            Database = Database.ReadJson();
            List<Evento> eventos = Database.eventos;
            using (SearchForm s = new SearchForm()){
                s.CreateTable(eventos, typeof(Evento));
                s.ShowDialog();
                cod = s.ID;
            }

            if (cod != "")
            {
                selectedEvento = Globals.GetEvento(cod);
            }

        }
        private void LoadEventos(object sender, EventArgs e)
        {
            efeitos = new List<Efeito>();
            noticias = new List<Noticia>();
            Database = new JsonDatabase();
            cod = "";

            List<Fator> fatores = Globals.GetFatores();
            foreach (Fator item in fatores)
            {
                comboBox1.Items.Add(item.Nome);
            }
        }
        private void adicionaNoticia(object sender, EventArgs e)
        {
            Noticia noticia = LoadNoticias();
            if (noticia != null)
            {
                listBoxNoticia.Items.Add(noticia.Cod_noticia);
            }
        }

        private Noticia LoadNoticias()
        {
            Database = Database.ReadJson();
            List<Noticia> noticias = Database.noticias;
            Noticia n;
            using (SearchForm s = new SearchForm())
            {
                s.CreateTable(noticias, typeof(Noticia));
                s.ShowDialog();
                n = Globals.GetNoticia(s.ID);
            }
            return n;
        }
        private void adicionaEfeito(object sender, EventArgs e)
        {
            Fator fator = new Fator();
            fator = Globals.GetFator(comboBox1.Text);
            if (fator != null)
            {
                Efeito efeito = new Efeito(fator, comboBox2.Text, float.Parse(textBox1.Text));
                efeitos.Add(efeito);
                listBox1.Items.Add(efeito.Fator.Nome + " " + efeito.Operaçao.ToString() + " " + efeito.Valor.ToString());
            }
        }

        private void removeNoticia(object sender, EventArgs e)
        {
            listBoxNoticia.Items.Remove(listBoxNoticia.SelectedItem);
        }

        private void removeEfeito(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                efeitos.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }
    }

  
}
