namespace TranThanhHai171201099
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_MucLuong = new System.Windows.Forms.TextBox();
            this.txt_TenCV = new System.Windows.Forms.TextBox();
            this.txt_MaCV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.bt_TimKiem = new System.Windows.Forms.Button();
            this.txt_SearchTenCV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_SearchMaCV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_Them = new System.Windows.Forms.Button();
            this.bt_Sua = new System.Windows.Forms.Button();
            this.bt_Xoa = new System.Windows.Forms.Button();
            this.bt_XuatExcel = new System.Windows.Forms.Button();
            this.bt_Thoat = new System.Windows.Forms.Button();
            this.bt_LamMoi = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_MucLuong);
            this.groupBox1.Controls.Add(this.txt_TenCV);
            this.groupBox1.Controls.Add(this.txt_MaCV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 188);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập thông tin";
            // 
            // txt_MucLuong
            // 
            this.txt_MucLuong.Location = new System.Drawing.Point(162, 119);
            this.txt_MucLuong.Name = "txt_MucLuong";
            this.txt_MucLuong.Size = new System.Drawing.Size(131, 20);
            this.txt_MucLuong.TabIndex = 5;
            // 
            // txt_TenCV
            // 
            this.txt_TenCV.Location = new System.Drawing.Point(162, 79);
            this.txt_TenCV.Name = "txt_TenCV";
            this.txt_TenCV.Size = new System.Drawing.Size(131, 20);
            this.txt_TenCV.TabIndex = 4;
            // 
            // txt_MaCV
            // 
            this.txt_MaCV.Location = new System.Drawing.Point(162, 35);
            this.txt_MaCV.Name = "txt_MaCV";
            this.txt_MaCV.Size = new System.Drawing.Size(131, 20);
            this.txt_MaCV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mức lương";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên công việc";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã công việc";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(383, 232);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh mục công việc";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(371, 204);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.bt_TimKiem);
            this.groupBox3.Controls.Add(this.txt_SearchTenCV);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txt_SearchMaCV);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(401, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(387, 188);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tìm kiếm";
            // 
            // bt_TimKiem
            // 
            this.bt_TimKiem.Location = new System.Drawing.Point(157, 128);
            this.bt_TimKiem.Name = "bt_TimKiem";
            this.bt_TimKiem.Size = new System.Drawing.Size(95, 40);
            this.bt_TimKiem.TabIndex = 7;
            this.bt_TimKiem.Text = "Tìm kiếm";
            this.bt_TimKiem.UseVisualStyleBackColor = true;
            this.bt_TimKiem.Click += new System.EventHandler(this.Bt_TimKiem_Click);
            // 
            // txt_SearchTenCV
            // 
            this.txt_SearchTenCV.Location = new System.Drawing.Point(176, 82);
            this.txt_SearchTenCV.Name = "txt_SearchTenCV";
            this.txt_SearchTenCV.Size = new System.Drawing.Size(131, 20);
            this.txt_SearchTenCV.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(84, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã công việc";
            // 
            // txt_SearchMaCV
            // 
            this.txt_SearchMaCV.Location = new System.Drawing.Point(176, 38);
            this.txt_SearchMaCV.Name = "txt_SearchMaCV";
            this.txt_SearchMaCV.Size = new System.Drawing.Size(131, 20);
            this.txt_SearchMaCV.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tên công việc";
            // 
            // bt_Them
            // 
            this.bt_Them.Location = new System.Drawing.Point(433, 249);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(95, 40);
            this.bt_Them.TabIndex = 2;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.UseVisualStyleBackColor = true;
            this.bt_Them.Click += new System.EventHandler(this.Bt_Them_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.Location = new System.Drawing.Point(558, 249);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(95, 40);
            this.bt_Sua.TabIndex = 3;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.UseVisualStyleBackColor = true;
            this.bt_Sua.Click += new System.EventHandler(this.Bt_Sua_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.Location = new System.Drawing.Point(679, 249);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(95, 40);
            this.bt_Xoa.TabIndex = 4;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.UseVisualStyleBackColor = true;
            this.bt_Xoa.Click += new System.EventHandler(this.Bt_Xoa_Click);
            // 
            // bt_XuatExcel
            // 
            this.bt_XuatExcel.Location = new System.Drawing.Point(558, 345);
            this.bt_XuatExcel.Name = "bt_XuatExcel";
            this.bt_XuatExcel.Size = new System.Drawing.Size(95, 40);
            this.bt_XuatExcel.TabIndex = 5;
            this.bt_XuatExcel.Text = "Xuất Excel";
            this.bt_XuatExcel.UseVisualStyleBackColor = true;
            this.bt_XuatExcel.Click += new System.EventHandler(this.Bt_XuatExcel_Click);
            // 
            // bt_Thoat
            // 
            this.bt_Thoat.Location = new System.Drawing.Point(679, 345);
            this.bt_Thoat.Name = "bt_Thoat";
            this.bt_Thoat.Size = new System.Drawing.Size(95, 40);
            this.bt_Thoat.TabIndex = 6;
            this.bt_Thoat.Text = "Thoát";
            this.bt_Thoat.UseVisualStyleBackColor = true;
            this.bt_Thoat.Click += new System.EventHandler(this.Bt_Thoat_Click);
            // 
            // bt_LamMoi
            // 
            this.bt_LamMoi.Location = new System.Drawing.Point(433, 345);
            this.bt_LamMoi.Name = "bt_LamMoi";
            this.bt_LamMoi.Size = new System.Drawing.Size(95, 40);
            this.bt_LamMoi.TabIndex = 7;
            this.bt_LamMoi.Text = "Làm mới";
            this.bt_LamMoi.UseVisualStyleBackColor = true;
            this.bt_LamMoi.Click += new System.EventHandler(this.Bt_LamMoi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_LamMoi);
            this.Controls.Add(this.bt_Thoat);
            this.Controls.Add(this.bt_XuatExcel);
            this.Controls.Add(this.bt_Xoa);
            this.Controls.Add(this.bt_Sua);
            this.Controls.Add(this.bt_Them);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý công việc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_MucLuong;
        private System.Windows.Forms.TextBox txt_TenCV;
        private System.Windows.Forms.TextBox txt_MaCV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button bt_TimKiem;
        private System.Windows.Forms.TextBox txt_SearchTenCV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_SearchMaCV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_Them;
        private System.Windows.Forms.Button bt_Sua;
        private System.Windows.Forms.Button bt_Xoa;
        private System.Windows.Forms.Button bt_XuatExcel;
        private System.Windows.Forms.Button bt_Thoat;
        private System.Windows.Forms.Button bt_LamMoi;
    }
}

