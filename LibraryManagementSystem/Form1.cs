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
        AddBook addBook = new AddBook();
        ViewBooks viewBooks = new ViewBooks();
        UpdateBooks updateBooks = new UpdateBooks();
        DeleteBook deleteBook = new DeleteBook();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addBook.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            viewBooks.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            updateBooks.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteBook.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
