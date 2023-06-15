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
    public partial class Books : Form
    {
        public Books()
        {
            InitializeComponent();
        }

        private void Books_Load(object sender, EventArgs e)
        {
            gridviewstyle();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("insert into Books values({0},'{1}','{2}','{3}',{4},{5},{6})",int.Parse(id_box.Text),name_box.Text,gen_box.Text,ed_box.Text,int.Parse(pri_box.Text),int.Parse(qty_box.Text),int.Parse(fk_id_box.Text));
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
        private void clear()
        {
            id_box.Clear();
            name_box.Clear();
            ed_box.Clear();
            pri_box.Clear();
            qty_box.Clear();
            gen_box.Clear();
            fk_id_box.Clear();
            Tpri_box.Clear();
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
        private void dataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            id_box.Text= dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            name_box.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            gen_box.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            ed_box.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            pri_box.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            qty_box.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            fk_id_box.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            Tpri_box.Text = Convert.ToString(int.Parse(qty_box.Text) * int.Parse(pri_box.Text));
        }
        private void display_all()
        {
            string query = string.Format("select * from Books");
            SqlDataAdapter da = new SqlDataAdapter(query, Connection.GetCon());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            Connection.con.Close();
        }

        private void disp_btn_Click(object sender, EventArgs e)
        {
            display_all();
        }

        private void upd_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("update Books set BName=@name,BGenre=@gen,BEdition=@ed,BPrice=@pri,BQuantity=@qty,PublisherID=@pid where ISBN=@id");
                SqlCommand cmd = new SqlCommand(query, Connection.GetCon());
                cmd.Parameters.AddWithValue("@id", id_box.Text);
                cmd.Parameters.AddWithValue("@name", name_box.Text);
                cmd.Parameters.AddWithValue("@gen", gen_box.Text);
                cmd.Parameters.AddWithValue("@ed", ed_box.Text);
                cmd.Parameters.AddWithValue("@pri", pri_box.Text);
                cmd.Parameters.AddWithValue("@qty", qty_box.Text);
                cmd.Parameters.AddWithValue("@pid", fk_id_box.Text);
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
                string query = string.Format("delete from Books where ISBN=@id");
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

        private void search_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string query = string.Format("select * from Books where BName like '%{0}%'", search_box.Text);
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

        private void cal_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Tpri_box.Text = Convert.ToString(int.Parse(qty_box.Text) * int.Parse(pri_box.Text));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void book_catalog_btn_Click(object sender, EventArgs e)
        {
            Catalog catalog = new Catalog();
            catalog.Show();
            this.Hide();
        }
    }
}
