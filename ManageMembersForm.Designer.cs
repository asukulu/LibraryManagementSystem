
namespace LibraryManagementSystem
{
    partial class ManageMembersForm
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            groupBox1 = new GroupBox();
            btnAddMember = new Button();
            txtMemberName = new TextBox();
            txtMemberId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnCheckout = new Button();
            btnReturn = new Button();
            txtCheckoutItemId = new TextBox();
            txtCheckoutMemberId = new TextBox();
            label4 = new Label();
            m = new Label();
            groupBox3 = new GroupBox();
            lblMemberInfo2 = new Label();
            txtViewMemberId = new TextBox();
            label3 = new Label();
            btnSearchMember = new Button();
            dgvMembers = new DataGridView();
            btnLoadMembers = new Button();
            close = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(btnAddMember);
            groupBox1.Controls.Add(txtMemberName);
            groupBox1.Controls.Add(txtMemberId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.FromArgb(30, 58, 138);
            groupBox1.Location = new Point(30, 20);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 180);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // btnAddMember
            // 
            btnAddMember.BackColor = Color.FromArgb(16, 185, 129);
            btnAddMember.FlatAppearance.BorderSize = 0;
            btnAddMember.FlatStyle = FlatStyle.Flat;
            btnAddMember.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddMember.ForeColor = Color.White;
            btnAddMember.Location = new Point(144, 112);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(150, 40);
            btnAddMember.TabIndex = 6;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = false;
            btnAddMember.Click += button1_Click;
            // 
            // txtMemberName
            // 
            txtMemberName.BorderStyle = BorderStyle.FixedSingle;
            txtMemberName.Font = new Font("Segoe UI", 9.75F);
            txtMemberName.Location = new Point(122, 68);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(180, 25);
            txtMemberName.TabIndex = 5;
            // 
            // txtMemberId
            // 
            txtMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtMemberId.Font = new Font("Segoe UI", 9.75F);
            txtMemberId.Location = new Point(122, 39);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(180, 25);
            txtMemberId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F);
            label2.ForeColor = Color.FromArgb(71, 85, 105);
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(46, 17);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F);
            label1.ForeColor = Color.FromArgb(71, 85, 105);
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(77, 17);
            label1.TabIndex = 1;
            label1.Text = "Member ID:";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.White;
            groupBox2.Controls.Add(btnCheckout);
            groupBox2.Controls.Add(btnReturn);
            groupBox2.Controls.Add(txtCheckoutItemId);
            groupBox2.Controls.Add(txtCheckoutMemberId);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(m);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox2.ForeColor = Color.FromArgb(30, 58, 138);
            groupBox2.Location = new Point(30, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(320, 230);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Checkout/Return Items";
            // 
            // btnCheckout
            // 
            btnCheckout.BackColor = Color.FromArgb(59, 130, 246);
            btnCheckout.FlatAppearance.BorderSize = 0;
            btnCheckout.FlatStyle = FlatStyle.Flat;
            btnCheckout.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCheckout.ForeColor = Color.White;
            btnCheckout.Location = new Point(164, 108);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(150, 40);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout Item";
            btnCheckout.UseVisualStyleBackColor = false;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnReturn
            // 
            btnReturn.BackColor = Color.FromArgb(251, 146, 60);
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReturn.ForeColor = Color.White;
            btnReturn.Location = new Point(6, 108);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(150, 40);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Item";
            btnReturn.UseVisualStyleBackColor = false;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtCheckoutItemId
            // 
            txtCheckoutItemId.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutItemId.Font = new Font("Segoe UI", 9.75F);
            txtCheckoutItemId.Location = new Point(122, 69);
            txtCheckoutItemId.Name = "txtCheckoutItemId";
            txtCheckoutItemId.Size = new Size(180, 25);
            txtCheckoutItemId.TabIndex = 3;
            // 
            // txtCheckoutMemberId
            // 
            txtCheckoutMemberId.BorderStyle = BorderStyle.FixedSingle;
            txtCheckoutMemberId.Font = new Font("Segoe UI", 9.75F);
            txtCheckoutMemberId.Location = new Point(122, 37);
            txtCheckoutMemberId.Name = "txtCheckoutMemberId";
            txtCheckoutMemberId.Size = new Size(180, 25);
            txtCheckoutMemberId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F);
            label4.ForeColor = Color.FromArgb(71, 85, 105);
            label4.Location = new Point(22, 69);
            label4.Name = "label4";
            label4.Size = new Size(52, 17);
            label4.TabIndex = 1;
            label4.Text = "Item ID:";
            // 
            // m
            // 
            m.AutoSize = true;
            m.Font = new Font("Segoe UI", 9.75F);
            m.ForeColor = Color.FromArgb(71, 85, 105);
            m.Location = new Point(22, 40);
            m.Name = "m";
            m.Size = new Size(77, 17);
            m.TabIndex = 0;
            m.Text = "Member ID:";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.White;
            groupBox3.Controls.Add(lblMemberInfo2);
            groupBox3.Controls.Add(txtViewMemberId);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnSearchMember);
            groupBox3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox3.ForeColor = Color.FromArgb(30, 58, 138);
            groupBox3.Location = new Point(380, 20);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(680, 430);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "View Member Details";
            // 
            // lblMemberInfo2
            // 
            lblMemberInfo2.BackColor = Color.FromArgb(249, 250, 251);
            lblMemberInfo2.BorderStyle = BorderStyle.FixedSingle;
            lblMemberInfo2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMemberInfo2.Location = new Point(6, 91);
            lblMemberInfo2.Name = "lblMemberInfo2";
            lblMemberInfo2.Padding = new Padding(10);
            lblMemberInfo2.Size = new Size(640, 300);
            lblMemberInfo2.TabIndex = 2;
            lblMemberInfo2.Text = "Member Info:";
            // 
            // txtViewMemberId
            // 
            txtViewMemberId.Location = new Point(137, 48);
            txtViewMemberId.Name = "txtViewMemberId";
            txtViewMemberId.Size = new Size(150, 29);
            txtViewMemberId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(54, 54);
            label3.Name = "label3";
            label3.Size = new Size(77, 17);
            label3.TabIndex = 0;
            label3.Text = "Member ID:";
            // 
            // btnSearchMember
            // 
            btnSearchMember.BackColor = Color.FromArgb(139, 92, 246);
            btnSearchMember.FlatAppearance.BorderSize = 0;
            btnSearchMember.FlatStyle = FlatStyle.Flat;
            btnSearchMember.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSearchMember.ForeColor = Color.White;
            btnSearchMember.Location = new Point(182, 384);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(150, 40);
            btnSearchMember.TabIndex = 3;
            btnSearchMember.Text = "Search Member";
            btnSearchMember.UseVisualStyleBackColor = false;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // dgvMembers
            // 
            dataGridViewCellStyle4.BackColor = Color.FromArgb(249, 250, 251);
            dgvMembers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvMembers.BackgroundColor = Color.White;
            dgvMembers.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvMembers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvMembers.DefaultCellStyle = dataGridViewCellStyle6;
            dgvMembers.EnableHeadersVisualStyles = false;
            dgvMembers.Location = new Point(30, 530);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMembers.Size = new Size(950, 200);
            dgvMembers.TabIndex = 4;
            // 
            // btnLoadMembers
            // 
            btnLoadMembers.BackColor = Color.FromArgb(99, 102, 241);
            btnLoadMembers.FlatAppearance.BorderSize = 0;
            btnLoadMembers.FlatStyle = FlatStyle.Flat;
            btnLoadMembers.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLoadMembers.ForeColor = Color.White;
            btnLoadMembers.Location = new Point(30, 470);
            btnLoadMembers.Name = "btnLoadMembers";
            btnLoadMembers.Size = new Size(180, 45);
            btnLoadMembers.TabIndex = 5;
            btnLoadMembers.Text = "Load All Members";
            btnLoadMembers.UseVisualStyleBackColor = false;
            btnLoadMembers.Click += btnLoadMembers_Click;
            // 
            // close
            // 
            close.BackColor = Color.FromArgb(239, 68, 68);
            close.FlatAppearance.BorderSize = 0;
            close.FlatStyle = FlatStyle.Flat;
            close.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            close.ForeColor = Color.White;
            close.Location = new Point(935, 714);
            close.Name = "close";
            close.Size = new Size(150, 45);
            close.TabIndex = 6;
            close.Text = "Close";
            close.UseVisualStyleBackColor = false;
            close.Click += Close_Click;
            // 
            // ManageMembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            ClientSize = new Size(1084, 761);
            Controls.Add(close);
            Controls.Add(btnLoadMembers);
            Controls.Add(dgvMembers);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ManageMembersForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Manage Members & Transactions";
            Load += ManageMembersForm_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).EndInit();
            ResumeLayout(false);
        }

        private void ManageMembersForm_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        // Add these hover effect methods

        private void btnAddMember_MouseEnter(object sender, EventArgs e)
        {
            btnAddMember.BackColor = Color.FromArgb(5, 150, 105);
        }

        private void btnAddMember_MouseLeave(object sender, EventArgs e)
        {
            btnAddMember.BackColor = Color.FromArgb(16, 185, 129);
        }

        private void btnCheckout_MouseEnter(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.FromArgb(37, 99, 235);
        }

        private void btnCheckout_MouseLeave(object sender, EventArgs e)
        {
            btnCheckout.BackColor = Color.FromArgb(59, 130, 246);
        }

        private void btnReturn_MouseEnter(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.FromArgb(234, 88, 12);
        }

        private void btnReturn_MouseLeave(object sender, EventArgs e)
        {
            btnReturn.BackColor = Color.FromArgb(251, 146, 60);
        }

        private void btnSearchMember_MouseEnter(object sender, EventArgs e)
        {
            btnSearchMember.BackColor = Color.FromArgb(109, 40, 217);
        }

        private void btnSearchMember_MouseLeave(object sender, EventArgs e)
        {
            btnSearchMember.BackColor = Color.FromArgb(139, 92, 246);
        }

        private void btnLoadMembers_MouseEnter(object sender, EventArgs e)
        {
            btnLoadMembers.BackColor = Color.FromArgb(79, 70, 229);
        }

        private void btnLoadMembers_MouseLeave(object sender, EventArgs e)
        {
            btnLoadMembers.BackColor = Color.FromArgb(99, 102, 241);
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            // Assuming your close button is named something, adjust the name
            ((Button)sender).BackColor = Color.FromArgb(220, 38, 38);
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.FromArgb(239, 68, 68);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private Button btnAddMember;
        private TextBox txtMemberName;
        private TextBox txtMemberId;
        private GroupBox groupBox2;
        private Label label4;
        private Label m;
        private Button btnReturn;
        private TextBox txtCheckoutItemId;
        private TextBox txtCheckoutMemberId;
        private GroupBox groupBox3;
        private Label label3;
        //private TextBox lblMemberInfo;
       private Label lblMemberInfo;
        private TextBox txtViewMemberId;
        private Button btnSearchMember;
        private DataGridView dgvMembers;
        private Button btnLoadMembers;
        private Button close;
        private Label lblMemberInfo2;
        private Button btnCheckout;
    }



}

