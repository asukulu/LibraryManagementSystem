namespace LibraryManagementSystem
{
    partial class ManageItemsForm
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
            groupBox1 = new GroupBox();
            txtDVDItemId = new TextBox();
            txtDVDRating = new TextBox();
            txtDVDDuration = new TextBox();
            txtDVDDirector = new TextBox();
            txtDVDTitle = new TextBox();
            btnAddDVD = new Button();
            t5 = new Label();
            t4 = new Label();
            t3 = new Label();
            t2 = new Label();
            t = new Label();
            dgvItems = new DataGridView();
            btnLoadItems = new Button();
            btnClose = new Button();
            groupBox2 = new GroupBox();
            txtBookItemId = new TextBox();
            txtBookPages = new TextBox();
            txtBookISBN = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookTitle = new TextBox();
            btnAddBook = new Button();
            label1 = new Label();
            label2 = new Label();
            la = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtDVDItemId);
            groupBox1.Controls.Add(txtDVDRating);
            groupBox1.Controls.Add(txtDVDDuration);
            groupBox1.Controls.Add(txtDVDDirector);
            groupBox1.Controls.Add(txtDVDTitle);
            groupBox1.Controls.Add(btnAddDVD);
            groupBox1.Controls.Add(t5);
            groupBox1.Controls.Add(t4);
            groupBox1.Controls.Add(t3);
            groupBox1.Controls.Add(t2);
            groupBox1.Controls.Add(t);
            groupBox1.Location = new Point(12, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(400, 300);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add DVD";
            // 
            // txtDVDItemId
            // 
            txtDVDItemId.Location = new Point(171, 215);
            txtDVDItemId.Name = "txtDVDItemId";
            txtDVDItemId.Size = new Size(100, 23);
            txtDVDItemId.TabIndex = 10;
            // 
            // txtDVDRating
            // 
            txtDVDRating.Location = new Point(171, 177);
            txtDVDRating.Name = "txtDVDRating";
            txtDVDRating.Size = new Size(100, 23);
            txtDVDRating.TabIndex = 9;
            // 
            // txtDVDDuration
            // 
            txtDVDDuration.Location = new Point(171, 138);
            txtDVDDuration.Name = "txtDVDDuration";
            txtDVDDuration.Size = new Size(100, 23);
            txtDVDDuration.TabIndex = 8;
            // 
            // txtDVDDirector
            // 
            txtDVDDirector.Location = new Point(171, 96);
            txtDVDDirector.Name = "txtDVDDirector";
            txtDVDDirector.Size = new Size(100, 23);
            txtDVDDirector.TabIndex = 7;
            // 
            // txtDVDTitle
            // 
            txtDVDTitle.Location = new Point(171, 59);
            txtDVDTitle.Name = "txtDVDTitle";
            txtDVDTitle.Size = new Size(100, 23);
            txtDVDTitle.TabIndex = 6;
            // 
            // btnAddDVD
            // 
            btnAddDVD.Location = new Point(171, 256);
            btnAddDVD.Name = "btnAddDVD";
            btnAddDVD.Size = new Size(75, 23);
            btnAddDVD.TabIndex = 5;
            btnAddDVD.Text = "Add DVD";
            btnAddDVD.UseVisualStyleBackColor = true;
            btnAddDVD.Click += btnAddDVD_Click;
            // 
            // t5
            // 
            t5.AutoSize = true;
            t5.Location = new Point(36, 215);
            t5.Name = "t5";
            t5.Size = new Size(48, 15);
            t5.TabIndex = 4;
            t5.Text = "Item ID:";
            // 
            // t4
            // 
            t4.AutoSize = true;
            t4.Location = new Point(36, 177);
            t4.Name = "t4";
            t4.Size = new Size(50, 15);
            t4.TabIndex = 3;
            t4.Text = "Rating : ";
            // 
            // t3
            // 
            t3.AutoSize = true;
            t3.Location = new Point(36, 138);
            t3.Name = "t3";
            t3.Size = new Size(99, 15);
            t3.TabIndex = 2;
            t3.Text = "Duration (mins) : ";
            // 
            // t2
            // 
            t2.AutoSize = true;
            t2.Location = new Point(36, 99);
            t2.Name = "t2";
            t2.Size = new Size(55, 15);
            t2.TabIndex = 1;
            t2.Text = "Director :";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Location = new Point(36, 62);
            t.Name = "t";
            t.Size = new Size(33, 15);
            t.TabIndex = 0;
            t.Text = "Title:";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToOrderColumns = true;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItems.Dock = DockStyle.Bottom;
            dgvItems.Location = new Point(0, 497);
            dgvItems.Name = "dgvItems";
            dgvItems.Size = new Size(884, 164);
            dgvItems.TabIndex = 1;
            // 
            // btnLoadItems
            // 
            btnLoadItems.Location = new Point(435, 53);
            btnLoadItems.Name = "btnLoadItems";
            btnLoadItems.Size = new Size(114, 23);
            btnLoadItems.TabIndex = 2;
            btnLoadItems.Text = "Load All Items";
            btnLoadItems.UseVisualStyleBackColor = true;
            btnLoadItems.Click += btnLoadItems_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(505, 468);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtBookItemId);
            groupBox2.Controls.Add(txtBookPages);
            groupBox2.Controls.Add(txtBookISBN);
            groupBox2.Controls.Add(txtBookAuthor);
            groupBox2.Controls.Add(txtBookTitle);
            groupBox2.Controls.Add(btnAddBook);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(la);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(418, 100);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(400, 300);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Book";
            // 
            // txtBookItemId
            // 
            txtBookItemId.Location = new Point(171, 215);
            txtBookItemId.Name = "txtBookItemId";
            txtBookItemId.Size = new Size(100, 23);
            txtBookItemId.TabIndex = 10;
            // 
            // txtBookPages
            // 
            txtBookPages.Location = new Point(171, 177);
            txtBookPages.Name = "txtBookPages";
            txtBookPages.Size = new Size(100, 23);
            txtBookPages.TabIndex = 9;
            // 
            // txtBookISBN
            // 
            txtBookISBN.Location = new Point(171, 138);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(100, 23);
            txtBookISBN.TabIndex = 8;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(171, 96);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(100, 23);
            txtBookAuthor.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.Location = new Point(171, 59);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(100, 23);
            txtBookTitle.TabIndex = 6;
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(171, 256);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(75, 23);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 215);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 4;
            label1.Text = "Item ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 177);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 3;
            label2.Text = "Pages : ";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Location = new Point(36, 138);
            la.Name = "la";
            la.Size = new Size(35, 15);
            la.TabIndex = 2;
            la.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(36, 99);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 1;
            label4.Text = "Author :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 62);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 0;
            label5.Text = "Title:";
            // 
            // ManageItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 661);
            Controls.Add(groupBox2);
            Controls.Add(btnClose);
            Controls.Add(btnLoadItems);
            Controls.Add(dgvItems);
            Controls.Add(groupBox1);
            Name = "ManageItemsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Books & DVDs\"";
            Load += mi_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label t5;
        private Label t3;
        private Label t2;
        private Label t;
        public Button btnAddDVD;
        private DataGridView dgvItems;
        private Button btnLoadItems;
        private Button btnClose;
        private TextBox txtDVDItemId;
        private TextBox txtDVDRating;
        private TextBox txtDVDDuration;
        private TextBox txtDVDDirector;
        private TextBox txtDVDTitle;
        private Label t4;
        private GroupBox groupBox2;
        private TextBox txtBookItemId;
        private TextBox txtBookPages;
        private TextBox txtBookISBN;
        private TextBox txtBookAuthor;
        private TextBox txtBookTitle;
        public Button btnAddBook;
        private Label label1;
        private Label label2;
        private Label la;
        private Label label4;
        private Label label5;
    }
}