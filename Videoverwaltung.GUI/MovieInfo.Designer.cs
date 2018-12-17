namespace Videoverwaltung.GUI
{
    partial class MovieInfo
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMovieName = new System.Windows.Forms.TextBox();
            this.textBoxMovieDuration = new System.Windows.Forms.TextBox();
            this.comboBoxMovieRegisseur = new System.Windows.Forms.ComboBox();
            this.comboBoxMovieActor = new System.Windows.Forms.ComboBox();
            this.linkLabelFile = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBoxMovieName
            // 
            this.textBoxMovieName.Location = new System.Drawing.Point(0, 3);
            this.textBoxMovieName.Name = "textBoxMovieName";
            this.textBoxMovieName.Size = new System.Drawing.Size(150, 20);
            this.textBoxMovieName.TabIndex = 0;
            // 
            // textBoxMovieDuration
            // 
            this.textBoxMovieDuration.Location = new System.Drawing.Point(156, 3);
            this.textBoxMovieDuration.Name = "textBoxMovieDuration";
            this.textBoxMovieDuration.Size = new System.Drawing.Size(80, 20);
            this.textBoxMovieDuration.TabIndex = 1;
            // 
            // comboBoxMovieRegisseur
            // 
            this.comboBoxMovieRegisseur.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxMovieRegisseur.FormattingEnabled = true;
            this.comboBoxMovieRegisseur.Location = new System.Drawing.Point(242, 3);
            this.comboBoxMovieRegisseur.Name = "comboBoxMovieRegisseur";
            this.comboBoxMovieRegisseur.Size = new System.Drawing.Size(168, 21);
            this.comboBoxMovieRegisseur.TabIndex = 2;
            // 
            // comboBoxMovieActor
            // 
            this.comboBoxMovieActor.FormattingEnabled = true;
            this.comboBoxMovieActor.Location = new System.Drawing.Point(416, 3);
            this.comboBoxMovieActor.Name = "comboBoxMovieActor";
            this.comboBoxMovieActor.Size = new System.Drawing.Size(133, 21);
            this.comboBoxMovieActor.TabIndex = 3;
            // 
            // linkLabelFile
            // 
            this.linkLabelFile.AutoSize = true;
            this.linkLabelFile.Location = new System.Drawing.Point(555, 11);
            this.linkLabelFile.Name = "linkLabelFile";
            this.linkLabelFile.Size = new System.Drawing.Size(32, 13);
            this.linkLabelFile.TabIndex = 4;
            this.linkLabelFile.TabStop = true;
            this.linkLabelFile.Text = "Datei";
            this.linkLabelFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelFile_LinkClicked);
            // 
            // MovieInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabelFile);
            this.Controls.Add(this.comboBoxMovieActor);
            this.Controls.Add(this.comboBoxMovieRegisseur);
            this.Controls.Add(this.textBoxMovieDuration);
            this.Controls.Add(this.textBoxMovieName);
            this.Name = "MovieInfo";
            this.Size = new System.Drawing.Size(590, 26);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMovieName;
        private System.Windows.Forms.TextBox textBoxMovieDuration;
        private System.Windows.Forms.ComboBox comboBoxMovieRegisseur;
        private System.Windows.Forms.ComboBox comboBoxMovieActor;
        private System.Windows.Forms.LinkLabel linkLabelFile;
    }
}
