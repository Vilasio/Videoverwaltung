namespace Videoverwaltung.GUI
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabelUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.listViewMovie = new System.Windows.Forms.ListView();
            this.groupBoxGenre = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radioButtonDrama = new System.Windows.Forms.RadioButton();
            this.radioButtonThriller = new System.Windows.Forms.RadioButton();
            this.radioButtonAction = new System.Windows.Forms.RadioButton();
            this.radioButtonKinder = new System.Windows.Forms.RadioButton();
            this.radioButtonDoku = new System.Windows.Forms.RadioButton();
            this.radioButtonKrimi = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.groupBoxGenre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programmToolStripMenuItem
            // 
            this.programmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemExit});
            this.programmToolStripMenuItem.Name = "programmToolStripMenuItem";
            this.programmToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.programmToolStripMenuItem.Text = "Programm";
            // 
            // MenuItemExit
            // 
            this.MenuItemExit.Name = "MenuItemExit";
            this.MenuItemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuItemExit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemExit.Text = "Exit";
            this.MenuItemExit.Click += new System.EventHandler(this.MenuItemExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabelUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabelUser
            // 
            this.StatusLabelUser.Name = "StatusLabelUser";
            this.StatusLabelUser.Size = new System.Drawing.Size(30, 17);
            this.StatusLabelUser.Text = "User";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxGenre);
            this.splitContainer1.Panel1.Controls.Add(this.listViewMovie);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.axWindowsMediaPlayer1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 404);
            this.splitContainer1.SplitterDistance = 266;
            this.splitContainer1.TabIndex = 2;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(530, 404);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // listViewMovie
            // 
            this.listViewMovie.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listViewMovie.Location = new System.Drawing.Point(0, 91);
            this.listViewMovie.Name = "listViewMovie";
            this.listViewMovie.Size = new System.Drawing.Size(266, 313);
            this.listViewMovie.TabIndex = 0;
            this.listViewMovie.UseCompatibleStateImageBehavior = false;
            // 
            // groupBoxGenre
            // 
            this.groupBoxGenre.Controls.Add(this.radioButtonKrimi);
            this.groupBoxGenre.Controls.Add(this.radioButtonDoku);
            this.groupBoxGenre.Controls.Add(this.radioButtonKinder);
            this.groupBoxGenre.Controls.Add(this.radioButtonAction);
            this.groupBoxGenre.Controls.Add(this.radioButtonThriller);
            this.groupBoxGenre.Controls.Add(this.radioButtonDrama);
            this.groupBoxGenre.Location = new System.Drawing.Point(5, -1);
            this.groupBoxGenre.Name = "groupBoxGenre";
            this.groupBoxGenre.Size = new System.Drawing.Size(143, 92);
            this.groupBoxGenre.TabIndex = 1;
            this.groupBoxGenre.TabStop = false;
            this.groupBoxGenre.Text = "Genre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(145, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 92);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // radioButtonDrama
            // 
            this.radioButtonDrama.AutoSize = true;
            this.radioButtonDrama.Location = new System.Drawing.Point(0, 19);
            this.radioButtonDrama.Name = "radioButtonDrama";
            this.radioButtonDrama.Size = new System.Drawing.Size(56, 17);
            this.radioButtonDrama.TabIndex = 0;
            this.radioButtonDrama.TabStop = true;
            this.radioButtonDrama.Text = "Drama";
            this.radioButtonDrama.UseVisualStyleBackColor = true;
            // 
            // radioButtonThriller
            // 
            this.radioButtonThriller.AutoSize = true;
            this.radioButtonThriller.Location = new System.Drawing.Point(62, 19);
            this.radioButtonThriller.Name = "radioButtonThriller";
            this.radioButtonThriller.Size = new System.Drawing.Size(56, 17);
            this.radioButtonThriller.TabIndex = 1;
            this.radioButtonThriller.TabStop = true;
            this.radioButtonThriller.Text = "Thriller";
            this.radioButtonThriller.UseVisualStyleBackColor = true;
            // 
            // radioButtonAction
            // 
            this.radioButtonAction.AutoSize = true;
            this.radioButtonAction.Location = new System.Drawing.Point(1, 42);
            this.radioButtonAction.Name = "radioButtonAction";
            this.radioButtonAction.Size = new System.Drawing.Size(55, 17);
            this.radioButtonAction.TabIndex = 2;
            this.radioButtonAction.TabStop = true;
            this.radioButtonAction.Text = "Action";
            this.radioButtonAction.UseVisualStyleBackColor = true;
            // 
            // radioButtonKinder
            // 
            this.radioButtonKinder.AutoSize = true;
            this.radioButtonKinder.Location = new System.Drawing.Point(62, 42);
            this.radioButtonKinder.Name = "radioButtonKinder";
            this.radioButtonKinder.Size = new System.Drawing.Size(55, 17);
            this.radioButtonKinder.TabIndex = 3;
            this.radioButtonKinder.TabStop = true;
            this.radioButtonKinder.Text = "Kinder";
            this.radioButtonKinder.UseVisualStyleBackColor = true;
            // 
            // radioButtonDoku
            // 
            this.radioButtonDoku.AutoSize = true;
            this.radioButtonDoku.Location = new System.Drawing.Point(1, 65);
            this.radioButtonDoku.Name = "radioButtonDoku";
            this.radioButtonDoku.Size = new System.Drawing.Size(51, 17);
            this.radioButtonDoku.TabIndex = 4;
            this.radioButtonDoku.TabStop = true;
            this.radioButtonDoku.Text = "Doku";
            this.radioButtonDoku.UseVisualStyleBackColor = true;
            // 
            // radioButtonKrimi
            // 
            this.radioButtonKrimi.AutoSize = true;
            this.radioButtonKrimi.Location = new System.Drawing.Point(62, 65);
            this.radioButtonKrimi.Name = "radioButtonKrimi";
            this.radioButtonKrimi.Size = new System.Drawing.Size(47, 17);
            this.radioButtonKrimi.TabIndex = 5;
            this.radioButtonKrimi.TabStop = true;
            this.radioButtonKrimi.Text = "Krimi";
            this.radioButtonKrimi.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.groupBoxGenre.ResumeLayout(false);
            this.groupBoxGenre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabelUser;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBoxGenre;
        private System.Windows.Forms.RadioButton radioButtonKrimi;
        private System.Windows.Forms.RadioButton radioButtonDoku;
        private System.Windows.Forms.RadioButton radioButtonKinder;
        private System.Windows.Forms.RadioButton radioButtonAction;
        private System.Windows.Forms.RadioButton radioButtonThriller;
        private System.Windows.Forms.RadioButton radioButtonDrama;
        private System.Windows.Forms.ListView listViewMovie;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}

