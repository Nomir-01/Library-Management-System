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
    public partial class Rent : Form
    {
        public Rent()
        {
            InitializeComponent();
        }

        private void Rent_Load(object sender, EventArgs e)
        {
            gridviewstyle();
            latefee_box.Text = Convert.ToString(40);
        }
        private void clear()
        {
            id_box.Clear();
            id2_box.Clear();
            rentdate_box.Clear();
            returndate_box.Clear();
            days_box.Clear();
            latefee_box.Clear();
            Tlatefee_box.Clear();
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
            string query = string.Format("select * from Rent");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_box.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id2_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            rentdate_box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            returndate_box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            latefee_box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            days_box.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            status_box.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Tlatefee_box.Text = Convert.ToString(int.Parse(latefee_box.Text) * int.Parse(days_box.Text));
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("count_proc_NonMembers '" + id2_box.Text + "'", Connection.GetCon());
                SqlDataReader sdr = sqlCommand.ExecuteReader();
                int a = 0;
                while (sdr.Read())
                {
                    a = int.Parse(sdr["returnsofbooks"].ToString());
                }
                sdr.Close();
                Connection.con.Close();
                if (a >= 1)
                {
                    MessageBox.Show("Cannot Issue More Books.\nReturn Previous Books First", "Status", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    try
                    {
                        string query = string.Format("insert into Rent values({0},'{1}','{2}','{3}',{4},{5},'{6}')", int.Parse(id_box.Text), id2_box.Text, rentdate_box.Text, returndate_box.Text, int.Parse(latefee_box.Text), int.Parse(days_box.Text), status_box.Text);
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
                string query1 = string.Format("update Rent set NMReturnDate=@d2,NMLateFeePerDay=@lf,NMLateDays=@ld,NMStatus=@ns where ISBN=@id and NMCNIC=@cnic and NMRentDate=@rd2");
                SqlCommand cmd = new SqlCommand(query1, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@cnic", id2_box.Text);
                cmd.Parameters.AddWithValue("@rd1", rentdate_box.Text);
                cmd.Parameters.AddWithValue("@d2", returndate_box.Text);
                cmd.Parameters.AddWithValue("@lf", latefee_box.Text);
                cmd.Parameters.AddWithValue("@ld", days_box.Text);
                cmd.Parameters.AddWithValue("@ns", status_box.Text);
                cmd.Parameters.AddWithValue("@rd2", rentdate_box.Text);
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
                string query = string.Format("delete from Rent where ISBN=@id and NMCNIC=@cnic and NMRentDate=@date");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@cnic", id2_box.Text);
                cmd.Parameters.AddWithValue("@date", rentdate_box.Text);
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
                    string query = string.Format("select * from Rent where ISBN={0}", int.Parse(search_box.Text));
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
                    string query = string.Format("select * from Rent where NMCNIC={0}", search_box2.Text);
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
                    string query = string.Format("select * from Rent where ISBN={0} and NMCNIC={1}", int.Parse(search_box.Text), search_box2.Text);
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
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Tlatefee_box.Text = Convert.ToString(int.Parse(latefee_box.Text) * int.Parse(days_box.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void history_Click(object sender, EventArgs e)
        {
            Rent_History rent_History = new Rent_History();
            rent_History.Show();
            this.Hide();
        }
    }
}
