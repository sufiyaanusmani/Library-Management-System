using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LibraryManagementSystem
{
    public partial class AddBook : Form
    {
        string path = "Data Source=SUFIYAAN;Initial Catalog=books;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        public AddBook()
        {
            InitializeComponent();
            con = new SqlConnection(path);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtTitle.Text=="" || txtISBN.Text=="" || txtAuthor.Text=="" || txtPrice.Text == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                try
                {
                    string language;
                    if (rbtnChinese.Checked)
                    {
                        language = "Chinese";
                    }
                    else
                    {
                        language = "English";
                    }
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO BookInfo (Title, ISBN, Author, Price, Lang) VALUES ('" + txtTitle.Text + "', '" + txtISBN.Text + "', '" + txtAuthor.Text + "', " + txtPrice.Text + ", '" + language + "')", con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Book added successfully");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void clear()
        {
            txtTitle.Text = "";
            txtISBN.Text = "";
            txtAuthor.Text = "";
            txtPrice.Text = "";
            rbtnChinese.Checked = false;
            rbtnEng.Checked = false;
        }
        private void AddBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }
    }
}
