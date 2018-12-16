using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace Videoverwaltung.Resources
{
    public class Movie
    {
        public Movie()
        {

        }
        

        public Movie(string moviepath)
        {
            this.Name = Path.GetFileName(moviepath);
            this.MoviePath = moviepath;
            ReadMovieDir();
        }

        public Movie(string name, string regisseur, TimeSpan duration, string moviepath, string mainactor1, string mainactor2)
        {
            this.Name = name;
            this.Regisseur = regisseur;
            this.Duration = duration;
            this.MoviePath = moviepath;
            this.MainActor1 = mainactor1;
            this.MainActor2 = mainactor2;

        }

        public string Name { get; set; }
        public string  Regisseur { get; set; }
        public string  MoviePath { get; set; }
        public string MovieFile { get; set; }
        public TimeSpan Duration { get; set; }
        //public List<string> Cast { get; set; }
        public string MainActor1 { get; set; }
        public string MainActor2 { get; set; }
        public byte[] Picture { get; set; }



        private void ReadMovieDir()
        {
            List<string> extPic = new List<string>() { ".jpg", ".png", ".bmp", ".gif" };
            List<string> extVid = new List<string>() { ".mp4", ".avi" };
            foreach (string file in Directory.EnumerateFiles(this.MoviePath))
            {
                if (extPic.Contains(Path.GetExtension(file)))
                {
                    PicSave(file);
                }
                if (extVid.Contains(Path.GetExtension(file)))
                {
                    this.MovieFile = file;
                }
            }
        }
        
        /// <summary>
        /// Saves the Image form Path to Bytecode
        /// </summary>
        /// <param name="pic">Path to Imagefile</param>
        public void PicSave(string pic)
        {
            Image img = Image.FromFile(pic);
            MemoryStream memStream = new MemoryStream();
            img.Save(memStream, ImageFormat.Jpeg);
            memStream.Close();
            this.Picture = memStream.GetBuffer();
            
        }

        /// <summary>
        /// Gets the Image from the specific Movie instance (.jpg)
        /// </summary>
        /// <returns>System.Drawing.Image</returns>
        public Image GetImage()
        {
            MemoryStream memStream = new MemoryStream(this.Picture);
            return Image.FromStream(memStream);
        }

    }

    
}
