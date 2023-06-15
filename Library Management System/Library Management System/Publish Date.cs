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
    public partial class Publish_Date : Form
    {
        public Publish_Date()
        {
            InitializeComponent();
        }

        private void Publish_Date_Load(object sender, EventArgs e)
        {
            gridviewstyle();
        }
        private void clear()
        {
            id_box.Clear();
            id2_box.Clear();
            day_box.Clear();
            month_box.Clear();
            year_box.Clear();
            search_box.Clear();
            search_box2.Clear();
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
            string query = string.Format("select * from Publish_Date");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_box.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id2_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            day_box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            month_box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            year_box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into Publish_Date values({0},{1},{2},{3},{4})", int.Parse(id_box.Text), int.Parse(id2_box.Text), int.Parse(day_box.Text), int.Parse(month_box.Text), int.Parse(year_box.Text));
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
                string query1 = string.Format("update Publish_Date set PubDay=@p1,PubMonth=@p2,PubYear=@p3 where ISBN=@id and PublisherID=@pid");
                SqlCommand cmd = new SqlCommand(query1, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@pid", id2_box.Text);
                cmd.Parameters.AddWithValue("@p1", day_box.Text);
                cmd.Parameters.AddWithValue("@p2", month_box.Text);
                cmd.Parameters.AddWithValue("@p3", year_box.Text);
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
                string query = string.Format("delete from Publish_Date where ISBN=@id and PublisherID=@pid");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@pid", id2_box.Text);
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
            if (search_box.TextLength != 0 && string.IsNullOrWhiteSpace(search_box2.Text))
            {
                try
                {
                    string query = string.Format("select * from Publish_Date where ISBN={0}", int.Parse(search_box.Text));
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
                    string query = string.Format("select * from Publish_Date where PublisherID={0}", int.Parse(search_box2.Text));
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
                    string query = string.Format("select * from Publish_Date where ISBN={0} and PublisherID={1}", int.Parse(search_box.Text), int.Parse(search_box2.Text));
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

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Publishers publishers = new Publishers();
            publishers.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
