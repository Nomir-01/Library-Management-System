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
    public partial class Purchase : Form
    {
        public Purchase()
        {
            InitializeComponent();
        }

        private void Purchase_Load(object sender, EventArgs e)
        {
            gridviewstyle();
        }
        private void clear()
        {
            id_box.Clear();
            id2_box.Clear();
            date_box.Clear();
            price_box.Clear();
            qty_box.Clear();
            Tpri_box.Clear();
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

        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_box.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            id2_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            date_box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            price_box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            qty_box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            Tpri_box.Text = Convert.ToString(int.Parse(price_box.Text) * int.Parse(qty_box.Text));
        }
        private void display_all()
        {
            string query = string.Format("select * from Purchase_Card");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void cal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Tpri_box.Text = Convert.ToString(int.Parse(price_box.Text) * int.Parse(qty_box.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ins_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into Purchase_Card values({0},{1},'{2}',{3},{4})", int.Parse(id_box.Text), int.Parse(id2_box.Text), date_box.Text, int.Parse(price_box.Text), int.Parse(qty_box.Text));
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
                string query = string.Format("update Purchase_Card set MPrice=@p,MQuantity=@qty where ISBN=@id and MemberID=@memid and MPurchaseDate=@pd");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@memid", id2_box.Text);
                cmd.Parameters.AddWithValue("@pd", date_box.Text);
                cmd.Parameters.AddWithValue("@p", price_box.Text);
                cmd.Parameters.AddWithValue("@qty", qty_box.Text);
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
                string query = string.Format("delete from Purchase_Card where ISBN=@id and MemberID=@memid and MPurchaseDate=@pd");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@memid", id2_box.Text);
                cmd.Parameters.AddWithValue("@pd", date_box.Text);
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
                    string query = string.Format("select * from Purchase_Card where ISBN={0}", int.Parse(search_box.Text));
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
                    string query = string.Format("select * from Purchase_Card where MemberID={0}", int.Parse(search_box2.Text));
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
                    string query = string.Format("select * from Purchase_Card where ISBN={0} and MemberID={1}", int.Parse(search_box.Text), int.Parse(search_box2.Text));
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

        private void history_Click(object sender, EventArgs e)
        {
            Purchase_History purchase_History = new Purchase_History();
            purchase_History.Show();
            this.Hide();
        }
    }
}
