
namespace BTL
{
    partial class quanlynv
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_quaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bt_lichlamviec = new System.Windows.Forms.Button();
            this.bt_ttnv = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgv_quanlynv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlynv)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_quaylai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(995, 74);
            this.panel1.TabIndex = 0;
            // 
            // button_quaylai
            // 
            this.button_quaylai.Location = new System.Drawing.Point(0, 0);
            this.button_quaylai.Margin = new System.Windows.Forms.Padding(4);
            this.button_quaylai.Name = "button_quaylai";
            this.button_quaylai.Size = new System.Drawing.Size(100, 28);
            this.button_quaylai.TabIndex = 1;
            this.button_quaylai.Text = "Trở về";
            this.button_quaylai.UseVisualStyleBackColor = true;
            this.button_quaylai.Click += new System.EventHandler(this.button_quaylai_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quản Lý Nhân Viên";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.59517F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.40483F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 74);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(995, 564);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Controls.Add(this.bt_lichlamviec);
            this.panel2.Controls.Add(this.bt_ttnv);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(37, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(323, 556);
            this.panel2.TabIndex = 0;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(8, 274);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // bt_lichlamviec
            // 
            this.bt_lichlamviec.Location = new System.Drawing.Point(0, 135);
            this.bt_lichlamviec.Margin = new System.Windows.Forms.Padding(4);
            this.bt_lichlamviec.Name = "bt_lichlamviec";
            this.bt_lichlamviec.Size = new System.Drawing.Size(319, 47);
            this.bt_lichlamviec.TabIndex = 1;
            this.bt_lichlamviec.Text = "Cập nhật lịch làm việc";
            this.bt_lichlamviec.UseVisualStyleBackColor = true;
            this.bt_lichlamviec.Click += new System.EventHandler(this.bt_lichlamviec_Click);
            // 
            // bt_ttnv
            // 
            this.bt_ttnv.Location = new System.Drawing.Point(4, 41);
            this.bt_ttnv.Margin = new System.Windows.Forms.Padding(4);
            this.bt_ttnv.Name = "bt_ttnv";
            this.bt_ttnv.Size = new System.Drawing.Size(315, 47);
            this.bt_ttnv.TabIndex = 0;
            this.bt_ttnv.Text = "Cập nhật thông tin nhân viên";
            this.bt_ttnv.UseVisualStyleBackColor = true;
            this.bt_ttnv.Click += new System.EventHandler(this.bt_ttnv_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(368, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(623, 556);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgv_quanlynv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 74);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(623, 482);
            this.panel4.TabIndex = 1;
            // 
            // dgv_quanlynv
            // 
            this.dgv_quanlynv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_quanlynv.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv_quanlynv.Location = new System.Drawing.Point(0, 0);
            this.dgv_quanlynv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_quanlynv.Name = "dgv_quanlynv";
            this.dgv_quanlynv.RowHeadersWidth = 51;
            this.dgv_quanlynv.Size = new System.Drawing.Size(623, 482);
            this.dgv_quanlynv.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(285, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lịch làm việc của nhân viên";
            // 
            // quanlynv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 638);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "quanlynv";
            this.Text = "Quản lý nhân viên";
            this.Load += new System.EventHandler(this.quanlynv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_quanlynv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bt_lichlamviec;
        private System.Windows.Forms.Button bt_ttnv;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dgv_quanlynv;
        private System.Windows.Forms.Button button_quaylai;
    }
}