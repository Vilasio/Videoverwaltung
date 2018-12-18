using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Videoverwaltung.GUI
{
    public partial class FormBasePath : Form
    {
        

        public FormBasePath()
        {
            InitializeComponent();
        }

        public string Path { get; set; }

        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                this.comboBoxPath.Text = dialog.SelectedPath;
                this.Path = dialog.SelectedPath;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if(Path != null)
            {
                System.Configuration.Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                config.AppSettings.Settings["Basepath"].Value = Path;
                config.Save(ConfigurationSaveMode.Modified);
               
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie einen Dateipfad an.", "Dateipfad fehlt!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
        }
    }
}
