using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoverwaltung.Resources;

namespace Videoverwaltung.GUI
{
    public partial class FormMain : Form
    {
        #region Testwerte
        string basePath = string.Empty;
        private List<Genre> genres;

        public List<Genre> Genres
        {
            get { return genres; }
            set { genres = value; }
        }

        #endregion



        public FormMain(string basePath)
        {
            #region InitializeComponents and adding evenhandler to the different Radiobuttons
            InitializeComponent();

            //Path of MediaCollection--------------------------------------------------------------------------------
            this.basePath = basePath;

            //Adding Eventhandler---------------------------------------------------------------------------------
            radioButtonAction.CheckedChanged += new EventHandler(radiobuttons_CheckedChanged);
            radioButtonDrama.CheckedChanged += new EventHandler(radiobuttons_CheckedChanged);
            radioButtonDoku.CheckedChanged += new EventHandler(radiobuttons_CheckedChanged);
            radioButtonKinder.CheckedChanged += new EventHandler(radiobuttons_CheckedChanged);
            radioButtonKrimi.CheckedChanged += new EventHandler(radiobuttons_CheckedChanged);
            radioButtonThriller.CheckedChanged += new EventHandler(radiobuttons_CheckedChanged);

            //Building up the Mediacollection----------------------------------------------------------------------------------
            Genre genre = null;
            this.genres = new List<Genre>();
            foreach (string genreDir in Directory.EnumerateDirectories(basePath))
            {
                genre = new Genre(genreDir);
                genres.Add(genre);
            }
            //------------------------------------------------------------------------------------------------------
            #endregion

        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

       

        private void radiobuttons_CheckedChanged(object sender, EventArgs e)
        {

            if (radioButtonAction.Checked)
            {
                foreach(Genre genre in genres)
                {
                    if (genre.GenreName == "Action") FillListViewMovie(genre);
                }
            }

        }

        private void FillListViewMovie(Genre genre)
        {
            ListViewItem movieItem;
            foreach (Movie movie in genre.Movies)
            {
                movieItem = new ListViewItem();
                movieItem.Text = movie.Name;
                movieItem.SubItems.Add(movie.Duration.ToString());
                listViewMovie.Items.Add(movieItem);
            }
        }
    }
}
