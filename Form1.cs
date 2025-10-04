using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // ... rest of your code

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnManageItems_Click(object sender, EventArgs e)
        {

            ManageItemsForm manageItemsForm = new ManageItemsForm();
            DialogResult dialogResult = manageItemsForm.ShowDialog();
        }

        private void btnManagerMembers_Click(object sender, EventArgs e)
        {
            ManageMembersForm manageMembersForm = new ManageMembersForm();
            manageMembersForm.ShowDialog();
        }


        // Add these methods to your Form1 class

        private void btnManageItems_MouseEnter(object sender, EventArgs e)
        {
            btnManageItems.BackColor = Color.FromArgb(37, 99, 235); // Darker blue
        }

        private void btnManageItems_MouseLeave(object sender, EventArgs e)
        {
            btnManageItems.BackColor = Color.FromArgb(59, 130, 246); // Original blue
        }

        private void btnManageMembers_MouseEnter(object sender, EventArgs e)
        {
            btnManagerMembers.BackColor = Color.FromArgb(5, 150, 105); // Darker green
        }

        private void btnManageMembers_MouseLeave(object sender, EventArgs e)
        {
            btnManagerMembers.BackColor = Color.FromArgb(16, 185, 129); // Original green
        }

        private void btnExit_MouseEnter(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(220, 38, 38); // Darker red
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(239, 68, 68); // Original red
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


