namespace LocalMediaLibrary
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.TV = new System.Windows.Forms.Button();
            this.Movies = new System.Windows.Forms.Button();
            this.Home = new System.Windows.Forms.Label();
            this.TopTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopDescription = new System.Windows.Forms.Label();
            this.PlayTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TV
            // 
            this.TV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.TV.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TV.Location = new System.Drawing.Point(656, 9);
            this.TV.Name = "TV";
            this.TV.Size = new System.Drawing.Size(105, 38);
            this.TV.TabIndex = 0;
            this.TV.Text = "TV Shows";
            this.TV.UseVisualStyleBackColor = true;
            this.TV.Click += new System.EventHandler(this.TV_Click);
            // 
            // Movies
            // 
            this.Movies.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Movies.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Movies.Location = new System.Drawing.Point(767, 9);
            this.Movies.Name = "Movies";
            this.Movies.Size = new System.Drawing.Size(100, 38);
            this.Movies.TabIndex = 1;
            this.Movies.Text = "Movies";
            this.Movies.UseVisualStyleBackColor = true;
            this.Movies.Click += new System.EventHandler(this.Movies_Click);
            // 
            // Home
            // 
            this.Home.AutoSize = true;
            this.Home.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Location = new System.Drawing.Point(12, 9);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(81, 32);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            // 
            // TopTitle
            // 
            this.TopTitle.AutoSize = true;
            this.TopTitle.Font = new System.Drawing.Font("Georgia", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopTitle.Location = new System.Drawing.Point(255, 53);
            this.TopTitle.MinimumSize = new System.Drawing.Size(612, 0);
            this.TopTitle.Name = "TopTitle";
            this.TopTitle.Size = new System.Drawing.Size(612, 72);
            this.TopTitle.TabIndex = 3;
            this.TopTitle.Text = "Title Text ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(228, 245);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // TopDescription
            // 
            this.TopDescription.AutoSize = true;
            this.TopDescription.Location = new System.Drawing.Point(263, 125);
            this.TopDescription.MaximumSize = new System.Drawing.Size(600, 125);
            this.TopDescription.MinimumSize = new System.Drawing.Size(600, 125);
            this.TopDescription.Name = "TopDescription";
            this.TopDescription.Size = new System.Drawing.Size(600, 125);
            this.TopDescription.TabIndex = 5;
            this.TopDescription.Text = resources.GetString("TopDescription.Text");
            // 
            // PlayTop
            // 
            this.PlayTop.BackColor = System.Drawing.Color.Red;
            this.PlayTop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PlayTop.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayTop.Location = new System.Drawing.Point(267, 257);
            this.PlayTop.Name = "PlayTop";
            this.PlayTop.Size = new System.Drawing.Size(123, 41);
            this.PlayTop.TabIndex = 6;
            this.PlayTop.Text = "Play";
            this.PlayTop.UseVisualStyleBackColor = false;
            this.PlayTop.Click += new System.EventHandler(this.PlayTop_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(875, 329);
            this.Controls.Add(this.PlayTop);
            this.Controls.Add(this.TopDescription);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TopTitle);
            this.Controls.Add(this.Home);
            this.Controls.Add(this.Movies);
            this.Controls.Add(this.TV);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "HomePage";
            this.Text = "Media Library";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TV;
        private System.Windows.Forms.Button Movies;
        private System.Windows.Forms.Label Home;
        private System.Windows.Forms.Label TopTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TopDescription;
        private System.Windows.Forms.Button PlayTop;
    }
}

