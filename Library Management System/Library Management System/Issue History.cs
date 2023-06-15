using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Library_Management_System
{
    public partial class Issue_History : Form
    {
        public Issue_History()
        {
            InitializeComponent();
        }

        private void Issue_History_Load(object sender, EventArgs e)
        {
            gridviewstyle();
        }
        private void gridviewstyle()
        {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.SeaGreen;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;
            dataGridView1.BackgroundColor = Color.FromArgb(25, 35, 35);
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 14);
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(25, 35, 35);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);

        }
        private void display_all()
        {
            string query = string.Format("select * from IssueHistory");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Issue issue = new Issue();
            issue.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void disp_btn_Click(object sender, EventArgs e)
        {
            display_all();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (search_box.TextLength != 0 && string.IsNullOrWhiteSpace(search_box2.Text))
            {
                try
                {
                    string query = string.Format("select * from IssueHistory where ISBN={0}", int.Parse(search_box.Text));
                    SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Connection.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (string.IsNullOrWhiteSpace(search_box.Text) && search_box2.TextLength != 0)
            {
                try
                {
                    string query = string.Format("select * from IssueHistory where Member_ID={0}", int.Parse(search_box2.Text));
                    SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Connection.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (search_box.TextLength != 0 && search_box2.TextLength != 0)
            {
                try
                {
                    string query = string.Format("select * from IssueHistory where ISBN={0} and Member_ID={1}", int.Parse(search_box.Text), int.Parse(search_box2.Text));
                    SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    dataGridView1.DataSource = dt;
                    Connection.con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No Entries.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
