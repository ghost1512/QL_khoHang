namespace QuanLy
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sua_btn = new System.Windows.Forms.Button();
            this.Xoa_btn = new System.Windows.Forms.Button();
            this.timKiem_btn = new System.Windows.Forms.Button();
            this.tenHang = new System.Windows.Forms.TextBox();
            this.soLuong = new System.Windows.Forms.TextBox();
            this.ngayNhap = new System.Windows.Forms.DateTimePicker();
            this.ngayXuat = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.timKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(67, 275);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1026, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // maHang
            // 
            this.maHang.Location = new System.Drawing.Point(167, 86);
            this.maHang.Name = "maHang";
            this.maHang.Size = new System.Drawing.Size(358, 22);
            this.maHang.TabIndex = 1;
            this.maHang.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã hàng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Sua_btn
            // 
            this.Sua_btn.Location = new System.Drawing.Point(227, 536);
            this.Sua_btn.Name = "Sua_btn";
            this.Sua_btn.Size = new System.Drawing.Size(208, 66);
            this.Sua_btn.TabIndex = 3;
            this.Sua_btn.Text = "Sửa";
            this.Sua_btn.UseVisualStyleBackColor = true;
            // 
            // Xoa_btn
            // 
            this.Xoa_btn.Location = new System.Drawing.Point(666, 536);
            this.Xoa_btn.Name = "Xoa_btn";
            this.Xoa_btn.Size = new System.Drawing.Size(208, 66);
            this.Xoa_btn.TabIndex = 4;
            this.Xoa_btn.Text = "Xóa";
            this.Xoa_btn.UseVisualStyleBackColor = true;
            // 
            // timKiem_btn
            // 
            this.timKiem_btn.Location = new System.Drawing.Point(918, 237);
            this.timKiem_btn.Name = "timKiem_btn";
            this.timKiem_btn.Size = new System.Drawing.Size(175, 32);
            this.timKiem_btn.TabIndex = 5;
            this.timKiem_btn.Text = "Tìm kiếm";
            this.timKiem_btn.UseVisualStyleBackColor = true;
            // 
            // tenHang
            // 
            this.tenHang.Location = new System.Drawing.Point(167, 115);
            this.tenHang.Name = "tenHang";
            this.tenHang.Size = new System.Drawing.Size(358, 22);
            this.tenHang.TabIndex = 6;
            // 
            // soLuong
            // 
            this.soLuong.Location = new System.Drawing.Point(167, 143);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(358, 22);
            this.soLuong.TabIndex = 7;
            // 
            // ngayNhap
            // 
            this.ngayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayNhap.Location = new System.Drawing.Point(167, 172);
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ngayNhap.Size = new System.Drawing.Size(358, 22);
            this.ngayNhap.TabIndex = 4;
            this.ngayNhap.Value = new System.DateTime(2025, 2, 23, 0, 0, 0, 0);
            this.ngayNhap.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // ngayXuat
            // 
            this.ngayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngayXuat.Location = new System.Drawing.Point(167, 200);
            this.ngayXuat.Name = "ngayXuat";
            this.ngayXuat.Size = new System.Drawing.Size(358, 22);
            this.ngayXuat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(64, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ngày nhập";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ngày xuất";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // timKiem
            // 
            this.timKiem.Location = new System.Drawing.Point(554, 242);
            this.timKiem.Name = "timKiem";
            this.timKiem.Size = new System.Drawing.Size(358, 22);
            this.timKiem.TabIndex = 14;
            this.timKiem.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 762);
            this.Controls.Add(this.timKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ngayXuat);
            this.Controls.Add(this.ngayNhap);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.tenHang);
            this.Controls.Add(this.timKiem_btn);
            this.Controls.Add(this.Xoa_btn);
            this.Controls.Add(this.Sua_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.maHang);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox maHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Sua_btn;
        private System.Windows.Forms.Button Xoa_btn;
        private System.Windows.Forms.Button timKiem_btn;
        private System.Windows.Forms.TextBox tenHang;
        private System.Windows.Forms.TextBox soLuong;
        private System.Windows.Forms.DateTimePicker ngayNhap;
        private System.Windows.Forms.DateTimePicker ngayXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox timKiem;
    }
}

