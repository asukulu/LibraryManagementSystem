using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using LibraryManagementSystem.Models;

namespace LibraryManagementSystem
{
    public partial class ManageMembersForm : Form
    {
        public ManageMembersForm()
        {
            InitializeComponent();
        }


        private void btnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO members (MemberId, Name, Fines) VALUES (@memberId, @name, 0.00)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@memberId", txtMemberId.Text);
                    cmd.Parameters.AddWithValue("@name", txtMemberName.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtMemberId.Clear();
                    txtMemberName.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    DatabaseHelper dbHelper = new DatabaseHelper();
                    using (MySqlConnection conn = dbHelper.GetConnection())
                    {
                        conn.Open();
                        string query = "INSERT INTO members (MemberId, Name, Fines) VALUES (@memberId, @name, 0.00)";

                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@memberId", txtMemberId.Text);
                        cmd.Parameters.AddWithValue("@name", txtMemberName.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Member added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtMemberId.Clear();
                        txtMemberName.Clear();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Check if member exists
                    string memberCheck = "SELECT COUNT(*) FROM members WHERE MemberId = @memberId";
                    MySqlCommand memberCmd = new MySqlCommand(memberCheck, conn);
                    memberCmd.Parameters.AddWithValue("@memberId", txtCheckoutMemberId.Text);
                    int memberExists = Convert.ToInt32(memberCmd.ExecuteScalar());

                    if (memberExists == 0)
                    {
                        MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if item exists and is available (check both books and dvds)
                    string itemType = "";
                    bool isAvailable = false;

                    // Check in books
                    string bookCheck = "SELECT IsAvailable FROM books WHERE ItemId = @itemId";
                    MySqlCommand bookCmd = new MySqlCommand(bookCheck, conn);
                    bookCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                    object bookResult = bookCmd.ExecuteScalar();

                    if (bookResult != null)
                    {
                        itemType = "Book";
                        isAvailable = Convert.ToBoolean(bookResult);
                    }
                    else
                    {
                        // Check in DVDs
                        string dvdCheck = "SELECT IsAvailable FROM dvds WHERE ItemId = @itemId";
                        MySqlCommand dvdCmd = new MySqlCommand(dvdCheck, conn);
                        dvdCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                        object dvdResult = dvdCmd.ExecuteScalar();

                        if (dvdResult != null)
                        {
                            itemType = "DVD";
                            isAvailable = Convert.ToBoolean(dvdResult);
                        }
                    }

                    if (string.IsNullOrEmpty(itemType))
                    {
                        MessageBox.Show("Item not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!isAvailable)
                    {
                        MessageBox.Show("Item is not available!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Update item availability
                    string updateQuery = itemType == "Book"
                        ? "UPDATE books SET IsAvailable = 0 WHERE ItemId = @itemId"
                        : "UPDATE dvds SET IsAvailable = 0 WHERE ItemId = @itemId";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                    updateCmd.ExecuteNonQuery();

                    // Add transaction record
                    string transQuery = "INSERT INTO transactions (MemberId, ItemId, ItemType, CheckoutDate, Status) VALUES (@memberId, @itemId, @itemType, @checkoutDate, 'Checked Out')";
                    MySqlCommand transCmd = new MySqlCommand(transQuery, conn);
                    transCmd.Parameters.AddWithValue("@memberId", txtCheckoutMemberId.Text);
                    transCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                    transCmd.Parameters.AddWithValue("@itemType", itemType);
                    transCmd.Parameters.AddWithValue("@checkoutDate", DateTime.Now);
                    transCmd.ExecuteNonQuery();

                    MessageBox.Show("Item checked out successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCheckoutMemberId.Clear();
                    txtCheckoutItemId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Find the transaction
                    string transQuery = "SELECT ItemType FROM transactions WHERE MemberId = @memberId AND ItemId = @itemId AND Status = 'Checked Out'";
                    MySqlCommand transCmd = new MySqlCommand(transQuery, conn);
                    transCmd.Parameters.AddWithValue("@memberId", txtCheckoutMemberId.Text);
                    transCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                    object result = transCmd.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("No checkout record found for this member and item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string itemType = result.ToString();

                    // Update item availability
                    string updateQuery = itemType == "Book"
                        ? "UPDATE books SET IsAvailable = 1 WHERE ItemId = @itemId"
                        : "UPDATE dvds SET IsAvailable = 1 WHERE ItemId = @itemId";

                    MySqlCommand updateCmd = new MySqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                    updateCmd.ExecuteNonQuery();

                    // Update transaction
                    string updateTransQuery = "UPDATE transactions SET ReturnDate = @returnDate, Status = 'Returned' WHERE MemberId = @memberId AND ItemId = @itemId AND Status = 'Checked Out'";
                    MySqlCommand updateTransCmd = new MySqlCommand(updateTransQuery, conn);
                    updateTransCmd.Parameters.AddWithValue("@returnDate", DateTime.Now);
                    updateTransCmd.Parameters.AddWithValue("@memberId", txtCheckoutMemberId.Text);
                    updateTransCmd.Parameters.AddWithValue("@itemId", txtCheckoutItemId.Text);
                    updateTransCmd.ExecuteNonQuery();

                    MessageBox.Show("Item returned successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCheckoutMemberId.Clear();
                    txtCheckoutItemId.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Get member details
                    string memberQuery = "SELECT Name, Fines FROM members WHERE MemberId = @memberId";
                    MySqlCommand memberCmd = new MySqlCommand(memberQuery, conn);
                    memberCmd.Parameters.AddWithValue("@memberId", txtViewMemberId.Text);
                    MySqlDataReader reader = memberCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        string info = $"Member ID: {txtViewMemberId.Text}\n";
                        info += $"Name: {reader["Name"]}\n";
                        info += $"Fines: ${reader["Fines"]}\n\n";
                        info += "Checked Out Items:\n";
                        reader.Close();

                        // Get checked out items
                        string itemsQuery = "SELECT ItemId, ItemType, CheckoutDate FROM transactions WHERE MemberId = @memberId AND Status = 'Checked Out'";
                        MySqlCommand itemsCmd = new MySqlCommand(itemsQuery, conn);
                        itemsCmd.Parameters.AddWithValue("@memberId", txtViewMemberId.Text);
                        MySqlDataReader itemsReader = itemsCmd.ExecuteReader();

                        while (itemsReader.Read())
                        {
                            info += $"- {itemsReader["ItemType"]}: {itemsReader["ItemId"]} (Checked out: {itemsReader["CheckoutDate"]})\n";
                        }
                        itemsReader.Close();

                        lblMemberInfo2.Text = info;
                    }
                    else
                    {
                        MessageBox.Show("Member not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadMembers_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    string query = "SELECT MemberId, Name, Fines FROM members";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Load(reader);

                    dgvMembers.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
