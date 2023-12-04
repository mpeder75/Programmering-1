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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            loadAlbumsButton = new Button();
            dgvLoadAlbums = new DataGridView();
            searchTextBox = new TextBox();
            searchAlbumsButton = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button1 = new Button();
            txtDescription = new TextBox();
            txtImageURL = new TextBox();
            txtYear = new TextBox();
            txtArtist = new TextBox();
            txtAlbumName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            dgvLoadTracks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvLoadAlbums).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoadTracks).BeginInit();
            SuspendLayout();
            // 
            // loadAlbumsButton
            // 
            loadAlbumsButton.Location = new Point(248, 73);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dgvLoadAlbums.DefaultCellStyle = dataGridViewCellStyle1;
            dgvLoadAlbums.Location = new Point(248, 101);
            dgvLoadAlbums.Name = "dgvLoadAlbums";
            dgvLoadAlbums.RowTemplate.Height = 25;
            dgvLoadAlbums.Size = new Size(561, 253);
            dgvLoadAlbums.TabIndex = 3;
            dgvLoadAlbums.CellClick += dgvLoadAlbums_CellClick;
            // 
            // searchTextBox
            // 
            searchTextBox.Location = new Point(397, 73);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(136, 23);
            searchTextBox.TabIndex = 4;
            // 
            // searchAlbumsButton
            // 
            searchAlbumsButton.Location = new Point(539, 72);
            searchAlbumsButton.Name = "searchAlbumsButton";
            searchAlbumsButton.Size = new Size(75, 23);
            searchAlbumsButton.TabIndex = 5;
            searchAlbumsButton.Text = "Search";
            searchAlbumsButton.UseVisualStyleBackColor = true;
            searchAlbumsButton.Click += searchAlbumsButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(815, 101);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(191, 174);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(txtDescription);
            groupBox1.Controls.Add(txtImageURL);
            groupBox1.Controls.Add(txtYear);
            groupBox1.Controls.Add(txtArtist);
            groupBox1.Controls.Add(txtAlbumName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(9, 73);
            groupBox1.Margin = new Padding(0);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(0);
            groupBox1.Size = new Size(223, 281);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Location = new Point(106, 241);
            button1.Name = "button1";
            button1.Size = new Size(94, 37);
            button1.TabIndex = 10;
            button1.Text = "Add Album";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(106, 200);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(94, 23);
            txtDescription.TabIndex = 9;
            // 
            // txtImageURL
            // 
            txtImageURL.Location = new Point(106, 157);
            txtImageURL.Name = "txtImageURL";
            txtImageURL.Size = new Size(94, 23);
            txtImageURL.TabIndex = 8;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(106, 114);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(94, 23);
            txtYear.TabIndex = 7;
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(106, 71);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(94, 23);
            txtArtist.TabIndex = 6;
            // 
            // txtAlbumName
            // 
            txtAlbumName.Location = new Point(106, 28);
            txtAlbumName.Name = "txtAlbumName";
            txtAlbumName.Size = new Size(94, 23);
            txtAlbumName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 203);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 4;
            label5.Text = "Description";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 165);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 3;
            label4.Text = "ImageURL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 122);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 2;
            label3.Text = "Year";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 79);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 1;
            label2.Text = "Artist";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Album name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(252, 387);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 8;
            label6.Text = "Tracks";
            // 
            // dgvLoadTracks
            // 
            dgvLoadTracks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLoadTracks.Location = new Point(252, 405);
            dgvLoadTracks.Name = "dgvLoadTracks";
            dgvLoadTracks.RowTemplate.Height = 25;
            dgvLoadTracks.Size = new Size(499, 175);
            dgvLoadTracks.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1008, 729);
            Controls.Add(dgvLoadTracks);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(searchAlbumsButton);
            Controls.Add(searchTextBox);
            Controls.Add(dgvLoadAlbums);
            Controls.Add(loadAlbumsButton);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvLoadAlbums).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLoadTracks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loadAlbumsButton;
        private DataGridView dgvLoadAlbums;
        private TextBox searchTextBox;
        private Button searchAlbumsButton;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label4;
        private TextBox txtDescription;
        private TextBox txtImageURL;
        private TextBox txtYear;
        private TextBox txtArtist;
        private TextBox txtAlbumName;
        private Button button1;
        private Label label6;
        private DataGridView dgvLoadTracks;
    }
}
