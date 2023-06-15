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
using System.IO;

namespace Library_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void book_btn_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void pub_btn_Click(object sender, EventArgs e)
        {
            Publishers publishers = new Publishers();
            publishers.Show();
            this.Hide();
        }

        private void mem_btn_Click(object sender, EventArgs e)
        {
            Members members = new Members();
            members.Show();
            this.Hide();
        }

        private void Nmem_btn_Click(object sender, EventArgs e)
        {
            Non_Members non_Members= new Non_Members();
            non_Members.Show();
            this.Hide();
        }

        private void issue_btn_Click(object sender, EventArgs e)
        {
            Issue issue = new Issue();
            issue.Show();
            this.Hide();
        }

        private void pur_btn_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.Show();
            this.Hide();
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            Rent rent = new Rent();
            rent.Show();
            this.Hide();
        }

        private void staff_btn_Click(object sender, EventArgs e)
        {
            Staff staff = new Staff();
            staff.Show();
            this.Hide();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
