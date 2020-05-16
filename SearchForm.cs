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
    public partial class SearchForm : Form
    {
        public string ID;
        public string IDHeader
        {
            get; set;
        }
        public string NameHeader
        {
            get; set;
        }
        public string DescriptionHeader
        {
            get; set;
        }

        public SearchForm()
        {
            InitializeComponent();
        }

        public virtual void AddColumn(string headerName, string headerText, int fillWeight)
        {
            dataGridView1.AutoGenerateColumns = false;
            DataGridViewColumn newColumn = new DataGridViewColumn();
            newColumn.CellTemplate = new DataGridViewTextBoxCell();
            newColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            newColumn.FillWeight = fillWeight;
            newColumn.HeaderText = headerText;
            newColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            newColumn.Name = headerName;
            newColumn.ReadOnly = true;
            dataGridView1.Columns.Add(newColumn);
        }

        public virtual void AddColumn(string headerText, int fillWeight)
        {
            AddColumn(headerText, headerText, fillWeight);
        }

        public void CreateTable<T>(List<T> data, Type type)
        {
            CreateTable<T>(data, type, true, null);
        }

        public void CreateTable<T>(List<T> data, Type type, bool showAll, params string[] fieldsToAdd)
        {
            foreach (var property in type.GetProperties())
            {
                if ((fieldsToAdd != null && fieldsToAdd.Contains(property.Name)) || showAll)
                {
                    object[] atributes = property.GetCustomAttributes(typeof(DisplayNameAttribute), false);
                    string alias = "";
                    if (atributes != null && atributes.Length > 0)
                    {
                        var displayName = (DisplayNameAttribute)atributes[0];
                        alias = displayName.DisplayName;
                    }

                    if (alias != "")
                        AddColumn(property.Name, alias, 1);
                    else
                        AddColumn(property.Name, 1);
                }
            }

            LoadData<T>(data);
        }

        private void LoadData<T>(List<T> table)
        {
            foreach (var row in table)
            {
                List<string> rowValues = new List<string>();
                foreach (var field in row.GetType().GetProperties())
                {
                    if (dataGridView1.Columns.Contains(field.Name))
                    {
                        if (field.PropertyType == typeof(bool))
                        {
                            if (field.GetValue(row).ToString() == "True")
                            {
                                rowValues.Add("Sim");
                            }
                            else
                            {
                                rowValues.Add("Não");
                            }
                        }
                        else
                        {
                            rowValues.Add(field.GetValue(row).ToString());
                        }

                    }
                }
                dataGridView1.Rows.Add(rowValues.ToArray());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                if (dataGridView1.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    this.ID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                    this.Close();
                }
            }
        }
    }
}
