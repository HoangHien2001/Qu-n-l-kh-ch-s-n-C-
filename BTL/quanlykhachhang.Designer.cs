
namespace BTL
{
    partial class quanlykhachhang
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_quaylai = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bt_loc = new System.Windows.Forms.Button();
            this.bt_huy = new System.Windows.Forms.Button();
            this.dateTimePicker_tungay = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_denngay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_qlkhachhang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlkhachhang)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.60566F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.39434F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(643, 459);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dateTimePicker_denngay);
            this.panel1.Controls.Add(this.dateTimePicker_tungay);
            this.panel1.Controls.Add(this.bt_huy);
            this.panel1.Controls.Add(this.bt_loc);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.bt_quaylai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 262);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản lý khách hàng";
            // 
            // bt_quaylai
            // 
            this.bt_quaylai.Location = new System.Drawing.Point(3, 3);
            this.bt_quaylai.Name = "bt_quaylai";
            this.bt_quaylai.Size = new System.Drawing.Size(81, 26);
            this.bt_quaylai.TabIndex = 1;
            this.bt_quaylai.Text = "Trở về";
            this.bt_quaylai.UseVisualStyleBackColor = true;
            this.bt_quaylai.Click += new System.EventHandler(this.bt_quaylai_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(304, 34);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bt_loc
            // 
            this.bt_loc.Location = new System.Drawing.Point(132, 137);
            this.bt_loc.Name = "bt_loc";
            this.bt_loc.Size = new System.Drawing.Size(81, 34);
            this.bt_loc.TabIndex = 3;
            this.bt_loc.Text = "Lọc";
            this.bt_loc.UseVisualStyleBackColor = true;
            this.bt_loc.Click += new System.EventHandler(this.bt_loc_Click);
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(132, 203);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(81, 34);
            this.bt_huy.TabIndex = 4;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // dateTimePicker_tungay
            // 
            this.dateTimePicker_tungay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_tungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_tungay.Location = new System.Drawing.Point(373, 137);
            this.dateTimePicker_tungay.Name = "dateTimePicker_tungay";
            this.dateTimePicker_tungay.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_tungay.TabIndex = 5;
            // 
            // dateTimePicker_denngay
            // 
            this.dateTimePicker_denngay.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker_denngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_denngay.Location = new System.Drawing.Point(373, 203);
            this.dateTimePicker_denngay.Name = "dateTimePicker_denngay";
            this.dateTimePicker_denngay.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker_denngay.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Từ ngày";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(256, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Đến ngày";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_qlkhachhang);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(637, 185);
            this.panel2.TabIndex = 1;
            // 
            // dgv_qlkhachhang
            // 
            this.dgv_qlkhachhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_qlkhachhang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_qlkhachhang.Location = new System.Drawing.Point(0, 0);
            this.dgv_qlkhachhang.Name = "dgv_qlkhachhang";
            this.dgv_qlkhachhang.RowHeadersVisible = false;
            this.dgv_qlkhachhang.Size = new System.Drawing.Size(637, 185);
            this.dgv_qlkhachhang.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(60, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Tìm kiếm";
            // 
            // quanlykhachhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 459);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "quanlykhachhang";
            this.Text = "Quản lý khách hàng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.quanlykhachhang_FormClosing);
            this.Load += new System.EventHandler(this.quanlykhachhang_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_qlkhachhang)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker_denngay;
        private System.Windows.Forms.DateTimePicker dateTimePicker_tungay;
        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_loc;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bt_quaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_qlkhachhang;
        private System.Windows.Forms.Label label4;
    }
}