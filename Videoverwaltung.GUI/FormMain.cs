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
using System.Windows.Controls;
using System.Xml.Serialization;

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
            #region InitializeComponents and Building up the GenreList
            InitializeComponent();
            //Path of MediaCollection--------------------------------------------------------------------------------
            this.basePath = basePath;
            //Building up the Mediacollection----------------------------------------------------------------------------------
            ReadFileSystem(basePath);
            FillComboBoxGenre();
            //------------------------------------------------------------------------------------------------------
            
            #endregion
        }

        private void MenuItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }



        private void FillListViewMovie(Genre genre)
        {
            ListViewItem movieItem;
            foreach (Movie movie in genre.Movies)
            {
                movieItem = new ListViewItem();
                movieItem.Text = movie.Name;
                movieItem.SubItems.Add(movie.Duration.ToString());
                movieItem.Tag = movie;
                listViewMovie.Items.Add(movieItem);
            }
        }

        private void comboBoxGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = comboBoxGenre.Text;
            this.listViewMovie.Items.Clear();
            foreach(Genre genre in genres)
            {
                if (genre.GenreName == selection)
                {
                    FillListViewMovie(genre);
                }
            }
        }

        private void listViewMovie_MouseClick(object sender, MouseEventArgs e)
        {
            this.pictureBox1.Image = null;
            ListViewItem item = null;
            item = listViewMovie.GetItemAt(e.X, e.Y);
            Movie movie = (Movie)item.Tag;
            if(movie.Picture != null)
            {
                MemoryStream memStream = new MemoryStream(movie.Picture);
                this.pictureBox1.Image = Image.FromStream(memStream);

                memStream.Close();
            }
            this.axWindowsMediaPlayer1.URL = movie.MovieFile;
            this.axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.SelectedPath = basePath;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                comboBoxGenre.Items.Clear();
                listViewMovie.Items.Clear();
                ReadFileSystem(dialog.SelectedPath);
                FillComboBoxGenre();
            }
        }

        private void ReadFileSystem(string path)
        {
            Genre genre = null;
            this.genres = new List<Genre>();

            foreach (string genreDir in Directory.EnumerateDirectories(path))
            {
                genre = new Genre(genreDir);
                genres.Add(genre);
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



        private void comboBoxSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                listViewMovie.Items.Clear();
                string search = comboBoxSearch.Text;
                foreach (Genre genre in genres)
                {
                    ListViewItem searchItem = null;
                    foreach (Movie movie in genre.Movies)
                    {
                        if (movie.Name.Contains(search))
                        {
                            searchItem = new ListViewItem();
                            searchItem.Text = movie.Name;
                            searchItem.SubItems.Add(movie.Duration.ToString());
                            searchItem.Tag = movie;
                            listViewMovie.Items.Add(searchItem);
                        }
                    }

                }
            }
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "XML-File|.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = new StreamReader(dialog.FileName, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Genre>));
                this.genres = (List<Genre>)serializer.Deserialize(reader);
                reader.Close();
                FillComboBoxGenre();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "XML-File|.xml";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(dialog.FileName, false, Encoding.UTF8);
                XmlSerializer serializer = new XmlSerializer(typeof(List<Genre>));
                serializer.Serialize(writer, genres);
                writer.Close();
            }
            
        }

        private void hinzufügenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVideoDetail formVideoDetail = new FormVideoDetail(genres);
            formVideoDetail.ShowDialog();
            
        }

        private void listViewMovie_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListViewItem item = this.listViewMovie.GetItemAt(e.X,e.Y);
            Movie movieEdit = (Movie)item.Tag;
            FormVideoDetail formVideoDetail = new FormVideoDetail(movieEdit,genres);
            formVideoDetail.ShowDialog();
        }
    }
}
