using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoverwaltung.Resources;

namespace Videoverwaltung.GUI
{
    public partial class FormVideoDetail : Form
    {
        List<Genre> genres = null;
        List<MovieInfo> movieInfos = new List<MovieInfo>();

        public FormVideoDetail()
        {
            InitializeComponent();
        }

        public FormVideoDetail(List<Genre> genres)
        {
            this.genres = genres;
            InitializeComponent();
            FillComboBoxGenre();
        }

        public FormVideoDetail(Movie movie)
        {

        }

        

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            MovieInfo movieInfo = new MovieInfo();
            movieInfos.Add(movieInfo);
            this.flowLayoutPanelVideoDetail.Controls.Add(movieInfo);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Movie movie = null;
            Genre genre = null;
            
            if(this.comboBoxGenre.Text != "")
            {

                foreach(Genre searchGenre in genres)
                {
                    if(searchGenre.GenreName == this.comboBoxGenre.Text)
                    {
                        genre = searchGenre;
                        break;
                    }
                }
                foreach (MovieInfo newMovie in this.flowLayoutPanelVideoDetail.Controls)
                {
                    movie = new Movie();
                    movie.Name = newMovie.MovieName;
                    try
                    {
                        movie.Duration = TimeSpan.Parse(newMovie.Duration);
                    }
                    catch(System.FormatException)
                    {
                        MessageBox.Show("Falsches Format bei Duration");
                        return;
                    }
                    
                    movie.Regisseur = newMovie.Regisseur;
                    movie.MainActor1 = newMovie.MainActor;
                    movie.MovieFile = newMovie.FilePath;
                    genre.Movies.Add(movie);
                }
                Close();
            }
            else
            {
                MessageBox.Show("Bitte Genre Auswählen!", "Speichen nicht möglich.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
                
            
        }

        public void FillComboBoxGenre()
        {
            this.comboBoxGenre.Items.Clear();
            foreach (Genre genre in genres)
            {
                this.comboBoxGenre.Items.Add(genre.GenreName);
            }
        }
    }
}
