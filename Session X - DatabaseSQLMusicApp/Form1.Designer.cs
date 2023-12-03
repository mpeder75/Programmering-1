namespace Session_X___DatabaseSQLMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            loadAlbumsButton = new Button();
            dgvLoadAlbums = new DataGridView();
            searchTextBox = new TextBox();
            searchAlbumsButton = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvLoadAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // loadAlbumsButton
            // 
            loadAlbumsButton.Location = new Point(251, 40);
            loadAlbumsButton.Name = "loadAlbumsButton";
            loadAlbumsButton.Size = new Size(127, 23);
            loadAlbumsButton.TabIndex = 0;
            loadAlbumsButton.Text = "Load Albums";
            loadAlbumsButton.UseVisualStyleBackColor = true;
            loadAlbumsButton.Click += loadAlbumsButton_Click;
            // 
            // dgvLoadAlbums
            // 
            dgvLoadAlbums.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadAlbums.Location = new Point(251, 101);
            dgvLoadAlbums.Name = "dgvLoadAlbums";
            dgvLoadAlbums.RowTemplate.Height = 25;
            dgvLoadAlbums.Size = new Size(714, 166);
            dgvLoadAlbums.TabIndex = 3;
            dgvLoadAlbums.CellClick += dgvLoadAlbums_CellClick;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(432, 40);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 4;
            // 
            // searchAlbumsButton
            // 
            searchAlbumsButton.Location = new Point(574, 40);
            searchAlbumsButton.Name = "searchAlbumsButton";
            searchAlbumsButton.Size = new Size(75, 23);
            searchAlbumsButton.TabIndex = 5;
            searchAlbumsButton.Text = "Search";
            searchAlbumsButton.UseVisualStyleBackColor = true;
            searchAlbumsButton.Click += searchAlbumsButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(233, 166);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(pictureBox1);
            Controls.Add(searchAlbumsButton);
            Controls.Add(searchTextBox);
            Controls.Add(dgvLoadAlbums);
            Controls.Add(loadAlbumsButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLoadAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAlbumsButton;
        private DataGridView dgvLoadAlbums;
        private TextBox searchTextBox;
        private Button searchAlbumsButton;
        private PictureBox pictureBox1;
    }
}
