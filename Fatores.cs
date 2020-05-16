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
    public partial class Fatores : Form
    {
        JsonDatabase Database;
        Fator selectedFator;
        string cod;

        public Fatores()
        {
            InitializeComponent();
        }

        private void botaoPesquisar(object sender, EventArgs e)
        {
            LoadFatoresTable();
            if (selectedFator != null)
            {
                txtCod.Text = selectedFator.Nome;
                //todo: transforma em number
                textBox1.Text = selectedFator.ValorMax.ToString();
            }
        }

        private void LoadFatoresTable()
        {
           Database = Database.ReadJson();
            List<Fator> fatores = Database.fatores;

            using(SearchForm s= new SearchForm())
            {
                s.CreateTable(fatores, typeof(Fator));
                s.ShowDialog();
                cod = s.ID;
            }

            if (cod != "")
            {
                selectedFator = Globals.GetFator(cod);
            }

        }

        private void LoadFatores(object sender, EventArgs e)
        {
            Database = new JsonDatabase();
            cod = "";
        }
        private void botaoSalvar(object sender, EventArgs e)
        {
            Database = Database.ReadJson();
            Fator fator = new Fator();

            fator.Nome = txtCod.Text;
            //todo mudar se converter os valores
            fator.ValorMax = int.Parse(textBox1.Text);

            if (cod != "" && cod != null)
            {
                List<Fator> fatores = Database.fatores;
                fatores.Remove(fatores.Where(f => f.Nome == cod).FirstOrDefault());
                fatores.Add(fator);
                Database.fatores = fatores;
                Database.WriteJson(Database);
            }
            else
            {
                Database.fatores.Add(fator);
                Database.WriteJson(Database);
            }

            MessageBox.Show("Salvo com sucesso!");
            ClearFields();
        }

        private void ClearFields()
        {
            txtCod.Text = "";
            //todo mudar se converter os valores
            textBox1.Text = "";
            cod = "";
            selectedFator = null;
        }
    }
}
