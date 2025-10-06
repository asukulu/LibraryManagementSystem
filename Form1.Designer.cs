namespace LibraryManagementSystem
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
            btnManageItems = new Button();
            btnManagerMembers = new Button();
            btnExit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(30, 58, 138);
            label1.Location = new Point(183, 50);
            label1.Name = "label1";
            label1.Size = new Size(500, 50);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnManageItems
            // 
            btnManageItems.BackColor = Color.FromArgb(59, 130, 246);
            btnManageItems.Cursor = Cursors.Hand;
            btnManageItems.FlatAppearance.BorderSize = 0;
            btnManageItems.FlatStyle = FlatStyle.Flat;
            btnManageItems.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnManageItems.ForeColor = Color.White;
            btnManageItems.Location = new Point(279, 270);
            btnManageItems.Name = "btnManageItems";
            btnManageItems.Size = new Size(350, 80);
            btnManageItems.TabIndex = 1;
            btnManageItems.Text = "📚 Manage Books & DVDs";
            btnManageItems.UseVisualStyleBackColor = false;
            btnManageItems.Click += btnManageItems_Click;
            btnManageItems.MouseEnter += btnManageItems_MouseEnter;
            btnManageItems.MouseLeave += btnManageItems_MouseLeave;
            // 
            // btnManagerMembers
            // 
            btnManagerMembers.AutoSize = true;
            btnManagerMembers.BackColor = Color.FromArgb(16, 185, 129);
            btnManagerMembers.FlatAppearance.BorderSize = 0;
            btnManagerMembers.FlatStyle = FlatStyle.Flat;
            btnManagerMembers.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManagerMembers.ForeColor = Color.White;
            btnManagerMembers.Location = new Point(279, 166);
            btnManagerMembers.Name = "btnManagerMembers";
            btnManagerMembers.Size = new Size(350, 80);
            btnManagerMembers.TabIndex = 2;
            btnManagerMembers.Text = "👥 Manage Members & Transactions";
            btnManagerMembers.UseVisualStyleBackColor = false;
            btnManagerMembers.Click += btnManagerMembers_Click;
            btnManagerMembers.MouseEnter += btnManageMembers_MouseEnter;
            btnManagerMembers.MouseLeave += btnManageMembers_MouseLeave;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(239, 68, 68);
            btnExit.Cursor = Cursors.Hand;
            btnExit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(279, 387);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(350, 80);
            btnExit.TabIndex = 3;
            btnExit.Text = "🚪 Exit Application";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(100, 116, 139);
            label2.Location = new Point(341, 113);
            label2.Name = "label2";
            label2.Size = new Size(400, 50);
            label2.TabIndex = 4;
            label2.Text = "Manage your library with ease";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(label2);
            Controls.Add(btnExit);
            Controls.Add(btnManagerMembers);
            Controls.Add(btnManageItems);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Location = new Point(275, 280);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Library Management System";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnManageItems;
        private Button btnManagerMembers;
        private Button btnExit;
        private Label label2;
    }
}
