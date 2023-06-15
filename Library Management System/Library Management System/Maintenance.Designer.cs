
namespace Library_Management_System
{
    partial class Maintenance
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
            this.back_btn = new System.Windows.Forms.Button();
            this.id_box = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.id_box2 = new System.Windows.Forms.TextBox();
            this.exit_btn = new System.Windows.Forms.Button();
            this.disp_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.ins_btn = new System.Windows.Forms.Button();
            this.upd_btn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            // back_btn
            // 
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.back_btn.Location = new System.Drawing.Point(12, 5);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(91, 28);
            this.back_btn.TabIndex = 1;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            this.back_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // id_box
            // 
            this.id_box.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_box.Location = new System.Drawing.Point(123, 41);
            this.id_box.Name = "id_box";
            this.id_box.PlaceholderText = "1";
            this.id_box.Size = new System.Drawing.Size(147, 29);
            this.id_box.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Staff ID :";
            // 
            // id_box2
            // 
            this.id_box2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.id_box2.Location = new System.Drawing.Point(123, 95);
            this.id_box2.Name = "id_box2";
            this.id_box2.PlaceholderText = "1";
            this.id_box2.Size = new System.Drawing.Size(147, 29);
            this.id_box2.TabIndex = 4;
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.Location = new System.Drawing.Point(839, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 28);
            this.exit_btn.TabIndex = 5;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // disp_btn
            // 
            this.disp_btn.BackColor = System.Drawing.Color.White;
            this.disp_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.disp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.disp_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.disp_btn.ForeColor = System.Drawing.Color.Black;
            this.disp_btn.Location = new System.Drawing.Point(814, 99);
            this.disp_btn.Name = "disp_btn";
            this.disp_btn.Size = new System.Drawing.Size(116, 50);
            this.disp_btn.TabIndex = 6;
            this.disp_btn.Text = "Display All";
            this.disp_btn.UseVisualStyleBackColor = false;
            this.disp_btn.Click += new System.EventHandler(this.disp_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(43)))), ((int)(((byte)(43)))));
            this.del_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.del_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del_btn.ForeColor = System.Drawing.Color.Black;
            this.del_btn.Location = new System.Drawing.Point(692, 99);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(116, 50);
            this.del_btn.TabIndex = 7;
            this.del_btn.Text = "Delete";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(567, 114);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(119, 35);
            this.search_btn.TabIndex = 8;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // ins_btn
            // 
            this.ins_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(128)))), ((int)(((byte)(69)))));
            this.ins_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ins_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ins_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ins_btn.ForeColor = System.Drawing.Color.Black;
            this.ins_btn.Location = new System.Drawing.Point(692, 43);
            this.ins_btn.Name = "ins_btn";
            this.ins_btn.Size = new System.Drawing.Size(116, 50);
            this.ins_btn.TabIndex = 9;
            this.ins_btn.Text = "Insert";
            this.ins_btn.UseVisualStyleBackColor = false;
            this.ins_btn.Click += new System.EventHandler(this.ins_btn_Click);
            // 
            // upd_btn
            // 
            this.upd_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(63)))), ((int)(((byte)(125)))));
            this.upd_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upd_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.upd_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.upd_btn.ForeColor = System.Drawing.Color.Black;
            this.upd_btn.Location = new System.Drawing.Point(814, 43);
            this.upd_btn.Name = "upd_btn";
            this.upd_btn.Size = new System.Drawing.Size(116, 50);
            this.upd_btn.TabIndex = 10;
            this.upd_btn.Text = "Update";
            this.upd_btn.UseVisualStyleBackColor = false;
            this.upd_btn.Click += new System.EventHandler(this.upd_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 155);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(918, 462);
            this.groupBox1.TabIndex = 11;
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
            this.dataGridView1.Size = new System.Drawing.Size(906, 434);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseDoubleClick);
            // 
            // Maintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(942, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.upd_btn);
            this.Controls.Add(this.ins_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.disp_btn);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.id_box2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.id_box);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Maintenance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maintenance";
            this.Load += new System.EventHandler(this.Maintenance_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox id_box;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_box2;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.Button disp_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button ins_btn;
        private System.Windows.Forms.Button upd_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}