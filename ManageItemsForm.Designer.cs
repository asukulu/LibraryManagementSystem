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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            label3 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItems).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
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
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(30, 58, 138);
            groupBox1.Location = new Point(50, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 380);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add DVD";
            // 
            // txtDVDItemId
            // 
            txtDVDItemId.BorderStyle = BorderStyle.FixedSingle;
            txtDVDItemId.Font = new Font("Segoe UI", 9.75F);
            txtDVDItemId.Location = new Point(171, 215);
            txtDVDItemId.Name = "txtDVDItemId";
            txtDVDItemId.Size = new Size(191, 25);
            txtDVDItemId.TabIndex = 10;
            // 
            // txtDVDRating
            // 
            txtDVDRating.BorderStyle = BorderStyle.FixedSingle;
            txtDVDRating.Font = new Font("Segoe UI", 9.75F);
            txtDVDRating.Location = new Point(171, 177);
            txtDVDRating.Name = "txtDVDRating";
            txtDVDRating.Size = new Size(191, 25);
            txtDVDRating.TabIndex = 9;
            // 
            // txtDVDDuration
            // 
            txtDVDDuration.BorderStyle = BorderStyle.FixedSingle;
            txtDVDDuration.Font = new Font("Segoe UI", 9.75F);
            txtDVDDuration.Location = new Point(171, 138);
            txtDVDDuration.Name = "txtDVDDuration";
            txtDVDDuration.Size = new Size(191, 25);
            txtDVDDuration.TabIndex = 8;
            // 
            // txtDVDDirector
            // 
            txtDVDDirector.BorderStyle = BorderStyle.FixedSingle;
            txtDVDDirector.Font = new Font("Segoe UI", 9.75F);
            txtDVDDirector.Location = new Point(171, 96);
            txtDVDDirector.Name = "txtDVDDirector";
            txtDVDDirector.Size = new Size(191, 25);
            txtDVDDirector.TabIndex = 7;
            // 
            // txtDVDTitle
            // 
            txtDVDTitle.BorderStyle = BorderStyle.FixedSingle;
            txtDVDTitle.Font = new Font("Segoe UI", 9.75F);
            txtDVDTitle.Location = new Point(171, 59);
            txtDVDTitle.Name = "txtDVDTitle";
            txtDVDTitle.Size = new Size(191, 25);
            txtDVDTitle.TabIndex = 6;
            // 
            // btnAddDVD
            // 
            btnAddDVD.BackColor = Color.FromArgb(251, 146, 60);
            btnAddDVD.FlatStyle = FlatStyle.Flat;
            btnAddDVD.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddDVD.ForeColor = Color.White;
            btnAddDVD.Location = new Point(171, 256);
            btnAddDVD.Name = "btnAddDVD";
            btnAddDVD.Size = new Size(150, 45);
            btnAddDVD.TabIndex = 5;
            btnAddDVD.Text = "Add DVD";
            btnAddDVD.UseVisualStyleBackColor = false;
            btnAddDVD.Click += btnAddDVD_Click;
            // 
            // t5
            // 
            t5.AutoSize = true;
            t5.Font = new Font("Segoe UI", 9.75F);
            t5.ForeColor = Color.FromArgb(71, 85, 105);
            t5.Location = new Point(36, 215);
            t5.Name = "t5";
            t5.Size = new Size(52, 17);
            t5.TabIndex = 4;
            t5.Text = "Item ID:";
            // 
            // t4
            // 
            t4.AutoSize = true;
            t4.Font = new Font("Segoe UI", 9.75F);
            t4.ForeColor = Color.FromArgb(71, 85, 105);
            t4.Location = new Point(36, 177);
            t4.Name = "t4";
            t4.Size = new Size(56, 17);
            t4.TabIndex = 3;
            t4.Text = "Rating : ";
            // 
            // t3
            // 
            t3.AutoSize = true;
            t3.Font = new Font("Segoe UI", 9.75F);
            t3.ForeColor = Color.FromArgb(71, 85, 105);
            t3.Location = new Point(36, 138);
            t3.Name = "t3";
            t3.Size = new Size(108, 17);
            t3.TabIndex = 2;
            t3.Text = "Duration (mins) : ";
            // 
            // t2
            // 
            t2.AutoSize = true;
            t2.Font = new Font("Segoe UI", 9.75F);
            t2.ForeColor = Color.FromArgb(71, 85, 105);
            t2.Location = new Point(36, 99);
            t2.Name = "t2";
            t2.Size = new Size(62, 17);
            t2.TabIndex = 1;
            t2.Text = "Director :";
            // 
            // t
            // 
            t.AutoSize = true;
            t.Font = new Font("Segoe UI", 9.75F);
            t.ForeColor = Color.FromArgb(71, 85, 105);
            t.Location = new Point(36, 62);
            t.Name = "t";
            t.Size = new Size(35, 17);
            t.TabIndex = 0;
            t.Text = "Title:";
            // 
            // dgvItems
            // 
            dgvItems.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 250, 251);
            dgvItems.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvItems.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItems.BackgroundColor = Color.White;
            dgvItems.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvItems.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvItems.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvItems.DefaultCellStyle = dataGridViewCellStyle3;
            dgvItems.Dock = DockStyle.Bottom;
            dgvItems.EnableHeadersVisualStyles = false;
            dgvItems.Location = new Point(0, 561);
            dgvItems.Name = "dgvItems";
            dgvItems.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItems.Size = new Size(984, 150);
            dgvItems.TabIndex = 1;
            // 
            // btnLoadItems
            // 
            btnLoadItems.BackColor = Color.FromArgb(99, 102, 241);
            btnLoadItems.Cursor = Cursors.Hand;
            btnLoadItems.FlatAppearance.BorderSize = 0;
            btnLoadItems.FlatStyle = FlatStyle.Flat;
            btnLoadItems.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadItems.ForeColor = Color.White;
            btnLoadItems.Location = new Point(410, 70);
            btnLoadItems.Name = "btnLoadItems";
            btnLoadItems.Size = new Size(180, 45);
            btnLoadItems.TabIndex = 2;
            btnLoadItems.Text = "Load All Items";
            btnLoadItems.UseVisualStyleBackColor = false;
            btnLoadItems.Click += btnLoadItems_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(239, 68, 68);
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(721, 654);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(150, 45);
            btnClose.TabIndex = 3;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
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
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(30, 58, 138);
            groupBox2.Location = new Point(550, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(380, 380);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Add New Book";
            // 
            // txtBookItemId
            // 
            txtBookItemId.BorderStyle = BorderStyle.FixedSingle;
            txtBookItemId.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBookItemId.Location = new Point(153, 215);
            txtBookItemId.Name = "txtBookItemId";
            txtBookItemId.Size = new Size(200, 25);
            txtBookItemId.TabIndex = 10;
            // 
            // txtBookPages
            // 
            txtBookPages.BorderStyle = BorderStyle.FixedSingle;
            txtBookPages.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBookPages.Location = new Point(153, 177);
            txtBookPages.Name = "txtBookPages";
            txtBookPages.Size = new Size(200, 25);
            txtBookPages.TabIndex = 9;
            // 
            // txtBookISBN
            // 
            txtBookISBN.BorderStyle = BorderStyle.FixedSingle;
            txtBookISBN.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBookISBN.Location = new Point(153, 138);
            txtBookISBN.Name = "txtBookISBN";
            txtBookISBN.Size = new Size(200, 25);
            txtBookISBN.TabIndex = 8;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.BorderStyle = BorderStyle.FixedSingle;
            txtBookAuthor.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBookAuthor.Location = new Point(153, 96);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(200, 25);
            txtBookAuthor.TabIndex = 7;
            // 
            // txtBookTitle
            // 
            txtBookTitle.BorderStyle = BorderStyle.FixedSingle;
            txtBookTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold);
            txtBookTitle.Location = new Point(153, 59);
            txtBookTitle.Name = "txtBookTitle";
            txtBookTitle.Size = new Size(200, 25);
            txtBookTitle.TabIndex = 6;
            // 
            // btnAddBook
            // 
            btnAddBook.BackColor = Color.FromArgb(16, 185, 129);
            btnAddBook.FlatAppearance.BorderSize = 0;
            btnAddBook.FlatStyle = FlatStyle.Flat;
            btnAddBook.ForeColor = Color.White;
            btnAddBook.Location = new Point(171, 256);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(150, 45);
            btnAddBook.TabIndex = 5;
            btnAddBook.Text = "Add Book";
            btnAddBook.UseVisualStyleBackColor = false;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(36, 215);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 4;
            label1.Text = "Item ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(36, 177);
            label2.Name = "label2";
            label2.Size = new Size(54, 17);
            label2.TabIndex = 3;
            label2.Text = "Pages : ";
            // 
            // la
            // 
            la.AutoSize = true;
            la.Font = new Font("Segoe UI", 9.75F);
            la.ForeColor = Color.FromArgb(71, 85, 105);
            la.Location = new Point(36, 138);
            la.Name = "la";
            la.Size = new Size(38, 17);
            la.TabIndex = 2;
            la.Text = "ISBN:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(36, 99);
            label4.Name = "label4";
            label4.Size = new Size(54, 17);
            label4.TabIndex = 1;
            label4.Text = "Author :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F);
            label5.ForeColor = Color.FromArgb(71, 85, 105);
            label5.Location = new Point(36, 62);
            label5.Name = "label5";
            label5.Size = new Size(35, 17);
            label5.TabIndex = 0;
            label5.Text = "Title:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(30, 58, 138);
            label3.Location = new Point(320, 20);
            label3.Name = "label3";
            label3.Size = new Size(290, 37);
            label3.TabIndex = 12;
            label3.Text = "Manage Books & DVDs";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ManageItemsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(984, 711);
            Controls.Add(label3);
            Controls.Add(groupBox2);
            Controls.Add(btnClose);
            Controls.Add(btnLoadItems);
            Controls.Add(dgvItems);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
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
            PerformLayout();
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
        private Label label3;
    }
}