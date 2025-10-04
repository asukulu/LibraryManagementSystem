
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
            Close = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMembers).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAddMember);
            groupBox1.Controls.Add(txtMemberName);
            groupBox1.Controls.Add(txtMemberId);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(306, 150);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add New Member";
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(144, 112);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(120, 30);
            btnAddMember.TabIndex = 6;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += button1_Click;
            // 
            // txtMemberName
            // 
            txtMemberName.Location = new Point(122, 68);
            txtMemberName.Name = "txtMemberName";
            txtMemberName.Size = new Size(100, 23);
            txtMemberName.TabIndex = 5;
            // 
            // txtMemberId
            // 
            txtMemberId.Location = new Point(122, 39);
            txtMemberId.Name = "txtMemberId";
            txtMemberId.Size = new Size(100, 23);
            txtMemberId.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 71);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 42);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "Member ID:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnCheckout);
            groupBox2.Controls.Add(btnReturn);
            groupBox2.Controls.Add(txtCheckoutItemId);
            groupBox2.Controls.Add(txtCheckoutMemberId);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(m);
            groupBox2.Location = new Point(12, 187);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(306, 132);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Checkout/Return Items";
            // 
            // btnCheckout
            // 
            btnCheckout.Location = new Point(203, 98);
            btnCheckout.Name = "btnCheckout";
            btnCheckout.Size = new Size(97, 30);
            btnCheckout.TabIndex = 5;
            btnCheckout.Text = "Checkout Item";
            btnCheckout.UseVisualStyleBackColor = true;
            btnCheckout.Click += btnCheckout_Click;
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(102, 98);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(91, 30);
            btnReturn.TabIndex = 4;
            btnReturn.Text = "Return Item";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // txtCheckoutItemId
            // 
            txtCheckoutItemId.Location = new Point(122, 69);
            txtCheckoutItemId.Name = "txtCheckoutItemId";
            txtCheckoutItemId.Size = new Size(100, 23);
            txtCheckoutItemId.TabIndex = 3;
            // 
            // txtCheckoutMemberId
            // 
            txtCheckoutMemberId.Location = new Point(122, 37);
            txtCheckoutMemberId.Name = "txtCheckoutMemberId";
            txtCheckoutMemberId.Size = new Size(100, 23);
            txtCheckoutMemberId.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 69);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 1;
            label4.Text = "Item ID:";
            // 
            // m
            // 
            m.AutoSize = true;
            m.Location = new Point(22, 40);
            m.Name = "m";
            m.Size = new Size(69, 15);
            m.TabIndex = 0;
            m.Text = "Member ID:";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblMemberInfo2);
            groupBox3.Controls.Add(txtViewMemberId);
            groupBox3.Controls.Add(label3);
            groupBox3.Location = new Point(490, 41);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(450, 350);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "View Member Details";
            // 
            // lblMemberInfo2
            // 
            lblMemberInfo2.BorderStyle = BorderStyle.FixedSingle;
            lblMemberInfo2.Location = new Point(6, 91);
            lblMemberInfo2.Name = "lblMemberInfo2";
            lblMemberInfo2.Size = new Size(400, 200);
            lblMemberInfo2.TabIndex = 2;
            lblMemberInfo2.Text = "Member Info:";
            // 
            // txtViewMemberId
            // 
            txtViewMemberId.Location = new Point(147, 54);
            txtViewMemberId.Name = "txtViewMemberId";
            txtViewMemberId.Size = new Size(100, 23);
            txtViewMemberId.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 54);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 0;
            label3.Text = "Member ID:";
            // 
            // btnSearchMember
            // 
            btnSearchMember.Location = new Point(622, 425);
            btnSearchMember.Name = "btnSearchMember";
            btnSearchMember.Size = new Size(120, 30);
            btnSearchMember.TabIndex = 3;
            btnSearchMember.Text = "Search Member";
            btnSearchMember.UseVisualStyleBackColor = true;
            btnSearchMember.Click += btnSearchMember_Click;
            // 
            // dgvMembers
            // 
            dgvMembers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMembers.Location = new Point(12, 474);
            dgvMembers.Name = "dgvMembers";
            dgvMembers.Size = new Size(950, 200);
            dgvMembers.TabIndex = 4;
            // 
            // btnLoadMembers
            // 
            btnLoadMembers.Location = new Point(199, 438);
            btnLoadMembers.Name = "btnLoadMembers";
            btnLoadMembers.Size = new Size(129, 30);
            btnLoadMembers.TabIndex = 5;
            btnLoadMembers.Text = "Load All Members";
            btnLoadMembers.UseVisualStyleBackColor = true;
            btnLoadMembers.Click += btnLoadMembers_Click;
            // 
            // Close
            // 
            Close.Location = new Point(12, 678);
            Close.Name = "Close";
            Close.Size = new Size(129, 30);
            Close.TabIndex = 6;
            Close.Text = "close";
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // ManageMembersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 711);
            Controls.Add(Close);
            Controls.Add(btnLoadMembers);
            Controls.Add(dgvMembers);
            Controls.Add(btnSearchMember);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
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
        private Button Close;
        private Label lblMemberInfo2;
        private Button btnCheckout;
    }
}