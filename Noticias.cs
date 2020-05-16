using Hackovid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackovid_Database
{
    public partial class Noticias : Form
    {

        JsonDatabase Database;
        Noticia selectedNoticia;
        string cod;
        public Noticias()
        {
            InitializeComponent();
        }

        private void LoadNotifications(object sender, EventArgs e)
        {
            Database = new JsonDatabase();
            cod = "";
        }

        private void pesquisar_Click(object sender, EventArgs e)
        {
            LoadNoticias();
            if (selectedNoticia != null)
            {
                //adiciona a acao selecionada no form principal
                listIndices.Items.Clear();
                txtCod.Text = selectedNoticia.Cod_noticia;
                txtManchete.Text = selectedNoticia.Manchete;
                txtFonte.Text = selectedNoticia.Fonte;
                txtDescricao.Text = selectedNoticia.Descrição;
               
                foreach (Indice indice in selectedNoticia.Indices)
                {
                    if (indice != null)
                        listIndices.Items.Add(indice.Cod_Indice);
                }
            }
        }

        private void LoadNoticias()
        {
            Database = Database.ReadJson();
            List<Noticia> noticias = Database.noticias.Where(not => not.Cod_noticia.Contains(txtCod.Text) || not.Descrição.Contains(txtCod.Text) || not.Manchete.Contains(txtCod.Text)).ToList();
            using (SearchForm s = new SearchForm())
            {
                s.CreateTable(noticias, typeof(Noticia));
                s.ShowDialog();
                cod = s.ID;
            }

            if (cod != "")
            {
                selectedNoticia = Globals.GetNoticia(cod);
            }
        }

        private void salvar_Click(object sender, EventArgs e)
        {
            Database = Database.ReadJson();
            Noticia noticia = new Noticia();

            noticia.Cod_noticia = txtCod.Text;
            noticia.Fonte = txtFonte.Text;
            noticia.Manchete = txtManchete.Text;
            noticia.Descrição = txtDescricao.Text;

            foreach (string n in listIndices.Items)
            {
                noticia.Indices.Add(Globals.GetIndice(n));
            }

                List<Noticia> noticias = Database.noticias;
                noticias.Remove(noticias.Where(i => i.Cod_noticia == cod).FirstOrDefault());
                noticias.Add(noticia);
                Database.noticias = noticias;
                Database.WriteJson(Database);

            MessageBox.Show("Salvo com sucesso!");
            ClearFields();
        }

        private void ClearFields()
        {
           txtCod.Text = "";
           txtFonte.Text = "";
           txtManchete.Text = "";
           txtDescricao.Text = "";
        }

        private void addIndice_Click(object sender, EventArgs e)
        {
            Indice indice = LoadIndices();
            if (indice != null) {
                listIndices.Items.Add(indice.Cod_Indice);
            }
        }

        private Indice LoadIndices()
        {
            Database = Database.ReadJson();
            List<Indice> indices = Database.indices;
            Indice n;
            using (SearchForm s = new SearchForm())
            {
                s.CreateTable(indices, typeof(Indice));
                s.ShowDialog();
                n = Globals.GetIndice(s.ID);
            }
            return n;
        }

        private void remIndice_Click(object sender, EventArgs e)
        {
            listIndices.Items.Remove(listIndices.SelectedItem);
        }
    }
}
