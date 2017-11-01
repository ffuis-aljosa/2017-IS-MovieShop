namespace MovieShop
{
    partial class MoviesForm
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
            this.moviesListBox = new System.Windows.Forms.ListBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.yearLabel = new System.Windows.Forms.Label();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // moviesListBox
            // 
            this.moviesListBox.FormattingEnabled = true;
            this.moviesListBox.Location = new System.Drawing.Point(341, 12);
            this.moviesListBox.Name = "moviesListBox";
            this.moviesListBox.Size = new System.Drawing.Size(304, 407);
            this.moviesListBox.TabIndex = 0;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(13, 13);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(285, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(13, 40);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(64, 13);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Naslov filma";
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(13, 73);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(285, 20);
            this.yearTextBox.TabIndex = 3;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(13, 100);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(93, 13);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Godina produkcije";
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Items.AddRange(new object[] {
            "Akcija",
            "Horor",
            "Drama",
            "Komedija",
            "Triler",
            "Krimi",
            "Romantika"});
            this.genreComboBox.Location = new System.Drawing.Point(13, 131);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(285, 21);
            this.genreComboBox.TabIndex = 5;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(13, 159);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(29, 13);
            this.genreLabel.TabIndex = 6;
            this.genreLabel.Text = "Žanr";
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(13, 396);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(286, 23);
            this.addMovieButton.TabIndex = 7;
            this.addMovieButton.Text = "Dodaj film";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.addMovieButton_Click);
            // 
            // MoviesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 436);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.moviesListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MoviesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filmoteka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox moviesListBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Button addMovieButton;
    }
}

