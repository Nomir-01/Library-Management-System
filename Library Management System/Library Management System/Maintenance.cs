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
    public partial class Maintenance : Form
    {
        public Maintenance()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Staff staff = new Staff();
            staff.Show();
        }

        private void Maintenance_Load(object sender, EventArgs e)
        {
            gridviewstyle();
        }
        private void clear()
        {
            id_box.Clear();
            id_box2.Clear();
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
            string query = string.Format("select * from Maintenance");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into Maintenance values({0},{1})", int.Parse(id_box.Text), int.Parse(id_box2.Text));
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("Record Added Successfully.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display_all();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query1 = string.Format("update Maintenance set ISBN=@id1,StaffID=@id2 where ISBN=@id1 and StaffID=@id2");
                SqlCommand cmd = new SqlCommand(query1, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id1", id_box.Text);
                cmd.Parameters.AddWithValue("@id2", id_box2.Text);
                cmd.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("Record Updated Successfully.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display_all();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("delete from Maintenance where ISBN=@id1 and StaffID=@id2");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id1", id_box.Text);
                cmd.Parameters.AddWithValue("@id2", id_box2.Text);
                cmd.ExecuteNonQuery();
                Connection.con.Close();
                MessageBox.Show("Record Deleted Successfully.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                display_all();
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void disp_btn_Click(object sender, EventArgs e)
        {
            display_all();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            if (id_box.TextLength != 0 && string.IsNullOrWhiteSpace(id_box2.Text))
            {
                try
                {
                    string query = string.Format("select * from Maintenance where ISBN={0}", int.Parse(id_box.Text));
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
            else if (string.IsNullOrWhiteSpace(id_box.Text) && id_box2.TextLength != 0)
            {
                try
                {
                    string query = string.Format("select * from Maintenance where StaffID={0}", int.Parse(id_box2.Text));
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
            else if (id_box.TextLength != 0 && id_box2.TextLength != 0)
            {
                try
                {
                    string query = string.Format("select * from Maintenance where ISBN={0} and StaffID={1}", int.Parse(id_box.Text), int.Parse(id_box2.Text));
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

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_box.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id_box2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
    }
}
