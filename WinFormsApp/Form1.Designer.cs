namespace WinFormsApp
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
            label1 = new Label();
            GetAllItems = new DataGridView();
            GetOneItem = new Label();
            ((System.ComponentModel.ISupportInitialize)GetAllItems).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 42);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "GetOneItem()";
            // 
            // GetAllItems
            // 
            GetAllItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GetAllItems.Location = new Point(642, 68);
            GetAllItems.Name = "GetAllItems";
            GetAllItems.RowHeadersWidth = 51;
            GetAllItems.RowTemplate.Height = 29;
            GetAllItems.Size = new Size(630, 328);
            GetAllItems.TabIndex = 2;
            // 
            // GetOneItem
            // 
            GetOneItem.AutoSize = true;
            GetOneItem.Location = new Point(75, 91);
            GetOneItem.Name = "GetOneItem";
            GetOneItem.Size = new Size(50, 20);
            GetOneItem.TabIndex = 3;
            GetOneItem.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1305, 568);
            Controls.Add(GetOneItem);
            Controls.Add(GetAllItems);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)GetAllItems).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DataGridView GetAllItems;
        private Label GetOneItem;
    }
}