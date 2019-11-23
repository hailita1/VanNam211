using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace TranThanhHai171201099
{
    public partial class Form1 : Form
    {
        database database = new database();
        public Form1()
        {
            InitializeComponent();
        }

        private void Bt_XuatExcel_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1) //TH có dữ liệu để ghi
            {
                //Khai báo và khởi tạo các đối tượng
                Excel.Application exApp = new Excel.Application();
                Excel.Workbook exBook = exApp.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet exSheet = (Excel.Worksheet)exBook.Worksheets[1];

                //Định dạng chung
                Excel.Range tenCuaHang = (Excel.Range)exSheet.Cells[1, 1];
                tenCuaHang.Font.Size = 14;
                tenCuaHang.Font.Bold = true;
                tenCuaHang.Font.Color = Color.Blue;
                tenCuaHang.Value = "DANH SÁCH CÔNG VIỆC ";

                Excel.Range dcCuaHang = (Excel.Range)exSheet.Cells[2, 1];
                dcCuaHang.Font.Size = 14;
                dcCuaHang.Font.Bold = true;
                dcCuaHang.Font.Color = Color.Blue;
                dcCuaHang.Value = "Copyright-Trần Thanh Hải";

                Excel.Range dtCuaHang = (Excel.Range)exSheet.Cells[3, 1];
                dtCuaHang.Font.Size = 14;
                dtCuaHang.Font.Bold = true;
                dtCuaHang.Font.Color = Color.Blue;
                dtCuaHang.Value = "Điện thoại: 1800 8198";

                //Định dạng tiêu đề bảng

                exSheet.get_Range("A7:D7").Font.Bold = true;
                exSheet.get_Range("A7:D7").HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                exSheet.get_Range("A7").Value = "STT";
                exSheet.get_Range("B7").Value = "Mã Công Việc";
                exSheet.get_Range("B7").ColumnWidth = 20;
                exSheet.get_Range("C7").Value = "Tên Công Việc";
                exSheet.get_Range("C7").ColumnWidth = 20;
                exSheet.get_Range("D7").Value = "Mức Lương";
                exSheet.get_Range("D7").ColumnWidth = 20;

                //In dữ liệu
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    exSheet.get_Range("A" + (i + 8).ToString() + ":G" + (i + 8).ToString()).Font.Bold = false;
                    exSheet.get_Range("A" + (i + 8).ToString()).Value = (i + 1).ToString();
                    exSheet.get_Range("B" + (i + 8).ToString()).Value =
                        dataGridView1.Rows[i].Cells[0].Value;
                    exSheet.get_Range("C" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[1].Value;
                    exSheet.get_Range("D" + (i + 8).ToString()).Value = dataGridView1.Rows[i].Cells[2].Value;
                }
                exSheet.Name = "Danh sách";
                exBook.Activate(); //Kích hoạt file Excel
                //Thiết lập các thuộc tính của SaveFileDialog
                SaveFileDialog dlgSave = new SaveFileDialog();
                dlgSave.Filter = "Excel Document(*.xlsx)|*.xlsx  |Word Document(*.docx) |*.docx|All files(*.*)|*.*";
                dlgSave.FilterIndex = 1;
                dlgSave.AddExtension = true;
                dlgSave.DefaultExt = ".xlsx";
                if (dlgSave.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    exBook.SaveAs(dlgSave.FileName.ToString());//Lưu file Excel
                exApp.Quit();//Thoát khỏi ứng dụng
            }
            else
                MessageBox.Show("Không có danh sách hàng để in");
        }

        private void Bt_Them_Click(object sender, EventArgs e)
        {
            if (txt_MaCV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy Nhập Mã Công Việc", "Thông Báo");
                txt_MaCV.Focus();
            }
            else if (txt_TenCV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy Nhập Tên Công Việc", "Thông Báo");
                txt_TenCV.Focus();
            }
            else if (txt_MucLuong.Text.Trim() == "")
            {
                MessageBox.Show("Hãy Nhập Mức Lương", "Thông Báo");
                txt_MucLuong.Focus();
            }
            else
            {
                string sql = " select * from CongViec where MCV = '" + txt_MaCV.Text + "' ";
                DataTable table = new DataTable();
                table = database.LoadDuLieu(sql);
                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Mã Công Việc Này Đã Tồn Tại");
                    txt_MaCV.Focus();
                    return;
                }
                string sql1 = " insert into CongViec VALUES ('" + txt_MaCV.Text + "',N'" + txt_TenCV.Text + "','" + txt_MucLuong.Text + "','" + txtImg.Text + "')";
                database.RunSQL123(sql1);
                Fill();
                MessageBox.Show("Thêm Thành Công", "Thông báo");
                ClearData();


            }
        }
        private void Fill()
        {
            string sql = "select * from CongViec";

            dataGridView1.DataSource = database.LoadDuLieu(sql);
            dataGridView1.Columns[0].HeaderText = "Mã Công Việc";
            dataGridView1.Columns[1].HeaderText = "Tên Công Việc";
            dataGridView1.Columns[2].HeaderText = "Mức Lương";
            dataGridView1.Columns[3].HeaderText = "Ảnh";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
            Fill();
            txt_MaCV.Enabled = false;
            txt_MaCV.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            txt_TenCV.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            txt_MucLuong.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            if (dataGridView1.Rows[0].Cells[3].Value.ToString().Trim() != "")
            {
                pictureBox1.Image = Image.FromFile(dataGridView1.Rows[0].Cells[3].Value.ToString());
            }
        }
        private void ClearData()
        {
            txt_MaCV.Enabled = true;
            txt_MaCV.Text = "";
            txt_TenCV.Text = "";
            txt_MucLuong.Text = "";
            txt_SearchMaCV.Text = "";
            txt_SearchTenCV.Text = "";
        }

        private void Bt_LamMoi_Click(object sender, EventArgs e)
        {
            Fill();
            ClearData();
        }

        private void Bt_Thoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Bt_Sua_Click(object sender, EventArgs e)
        {
            string sql;

            sql = "update CongViec SET MCV = '" + txt_MaCV.Text + "', TenCV = N'" + txt_TenCV.Text + "', MucLuong = '" + txt_MucLuong.Text + "',Anh = N'" + txtImg.Text + "' where MCV = '" + txt_MaCV.Text + "'";
            if (txt_MaCV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy chọn một công việc để xóa", "Thông Báo");
            }
            else
            if (txt_TenCV.Text.Trim() == "")
            {
                MessageBox.Show("Hãy Nhập Tên Công Việc", "Thông Báo");
                txt_TenCV.Focus();
            }
            else if (txt_MucLuong.Text.Trim() == "")
            {
                MessageBox.Show("Hãy Nhập Mức Lương", "Thông Báo");
                txt_MucLuong.Focus();
            }
            else
            {
                database.RunSQL123(sql);
                MessageBox.Show("Sửa Thành Công", "Thông báo");
                Fill();
                ClearData();
            }
        }

        private void Bt_Xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow.Index == -1)
            {
                MessageBox.Show("Hãy chọn một công việc để xóa", "Thông Báo");
            }
            else
            {
                DialogResult ret =
                    MessageBox.Show("Bạn có muốn xóa không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                if (ret == DialogResult.Yes)
                {

                    string sql = " select MCV from NhanVien where MCV = '" + txt_MaCV.Text + "'";
                    DataTable tb = new DataTable();
                    tb = database.LoadDuLieu(sql);
                    if (tb.Rows.Count > 0)
                    {
                        MessageBox.Show("Công việc này đã có nhân viên làm rồi không thể xóa.");
                        return;
                    }
                    if (txt_MaCV.Text.Trim() == "")
                    {
                        MessageBox.Show("Hãy chọn một công việc để xóa");

                    }
                    else
                    {
                        sql = "delete from CongViec where MCV = '" + txt_MaCV.Text + "'";
                        database.RunSQL123(sql);
                        MessageBox.Show("Xóa Thành Công", "Thông báo");
                        Fill();
                        ClearData();
                    }

                }
            }
        }

        private void DataGridView1_Click(object sender, EventArgs e)
        {
            txt_MaCV.Enabled = false;
            int t = dataGridView1.CurrentRow.Index;
            txt_MaCV.Text = dataGridView1.Rows[t].Cells[0].Value.ToString();
            txt_TenCV.Text = dataGridView1.Rows[t].Cells[1].Value.ToString();
            txt_MucLuong.Text = dataGridView1.Rows[t].Cells[2].Value.ToString();
            if (dataGridView1.Rows[t].Cells[3].Value.ToString().Trim() == "")
            {
                txtImg.Text = "";
                pictureBox1.Visible = false;
            }
            else
            {
                txtImg.Text = dataGridView1.Rows[t].Cells[3].Value.ToString();
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(txtImg.Text);
            }

        }

        private void Bt_TimKiem_Click(object sender, EventArgs e)
        {
            string sql = "select * from CongViec where MCV is not null ";
            if (txt_SearchMaCV.Text.Trim() != "")
            {
                sql += " and MCV like '%" + txt_SearchMaCV.Text + "%'";
            }
            if (txt_SearchTenCV.Text.Trim() != "")
            {
                sql += " and TenCV like N'%" + txt_SearchTenCV.Text + "%'";
            }
            dataGridView1.DataSource = database.LoadDuLieu(sql);
            if (dataGridView1.RowCount == 1)
            {
                MessageBox.Show("Không tìm thấy thông tin công việc", "Thông báo");
            }
        }

        private void Btn_LoadAnh_Click(object sender, EventArgs e)
        {
        }

        private void Txt_MucLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Btn_Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "Bitmap(*.bmp)|*.bmp|Gif(*.jpg) |*.jpg|All files(*.*)|*.*";
            dlgOpen.InitialDirectory = "E:\\BaiGiang"; dlgOpen.FilterIndex = 2;
            dlgOpen.Title = "Chọn ảnh để hiển thị";
            if (dlgOpen.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                pictureBox1.Visible = true;
                pictureBox1.Image = Image.FromFile(dlgOpen.FileName);
                txtImg.Text = dlgOpen.FileName;
            }
            else MessageBox.Show("You clicked Cancel", "Open Dialog",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Btn_NgheNhac_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "MuonRuouToTinh-EmilyBigDaddy-5871420.mp3";
            
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.Alt)
            {
                if(e.KeyCode.Equals(Keys.T))
                {
                    Bt_Thoat_Click(null, null);
                }
            }
        }
    }
}
