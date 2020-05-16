using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hackovid;

namespace Hackovid_Database
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Indices form = new Indices())
            {
                form.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenFileDialog saveDialog = new OpenFileDialog();
            saveDialog.Filter = "Arquivo Json (*.json)| *.json";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo newFile = new FileInfo(saveDialog.FileName);
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = ConfigurationManager.AppSettings;

                configFile.AppSettings.Settings["FILEPATH"].Value = newFile.DirectoryName;
                configFile.AppSettings.Settings["FILENAME"].Value = newFile.Name;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            JsonDatabase jh = new JsonDatabase();
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Arquivo Json (*.json)| *.json";
            saveDialog.FilterIndex = 1;
            saveDialog.RestoreDirectory = true;
            JsonDatabase jd;

            if (File.Exists(Globals.FilePath + Globals.FileName))
            {
                jd = jh.ReadJson();
            }
            else
            {
                jd = new JsonDatabase();
            }

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                FileInfo newFile = new FileInfo(saveDialog.FileName);
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var appSettings = ConfigurationManager.AppSettings;

                configFile.AppSettings.Settings["FILEPATH"].Value = newFile.DirectoryName;
                configFile.AppSettings.Settings["FILENAME"].Value = newFile.Name;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                jh.WriteJson(jd);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Acoes form = new Acoes())
            {
                form.ShowDialog();
            }
        }
    }
}
