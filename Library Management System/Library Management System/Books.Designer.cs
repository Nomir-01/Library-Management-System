
namespace Library_Management_System
{
    partial class Books
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.id_box = new System.Windows.Forms.TextBox();
            this.search_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.qty_box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pri_box = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ed_box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gen_box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.name_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.insert_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.upd_btn = new System.Windows.Forms.Button();
            this.disp_btn = new System.Windows.Forms.Button();
            this.Tpri_box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.back_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.fk_id_box = new System.Windows.Forms.TextBox();
            this.book_catalog_btn = new System.Windows.Forms.Button();
            this.cal_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "ISBN :";
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_box.Location = new System.Drawing.Point(174, 41);
            this.id_box.Name = "id_box";
            this.id_box.PlaceholderText = "1";
            this.id_box.Size = new System.Drawing.Size(147, 29);
            this.id_box.TabIndex = 1;
            this.id_box.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_box.Location = new System.Drawing.Point(97, 244);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(147, 29);
            this.search_box.TabIndex = 3;
            this.search_box.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Publisher ID :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qty_box
            // 
            this.qty_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.qty_box.Location = new System.Drawing.Point(466, 147);
            this.qty_box.Name = "qty_box";
            this.qty_box.PlaceholderText = "5";
            this.qty_box.Size = new System.Drawing.Size(147, 29);
            this.qty_box.TabIndex = 7;
            this.qty_box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(336, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantity :";
            // 
            // pri_box
            // 
            this.pri_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pri_box.Location = new System.Drawing.Point(466, 95);
            this.pri_box.Name = "pri_box";
            this.pri_box.PlaceholderText = "2500";
            this.pri_box.Size = new System.Drawing.Size(147, 29);
            this.pri_box.TabIndex = 9;
            this.pri_box.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(336, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price :";
            // 
            // ed_box
            // 
            this.ed_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ed_box.Location = new System.Drawing.Point(466, 41);
            this.ed_box.Name = "ed_box";
            this.ed_box.PlaceholderText = "1st";
            this.ed_box.Size = new System.Drawing.Size(147, 29);
            this.ed_box.TabIndex = 11;
            this.ed_box.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(336, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Edition :";
            // 
            // gen_box
            // 
            this.gen_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.gen_box.Location = new System.Drawing.Point(766, 41);
            this.gen_box.Name = "gen_box";
            this.gen_box.PlaceholderText = "Fiction";
            this.gen_box.Size = new System.Drawing.Size(147, 29);
            this.gen_box.TabIndex = 13;
            this.gen_box.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(628, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "Genre :";
            // 
            // name_box
            // 
            this.name_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_box.Location = new System.Drawing.Point(174, 95);
            this.name_box.Name = "name_box";
            this.name_box.PlaceholderText = "Lliad";
            this.name_box.Size = new System.Drawing.Size(147, 29);
            this.name_box.TabIndex = 15;
            this.name_box.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Name :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 334);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(906, 306);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // insert_btn
            // 
            this.insert_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(128)))), ((int)(((byte)(69)))));
            this.insert_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.insert_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.insert_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.insert_btn.Location = new System.Drawing.Point(692, 156);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(116, 50);
            this.insert_btn.TabIndex = 18;
            this.insert_btn.Text = "Insert";
            this.insert_btn.UseVisualStyleBackColor = false;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(281, 242);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(119, 35);
            this.search_btn.TabIndex = 19;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del_btn.Location = new System.Drawing.Point(692, 212);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(116, 50);
            this.del_btn.TabIndex = 20;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // upd_btn
            // 
            this.upd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.upd_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upd_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upd_btn.Location = new System.Drawing.Point(814, 156);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(116, 50);
            this.upd_btn.TabIndex = 21;
            this.upd_btn.Text = "Update";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // disp_btn
            // 
            this.disp_btn.BackColor = System.Drawing.Color.White;
            this.disp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.disp_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disp_btn.Location = new System.Drawing.Point(814, 212);
            this.disp_btn.Name = "disp_btn";
            this.disp_btn.Size = new System.Drawing.Size(116, 50);
            this.disp_btn.TabIndex = 22;
            this.disp_btn.Text = "Display All";
            this.disp_btn.UseVisualStyleBackColor = false;
            this.disp_btn.Click += new System.EventHandler(this.disp_btn_Click);
            // 
            // Tpri_box
            // 
            this.Tpri_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tpri_box.Location = new System.Drawing.Point(766, 95);
            this.Tpri_box.Name = "Tpri_box";
            this.Tpri_box.ReadOnly = true;
            this.Tpri_box.Size = new System.Drawing.Size(147, 29);
            this.Tpri_box.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(628, 97);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(138, 22);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total Price :";
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_btn.Location = new System.Drawing.Point(12, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(91, 28);
            this.back_btn.TabIndex = 25;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.Location = new System.Drawing.Point(839, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 28);
            this.exit_btn.TabIndex = 26;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // fk_id_box
            // 
            this.fk_id_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fk_id_box.Location = new System.Drawing.Point(174, 147);
            this.fk_id_box.Name = "fk_id_box";
            this.fk_id_box.PlaceholderText = "1";
            this.fk_id_box.Size = new System.Drawing.Size(147, 29);
            this.fk_id_box.TabIndex = 27;
            // 
            // book_catalog_btn
            // 
            this.book_catalog_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.book_catalog_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_catalog_btn.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_catalog_btn.ForeColor = System.Drawing.Color.White;
            this.book_catalog_btn.Location = new System.Drawing.Point(519, 227);
            this.book_catalog_btn.Name = "book_catalog_btn";
            this.book_catalog_btn.Size = new System.Drawing.Size(167, 50);
            this.book_catalog_btn.TabIndex = 28;
            this.book_catalog_btn.Text = "Catalog";
            this.book_catalog_btn.UseVisualStyleBackColor = false;
            this.book_catalog_btn.Click += new System.EventHandler(this.book_catalog_btn_Click);
            // 
            // cal_btn
            // 
            this.cal_btn.BackColor = System.Drawing.Color.White;
            this.cal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cal_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cal_btn.ForeColor = System.Drawing.Color.Black;
            this.cal_btn.Location = new System.Drawing.Point(916, 97);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(22, 23);
            this.cal_btn.TabIndex = 29;
            this.cal_btn.Text = "i";
            this.cal_btn.UseVisualStyleBackColor = false;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(942, 629);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.book_catalog_btn);
            this.Controls.Add(this.fk_id_box);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.Tpri_box);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.disp_btn);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.insert_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.name_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.gen_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ed_box);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pri_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.qty_box);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Books";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Books_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox qty_box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox pri_box;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ed_box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox gen_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button disp_btn;
        private System.Windows.Forms.TextBox Tpri_box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.TextBox fk_id_box;
        private System.Windows.Forms.Button book_catalog_btn;
        private System.Windows.Forms.Button cal_btn;
    }
}