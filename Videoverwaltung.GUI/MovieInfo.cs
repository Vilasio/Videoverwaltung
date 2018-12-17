using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoverwaltung.GUI
{
    public partial class MovieInfo : UserControl
    {
        public MovieInfo()
        {
            InitializeComponent();
            
        }




        

        public string MovieName
        {
            get { return this.textBoxMovieName.Text; }
            set { this.textBoxMovieName.Text = value; }
        }

        public string Duration
        {
            get { return this.textBoxMovieDuration.Text; }
            set { this.textBoxMovieDuration.Text = value; }
        }

        public string MainActor
        {
            get { return this.comboBoxMovieActor.Text; }
            set { this.comboBoxMovieActor.Text = value; }
        }

        public string Regisseur
        {
            get { return this.comboBoxMovieRegisseur.Text; }
            set { this.comboBoxMovieRegisseur.Text = value; }
        }

        public string FilePath { get; set; }

        private void linkLabelFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            //dialog.SelectedPath = "c:\\";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FilePath = dialog.FileName;
            }
        }
    }
}
