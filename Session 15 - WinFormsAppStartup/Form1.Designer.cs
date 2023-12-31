﻿namespace WinFormsApp
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
            GetAllItems = new DataGridView();
            GetOneItem = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)GetAllItems).BeginInit();
            SuspendLayout();
            // 
            // GetAllItems
            // 
            GetAllItems.BackgroundColor = SystemColors.ActiveCaption;
            GetAllItems.BorderStyle = BorderStyle.None;
            GetAllItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GetAllItems.Location = new Point(581, 259);
            GetAllItems.Margin = new Padding(3, 3, 6, 3);
            GetAllItems.Name = "GetAllItems";
            GetAllItems.RowHeadersWidth = 51;
            GetAllItems.RowTemplate.Height = 29;
            GetAllItems.ScrollBars = ScrollBars.Horizontal;
            GetAllItems.Size = new Size(930, 355);
            GetAllItems.TabIndex = 2;
            GetAllItems.CellContentClick += GetAllItems_CellContentClick;
            // 
            // GetOneItem
            // 
            GetOneItem.AutoSize = true;
            GetOneItem.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            GetOneItem.Location = new Point(98, 259);
            GetOneItem.Margin = new Padding(6, 0, 3, 0);
            GetOneItem.Name = "GetOneItem";
            GetOneItem.Size = new Size(97, 30);
            GetOneItem.TabIndex = 3;
            GetOneItem.Text = "label2";
            GetOneItem.Click += GetOneItem_Click;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.BackColor = SystemColors.ActiveCaption;
            textBox1.Font = new Font("Showcard Gothic", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(369, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 61);
            textBox1.TabIndex = 4;
            textBox1.Text = "Mogens Frugtbix";
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.ActiveCaption;
            textBox2.Font = new Font("Showcard Gothic", 36F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(605, 36);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(584, 82);
            textBox2.TabIndex = 5;
            textBox2.Text = "Mogens frugtbix";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.ActiveCaption;
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Showcard Gothic", 28.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.ActiveCaptionText;
            textBox3.Location = new Point(581, 22);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(440, 59);
            textBox3.TabIndex = 4;
            textBox3.Text = "Mogens frugtbix";
            textBox3.TextAlign = HorizontalAlignment.Center;
            textBox3.Click += exitButton_Click;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.ActiveCaption;
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(102, 225);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(223, 31);
            textBox4.TabIndex = 5;
            textBox4.Text = "Requested item:";
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.BackColor = SystemColors.ActiveCaption;
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("JetBrains Mono NL", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            textBox5.Location = new Point(581, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(233, 31);
            textBox5.TabIndex = 6;
            textBox5.Text = "Total inventory:";
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.ActiveCaption;
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Showcard Gothic", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBox6.Location = new Point(581, 106);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(452, 29);
            textBox6.TabIndex = 7;
            textBox6.Text = " Vi sælger ik meloner - de er træls !";
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(98, 653);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(120, 48);
            exitButton.TabIndex = 8;
            exitButton.Text = "Exit store";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1662, 758);
            Controls.Add(exitButton);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(GetOneItem);
            Controls.Add(GetAllItems);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GetAllItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView GetAllItems;
        private Label GetOneItem;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Button exitButton;
    }
}