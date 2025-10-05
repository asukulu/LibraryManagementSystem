using LibraryManagementSystem.Models;
using MySql.Data.MySqlClient;
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
    public partial class ManageItemsForm : Form
    {
        public ManageItemsForm()
        {
            InitializeComponent();
        }

        private void mi_Load(object sender, EventArgs e)
        {

        }



        private void btnAddDVD_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO dvds (ItemId, Title, Director, Duration, Rating, IsAvailable, LateFee) VALUES (@itemId, @title, @director, @duration, @rating, 1, 1.00)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemId", txtDVDItemId.Text);
                    cmd.Parameters.AddWithValue("@title", txtDVDTitle.Text);
                    cmd.Parameters.AddWithValue("@director", txtDVDDirector.Text);
                    cmd.Parameters.AddWithValue("@duration", int.Parse(txtDVDDuration.Text));
                    cmd.Parameters.AddWithValue("@rating", txtDVDRating.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("DVD added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear textboxes
                    txtDVDItemId.Clear();
                    txtDVDTitle.Clear();
                    txtDVDDirector.Clear();
                    txtDVDDuration.Clear();
                    txtDVDRating.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadItems_Click(object sender, EventArgs e)
        {
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();

                    // Create a DataTable to hold combined results
                    System.Data.DataTable dt = new System.Data.DataTable();
                    dt.Columns.Add("Type");
                    dt.Columns.Add("ItemId");
                    dt.Columns.Add("Title");
                    dt.Columns.Add("Details");
                    dt.Columns.Add("Available");

                    // Load books
                    string bookQuery = "SELECT ItemId, Title, Author, ISBN, Pages, IsAvailable FROM books";
                    MySqlCommand bookCmd = new MySqlCommand(bookQuery, conn);
                    MySqlDataReader bookReader = bookCmd.ExecuteReader();

                    while (bookReader.Read())
                    {
                        dt.Rows.Add(
                            "Book",
                            bookReader["ItemId"],
                            bookReader["Title"],
                            $"Author: {bookReader["Author"]}, ISBN: {bookReader["ISBN"]}, Pages: {bookReader["Pages"]}",
                            Convert.ToBoolean(bookReader["IsAvailable"]) ? "Yes" : "No"
                        );
                    }
                    bookReader.Close();

                    // Load DVDs
                    string dvdQuery = "SELECT ItemId, Title, Director, Duration, Rating, IsAvailable FROM dvds";
                    MySqlCommand dvdCmd = new MySqlCommand(dvdQuery, conn);
                    MySqlDataReader dvdReader = dvdCmd.ExecuteReader();

                    while (dvdReader.Read())
                    {
                        dt.Rows.Add(
                            "DVD",
                            dvdReader["ItemId"],
                            dvdReader["Title"],
                            $"Director: {dvdReader["Director"]}, Duration: {dvdReader["Duration"]} mins, Rating: {dvdReader["Rating"]}",
                            Convert.ToBoolean(dvdReader["IsAvailable"]) ? "Yes" : "No"
                        );
                    }
                    dvdReader.Close();

                    dgvItems.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Hover effects for buttons

        private void btnAddBook_MouseEnter(object sender, EventArgs e)
        {
            btnAddBook.BackColor = Color.FromArgb(5, 150, 105);
        }

        private void btnAddBook_MouseLeave(object sender, EventArgs e)
        {
            btnAddBook.BackColor = Color.FromArgb(16, 185, 129);
        }

        private void btnAddDVD_MouseEnter(object sender, EventArgs e)
        {
            btnAddDVD.BackColor = Color.FromArgb(234, 88, 12);
        }

        private void btnAddDVD_MouseLeave(object sender, EventArgs e)
        {
            btnAddDVD.BackColor = Color.FromArgb(251, 146, 60);
        }

        private void btnLoadItems_MouseEnter(object sender, EventArgs e)
        {
            btnLoadItems.BackColor = Color.FromArgb(79, 70, 229);
        }

        private void btnLoadItems_MouseLeave(object sender, EventArgs e)
        {
            btnLoadItems.BackColor = Color.FromArgb(99, 102, 241);
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(220, 38, 38);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(239, 68, 68);
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
       
            try
            {
                DatabaseHelper dbHelper = new DatabaseHelper();
                using (MySqlConnection conn = dbHelper.GetConnection())
                {
                    conn.Open();
                    string query = "INSERT INTO books (ItemId, Title, Author, ISBN, Pages, IsAvailable, LateFee) VALUES (@itemId, @title, @author, @isbn, @pages, 1, 0.50)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@itemId", txtBookItemId.Text);
                    cmd.Parameters.AddWithValue("@title", txtBookTitle.Text);
                    cmd.Parameters.AddWithValue("@author", txtBookAuthor.Text);
                    cmd.Parameters.AddWithValue("@isbn", txtBookISBN.Text);
                    cmd.Parameters.AddWithValue("@pages", int.Parse(txtBookPages.Text));

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear textboxes
                    txtBookItemId.Clear();
                    txtBookTitle.Clear();
                    txtBookAuthor.Clear();
                    txtBookISBN.Clear();
                    txtBookPages.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }
