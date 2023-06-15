
namespace Library_Management_System
{
    partial class Issue
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
            this.ins_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdate_box = new System.Windows.Forms.TextBox();
            this.Tlatefee_box = new System.Windows.Forms.TextBox();
            this.latefee_box = new System.Windows.Forms.TextBox();
            this.idate_box = new System.Windows.Forms.TextBox();
            this.id2_box = new System.Windows.Forms.TextBox();
            this.upd_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.disp_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
            this.back_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.search_box = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.days_box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.search_box2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cal_btn = new System.Windows.Forms.Button();
            this.history = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.status_box = new System.Windows.Forms.ComboBox();
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
            this.id_box.Location = new System.Drawing.Point(192, 41);
            this.id_box.Name = "id_box";
            this.id_box.PlaceholderText = "1";
            this.id_box.Size = new System.Drawing.Size(147, 29);
            this.id_box.TabIndex = 1;
            // 
            // ins_btn
            // 
            this.ins_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(128)))), ((int)(((byte)(69)))));
            this.ins_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ins_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ins_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ins_btn.Location = new System.Drawing.Point(814, 43);
            this.ins_btn.Name = "ins_btn";
            this.ins_btn.Size = new System.Drawing.Size(116, 50);
            this.ins_btn.TabIndex = 2;
            this.ins_btn.Text = "Insert";
            this.ins_btn.UseVisualStyleBackColor = false;
            this.ins_btn.Click += new System.EventHandler(this.ins_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "ISBN :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(345, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Late Fee Per Day :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Return Date :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(12, 144);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Issue Date :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 22);
            this.label6.TabIndex = 7;
            this.label6.Text = "Member ID :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(345, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(174, 22);
            this.label7.TabIndex = 8;
            this.label7.Text = "Total Late Fee :";
            // 
            // rdate_box
            // 
            this.rdate_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rdate_box.Location = new System.Drawing.Point(555, 39);
            this.rdate_box.Name = "rdate_box";
            this.rdate_box.PlaceholderText = "2002-09-25";
            this.rdate_box.Size = new System.Drawing.Size(147, 29);
            this.rdate_box.TabIndex = 9;
            // 
            // Tlatefee_box
            // 
            this.Tlatefee_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Tlatefee_box.Location = new System.Drawing.Point(555, 188);
            this.Tlatefee_box.Name = "Tlatefee_box";
            this.Tlatefee_box.ReadOnly = true;
            this.Tlatefee_box.Size = new System.Drawing.Size(147, 29);
            this.Tlatefee_box.TabIndex = 10;
            // 
            // latefee_box
            // 
            this.latefee_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.latefee_box.Location = new System.Drawing.Point(555, 142);
            this.latefee_box.Name = "latefee_box";
            this.latefee_box.ReadOnly = true;
            this.latefee_box.Size = new System.Drawing.Size(147, 29);
            this.latefee_box.TabIndex = 11;
            // 
            // idate_box
            // 
            this.idate_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idate_box.Location = new System.Drawing.Point(192, 142);
            this.idate_box.Name = "idate_box";
            this.idate_box.PlaceholderText = "2002-08-25";
            this.idate_box.Size = new System.Drawing.Size(147, 29);
            this.idate_box.TabIndex = 12;
            // 
            // id2_box
            // 
            this.id2_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id2_box.Location = new System.Drawing.Point(192, 95);
            this.id2_box.Name = "id2_box";
            this.id2_box.PlaceholderText = "1";
            this.id2_box.Size = new System.Drawing.Size(147, 29);
            this.id2_box.TabIndex = 13;
            // 
            // upd_btn
            // 
            this.upd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.upd_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upd_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upd_btn.Location = new System.Drawing.Point(814, 99);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(116, 50);
            this.upd_btn.TabIndex = 14;
            this.upd_btn.Text = "Update";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(555, 258);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(119, 35);
            this.search_btn.TabIndex = 15;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // disp_btn
            // 
            this.disp_btn.BackColor = System.Drawing.Color.White;
            this.disp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.disp_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disp_btn.Location = new System.Drawing.Point(814, 211);
            this.disp_btn.Name = "disp_btn";
            this.disp_btn.Size = new System.Drawing.Size(116, 50);
            this.disp_btn.TabIndex = 16;
            this.disp_btn.Text = "Display All";
            this.disp_btn.UseVisualStyleBackColor = false;
            this.disp_btn.Click += new System.EventHandler(this.disp_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.Location = new System.Drawing.Point(839, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 28);
            this.exit_btn.TabIndex = 17;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_btn.Location = new System.Drawing.Point(12, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(91, 28);
            this.back_btn.TabIndex = 18;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del_btn.Location = new System.Drawing.Point(814, 155);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(116, 50);
            this.del_btn.TabIndex = 19;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.button7_Click);
            // 
            // search_box
            // 
            this.search_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_box.Location = new System.Drawing.Point(97, 263);
            this.search_box.Name = "search_box";
            this.search_box.Size = new System.Drawing.Size(147, 29);
            this.search_box.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 299);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 318);
            this.groupBox1.TabIndex = 21;
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
            this.dataGridView1.Size = new System.Drawing.Size(906, 290);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // days_box
            // 
            this.days_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.days_box.Location = new System.Drawing.Point(555, 93);
            this.days_box.Name = "days_box";
            this.days_box.PlaceholderText = "5";
            this.days_box.Size = new System.Drawing.Size(147, 29);
            this.days_box.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(345, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(129, 22);
            this.label8.TabIndex = 22;
            this.label8.Text = "Late Days :";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // search_box2
            // 
            this.search_box2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_box2.Location = new System.Drawing.Point(402, 263);
            this.search_box2.Name = "search_box2";
            this.search_box2.Size = new System.Drawing.Size(147, 29);
            this.search_box2.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(253, 265);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 24;
            this.label9.Text = "Member ID :";
            // 
            // cal_btn
            // 
            this.cal_btn.BackColor = System.Drawing.Color.White;
            this.cal_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cal_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cal_btn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cal_btn.ForeColor = System.Drawing.Color.Black;
            this.cal_btn.Location = new System.Drawing.Point(708, 192);
            this.cal_btn.Name = "cal_btn";
            this.cal_btn.Size = new System.Drawing.Size(22, 23);
            this.cal_btn.TabIndex = 26;
            this.cal_btn.Text = "i";
            this.cal_btn.UseVisualStyleBackColor = false;
            this.cal_btn.Click += new System.EventHandler(this.cal_btn_Click);
            // 
            // history
            // 
            this.history.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.history.Cursor = System.Windows.Forms.Cursors.Hand;
            this.history.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.history.ForeColor = System.Drawing.Color.White;
            this.history.Location = new System.Drawing.Point(685, 242);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(116, 50);
            this.history.TabIndex = 27;
            this.history.Text = "History";
            this.history.UseVisualStyleBackColor = false;
            this.history.Click += new System.EventHandler(this.history_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(12, 190);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 22);
            this.label10.TabIndex = 28;
            this.label10.Text = "Status :";
            // 
            // status_box
            // 
            this.status_box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.status_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] {
            "Returned",
            "Not Returned"});
            this.status_box.Location = new System.Drawing.Point(192, 188);
            this.status_box.MaxDropDownItems = 2;
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(147, 29);
            this.status_box.TabIndex = 29;
            // 
            // Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(942, 629);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.history);
            this.Controls.Add(this.cal_btn);
            this.Controls.Add(this.search_box2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.days_box);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.search_box);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.disp_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.id2_box);
            this.Controls.Add(this.idate_box);
            this.Controls.Add(this.latefee_box);
            this.Controls.Add(this.Tlatefee_box);
            this.Controls.Add(this.rdate_box);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ins_btn);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue";
            this.Load += new System.EventHandler(this.Issue_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Button ins_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox rdate_box;
        private System.Windows.Forms.TextBox Tlatefee_box;
        private System.Windows.Forms.TextBox latefee_box;
        private System.Windows.Forms.TextBox idate_box;
        private System.Windows.Forms.TextBox id2_box;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button disp_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.TextBox search_box;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox days_box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox search_box2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button cal_btn;
        private System.Windows.Forms.Button history;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox status_box;
    }
}