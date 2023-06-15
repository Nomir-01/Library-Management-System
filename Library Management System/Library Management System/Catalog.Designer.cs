
namespace Library_Management_System
{
    partial class Catalog
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
            this.search_box2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.search_box1 = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.disp_btn = new System.Windows.Forms.Button();
            this.exit_btn = new System.Windows.Forms.Button();
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
            this.label1.Size = new System.Drawing.Size(144, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name :";
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
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // search_box2
            // 
            this.search_box2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_box2.Location = new System.Drawing.Point(210, 95);
            this.search_box2.Name = "search_box2";
            this.search_box2.PlaceholderText = "Aurthur";
            this.search_box2.Size = new System.Drawing.Size(147, 29);
            this.search_box2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("DejaVu Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Publisher Name :";
            // 
            // search_box1
            // 
            this.search_box1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_box1.Location = new System.Drawing.Point(210, 41);
            this.search_box1.Name = "search_box1";
            this.search_box1.PlaceholderText = "Macbeth";
            this.search_box1.Size = new System.Drawing.Size(147, 29);
            this.search_box1.TabIndex = 4;
            // 
            // search_btn
            // 
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_btn.Location = new System.Drawing.Point(363, 90);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(119, 35);
            this.search_btn.TabIndex = 5;
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
            this.disp_btn.Location = new System.Drawing.Point(1264, 75);
            this.disp_btn.Name = "disp_btn";
            this.disp_btn.Size = new System.Drawing.Size(116, 50);
            this.disp_btn.TabIndex = 6;
            this.disp_btn.Text = "Display All";
            this.disp_btn.UseVisualStyleBackColor = false;
            this.disp_btn.Click += new System.EventHandler(this.disp_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit_btn.Location = new System.Drawing.Point(1289, 5);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(91, 28);
            this.exit_btn.TabIndex = 7;
            this.exit_btn.Text = "Exit";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1368, 481);
            this.groupBox1.TabIndex = 8;
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
            this.dataGridView1.Size = new System.Drawing.Size(1356, 453);
            this.dataGridView1.TabIndex = 0;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1392, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.disp_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_box1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_box2);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Catalog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.Catalog_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox search_box2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox search_box1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button disp_btn;
        private System.Windows.Forms.Button exit_btn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}