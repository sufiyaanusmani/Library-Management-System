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
    public partial class UpdateBooks : Form
    {
        string path = "Data Source=SUFIYAAN;Initial Catalog=books;Integrated Security=True";
        SqlConnection con;
        SqlCommand cmd;
        SqlDataAdapter adpt;
        DataTable dt;
        int ID;
        public UpdateBooks()
        {
            InitializeComponent();
            con = new SqlConnection(path);
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string lang;
                if (rbtnChinese.Checked)
                {
                    lang = "Chinese";
                }
                else
                {
                    lang = "English";
                }
                con.Open();
                cmd = new SqlCommand("update BookInfo set Title='" + txtTitle.Text + "', ISBN='" + txtISBN.Text + "', Author='" + txtAuthor.Text + "', Price='" + txtPrice.Text + "', Lang='" + lang + "' where BookID='" + ID + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data updated successfully");
                display();
                clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void display()
        {
            try
            {
                dt = new DataTable();
                con.Open();
                adpt = new SqlDataAdapter("SELECT * FROM BookInfo", con);
                adpt.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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

        private void UpdateBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
            this.Parent = null;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ID = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtTitle.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtISBN.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAuthor.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

            rbtnEng.Checked = true;
            rbtnChinese.Checked = false;
            if(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString() == "Chinese")
            {
                rbtnEng.Checked = false;
                rbtnChinese.Checked = true;
            }


        }
    }
}
