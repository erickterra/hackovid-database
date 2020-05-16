using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hackovid;

namespace Hackovid_Database
{
    public partial class Acoes : Form
    {
        JsonDatabase Database;
        Açao selectedAcao;
        string cod;
        List<Efeito> efeitos;
        public Acoes()
        {
            InitializeComponent();
        }

        private void botaoPesquisar(object sender, EventArgs e)
        {
            LoadAçao();
            if (selectedAcao != null)
            {
                //adiciona a acao selecionada no form principal
                listBoxNoticia.Items.Clear();
                txtCod.Text = selectedAcao.Cod_Acao;
                txtTitulo.Text = selectedAcao.Titulo;
                txtDesc.Text = selectedAcao.Descricao;
                txtCusto.Text = selectedAcao.Custo.ToString();
                chkVariavel.Checked = selectedAcao.IsCustoVariavel;
                cbFator.Text = selectedAcao.FatorCusto.Nome;

                foreach(Noticia noticia in selectedAcao.Noticias)
                {
                    if (noticia != null)
                        listBoxNoticia.Items.Add(noticia.Cod_noticia);
                }
            }
        }

        //Carrega todas as Ações no botão de pesquisa
        private void LoadAçao()
        {
            Database = Database.ReadJson();
            List<Açao> acoes = Database.açoes;
            using (SearchForm s = new SearchForm())
            {
                s.CreateTable(acoes, typeof(Açao));
                s.ShowDialog();
                cod = s.ID;
            }

            if (cod != "")
            {
                selectedAcao = Globals.GetAçao(cod);
            }
        }

        private void Acoes_Load(object sender, EventArgs e)
        {
            efeitos = new List<Efeito>();
            Database = new JsonDatabase();
            cod = "";
            List<Fator> fatores = Globals.GetFatores();
            foreach (Fator item in fatores)
            {
                cbFator.Items.Add(item.Nome);
                comboBox1.Items.Add(item.Nome);
            }
        }

        private void botaoSalvar(object sender, EventArgs e)
        {
            Database = Database.ReadJson();
            Açao açao = new Açao();

            açao.Cod_Acao = txtCod.Text;
            açao.Titulo = txtTitulo.Text;
            açao.Descricao = txtDesc.Text;
            açao.Custo = int.Parse(txtCusto.Text);
            açao.FatorCusto = Globals.GetFator(cbFator.Text);
            açao.IsCustoVariavel = chkVariavel.Checked;

            foreach (string n in listBoxNoticia.Items)
            {
                açao.Noticias.Add(Globals.GetNoticia(n));
            }

            açao.Efeitos = efeitos;


            if (cod != "" && cod != null)
            {
                List<Açao> acoes = Database.açoes;
                acoes.Remove(acoes.Where(i => i.Cod_Acao == cod).FirstOrDefault());
                acoes.Add(açao);
                Database.açoes = acoes;
                Database.WriteJson(Database);
            }
            else
            {
                Database.açoes.Add(açao);
                Database.WriteJson(Database);
            }

            MessageBox.Show("Salvo com sucesso!");
            ClearFields();
        }

        private void ClearFields()
        {
            throw new NotImplementedException();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            Fator fator = new Fator();
            fator = Globals.GetFator(comboBox1.Text);
            if (fator != null)
            {
                Efeito efeito = new Efeito(fator, comboBox2.Text, float.Parse(textBox1.Text));
                efeitos.Add(efeito);
                lisBoxEfeitos.Items.Add(efeito.Fator.Nome + " " + efeito.Operaçao.ToString() + " " + efeito.Valor.ToString());
            }

            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBoxNoticia.Items.Remove(listBoxNoticia.SelectedItem);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (lisBoxEfeitos.SelectedIndex >= 0)
            {
                efeitos.RemoveAt(lisBoxEfeitos.SelectedIndex);
                lisBoxEfeitos.Items.Remove(lisBoxEfeitos.SelectedItem);
            }
        }
    }
}
