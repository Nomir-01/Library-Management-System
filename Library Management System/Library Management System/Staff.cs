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
    public partial class Staff : Form
    {
        public Staff()
        {
            InitializeComponent();
        }

        private void Staff_Load(object sender, EventArgs e)
        {
            gridviewstyle();
        }
        private void clear()
        {
            id_box.Clear();
            name_box.Clear();
            con_box.Clear();
            add_box.Clear();
            sal_box.Clear();
            search_box.Clear();
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
            string query = string.Format("select * from Staff");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_box.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            con_box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            add_box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            sal_box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into Staff values({0},'{1}','{2}','{3}',{4})", int.Parse(id_box.Text), name_box.Text, con_box.Text, add_box.Text, int.Parse(sal_box.Text));
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
                string query1 = string.Format("update Staff set SName=@name,SContact=@con,SAddress=@add,Salary=@sal where StaffID=@id");
                SqlCommand cmd = new SqlCommand(query1, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@name", name_box.Text);
                cmd.Parameters.AddWithValue("@con", con_box.Text);
                cmd.Parameters.AddWithValue("@add", add_box.Text);
                cmd.Parameters.AddWithValue("@sal", sal_box.Text);
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
                string query = string.Format("delete from Staff where StaffID=@id");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
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
            try
            {
                string query = string.Format("select * from Staff where SName like '%{0}%'", search_box.Text);
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Maintenance maintenance = new Maintenance();
            maintenance.Show();
            this.Hide();
        }
    }
}
