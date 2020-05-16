using Hackovid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Hackovid_Database
{
    public partial class Indices : Form
    {
        JsonDatabase Database;
        List<Indice> indicesList;
        Indice selectedIndice;
        string cod;
        public Indices()
        {
            InitializeComponent();
 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LoadIndices();
            if (selectedIndice != null)
            {
                listBoxIndices.Items.Clear();
                txtCod.Text = selectedIndice.Cod_Indice;
                txtMetodo.Text = selectedIndice.Metodo;
                foreach (Indice ind in selectedIndice.Indices)
                {
                    if(ind != null)
                        listBoxIndices.Items.Add(ind.Cod_Indice);
                }
            }

        }

        private void LoadIndices()
        {
            Database = new JsonDatabase();
            Database = Database.ReadJson();
            indicesList = Database.indices;
            using (SearchForm s = new SearchForm())
            {
                s.CreateTable(indicesList, typeof(Indice));
                s.ShowDialog();
                cod = s.ID;
            }

            if (cod != "")
            {
                selectedIndice = Globals.GetIndice(cod);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadIndices();
            if (selectedIndice != null)
            {
                listBoxIndices.Items.Add(selectedIndice.Cod_Indice);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Database = Database.ReadJson();
            
            Indice indice = new Indice();

            indice.Cod_Indice = txtCod.Text;
            indice.Metodo = txtMetodo.Text;
            indice.Indices.Clear();

            foreach(string ind in listBoxIndices.Items)
            {
                indice.Indices.Add(Globals.GetIndice(ind));
            }

            if (cod != "" && cod != null)
            {
                List<Indice> inds = Database.indices;
                inds.Remove(inds.Where(i => i.Cod_Indice == cod).FirstOrDefault());
                inds.Add(indice);
                Database.indices = inds;
                Database.WriteJson(Database);

            }
            else
            {
                Database.indices.Add(indice);
                Database.WriteJson(Database);
            }

            MessageBox.Show("Salvo com sucesso!");
            ClearFields();
        }

        private void ClearFields()
        {
            txtCod.Text = "";
            txtMetodo.Text = "";
            selectedIndice = null;
            cod = "";
            indicesList = new List<Indice>();
            listBoxIndices.Items.Clear();
        }

        private void Indices_Load(object sender, EventArgs e)
        {
            Database = new JsonDatabase();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBoxIndices.Items.Remove(listBoxIndices.SelectedItem);
        }
    }
}
