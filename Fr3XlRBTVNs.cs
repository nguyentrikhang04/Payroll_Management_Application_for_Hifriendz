using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G107NTKSlrHF
{
    public partial class Fr3XlRBTVNs : Form
    {
        static string msns = "", tenns = "";//BIẾN TOÀN CỤC TRONG FORM XL RBTV Cho phép lưu trữ mã nhân sự và tên nhân sự cần xóa được gửi từ form QlDmNsHf sang đây

        private void Fr3XlRBTVNs_Load(object sender, EventArgs e)
        {
            lbTitle.Text = "XỬ LÝ RBTV KHI XÓA NHÂN SỰ CÓ MÃ SỐ " + msns + " _ " + tenns;
            gbPCC.Text = "CẦN XỬ LÝ CÁC PHIẾU CHẤM CÔNG SAU ĐÂY CỦA NHÂN SỰ: " + msns + " _ " + tenns + "TRÊN CÁC KỲ LƯƠNG SAU";
            gbPL.Text = "CẦN XỬ LÝ CÁC PHIẾU LƯƠNG CỦA NHÂN SỰ  " + msns + " _ " + tenns;
            try
            {
                // TODO: This line of code loads data into the 'g107NTKSalaHFDsPL.PHIEULUONG' table. You can move, or remove it, as needed.
                this.pHIEULUONGTableAdapter.Fill(this.g107NTKSalaHFDsPL.PHIEULUONG, msns);
            }
            catch (System.Exception) { }
            try
            {
                // TODO: This line of code loads data into the 'g107NTKSalaHFDsPCC.PHIEUCHAMCONG' table. You can move, or remove it, as needed.
                this.pHIEUCHAMCONGTableAdapter.Fill(this.g107NTKSalaHFDsPCC.PHIEUCHAMCONG, msns);
            }
            catch (System.Exception) { }

        }//private void Fr3XlRBTVNs_Load(object sender, EventArgs e)

        public Fr3XlRBTVNs(string msnshf, string tennshf)
        {
            InitializeComponent();

            msns = msnshf;//lấy mã nhân sự hifriendz
            tenns = tennshf;//lấy tên nhân sự hifriendz
        }

        /// <summary>
        /// XỬ LÝ RBTV CỦA PHIẾU CHẤM CÔNG 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnHuyPhieuCC_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCC.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {
                //B1: XỬ LÝ TRƯỜNG HỢP NSD CHƯA CHỌN DÒNG NÀO TRONG DS BÊN TRÁI (ĐỂ XÓA).             
                DataGridViewRow r = null; // biến tạm lưu dòng đang chọn trong DataGridView
                try
  {
                    r = dataGridViewPCC.SelectedRows[0];
                    //Vì thuộc tính MultiSelect = Flase nên chỉ có 1 dòng được chọn do đó SelectedRows[0]là dòng chọn đầu tiên cũng là duy nhất
                }catch (System.Exception)
  {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. trước khi bấm nút này");
                    goto kt;
                }

                //B2: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa PHIẾU CHẤM CÔNG có MÃ NHÂN SỰ:" + msns + " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?",
                                                                    "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận

                // Lấy giá trị từ cột 'mskyDataGridViewTextBoxColumn' của dòng được chọn
                string msky = r.Cells["mskyDataGridViewTextBoxColumn"]?.Value?.ToString()?.Trim();
                //B3: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình  r.Cells[0].Value.ToString().Trim()
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        pHIEUCHAMCONGTableAdapter.Delete(msns, msky);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
                }//if[YES]
                 //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
                try
                {
                    this.pHIEUCHAMCONGTableAdapter.Fill(this.g107NTKSalaHFDsPCC.PHIEUCHAMCONG, msns);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
            
            kt:;
        }

        /// <summary>
        /// XÓA ALL PHIẾU CHẤM CÔNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuyPhieuCCAll_Click(object sender, EventArgs e)
        {
            if (dataGridViewPCC.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {
                //B1: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa ALL PHIẾU CHẤM CÔNG có NHÂN SỰ:" + msns + " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo,
                                                                                                        MessageBoxIcon.Question);//Hỏi xác nhận


                //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        pHIEUCHAMCONGTableAdapter.DeleteQuery(msns);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
                }//if(Yes)

                //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWPCC
                try
                {
                    this.pHIEUCHAMCONGTableAdapter.Fill(this.g107NTKSalaHFDsPCC.PHIEUCHAMCONG, msns);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
        }

        /// <summary>
        /// XỬ LÝ RBTV CÁC PHIẾU LƯƠNG
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHuyPhieuLuong_Click(object sender, EventArgs e)
        {
            if (dataGridViewPL.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {
                //B1: XỬ LÝ TRƯỜNG HỢP NSD CHƯA CHỌN DÒNG NÀO TRONG DS BÊN TRÁI (ĐỂ XÓA).             
                DataGridViewRow r = null; // biến tạm lưu dòng đang chọn trong DataGridView
                try
                {
                    r = dataGridViewPL.SelectedRows[0];//Vì thuộc tính MultiSelect = Flase nên chỉ có 1 dòng được chọn do đó SelectedRows[0] là dòng chọn đầu tiên cũng là duy nhất
                }
                catch (System.Exception)
                {
                    MessageBox.Show("Cần phải chọn 1 dòng trong danh sách bên trái. trước khi bấm nút này");
                    goto kt;
                }
                //B2: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa PHIẾU LƯƠNG của NHÂN SỰ có MÃ:" + msns +
                   " Tại vị trí chọn trong danh sách bên trái đúng không(Y/N)?", "Xác nhận",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);//Hỏi xác nhận

                // Lấy giá trị từ cột 'msphieuDataGridViewTextBoxColumn1' của dòng được chọn
                string msphieu = r.Cells["msphieuDataGridViewTextBoxColumn1"]?.Value?.ToString()?.Trim();
                //B3: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        pHIEULUONGTableAdapter.Delete(msphieu, msns);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
                }//if(Yes)

                //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWPL
                try
                {
                    this.pHIEULUONGTableAdapter.Fill(this.g107NTKSalaHFDsPL.PHIEULUONG, msns);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
            kt:;
        }
        //HỦY TOÀN BỘ CÁC PHIẾU LƯƠNG TRÊN DATAGRIDVIEW
        private void btnHuyPhieuLuongAll_Click(object sender, EventArgs e)
        {
            if (dataGridViewPL.Rows.Count > 1)// danh sach bên trái có ít nhất 1 dòng
            {//B1: HỎI XÁC NHẬN
                DialogResult ch = MessageBox.Show("Xóa ALL PHIẾU LƯƠNG có NHÂN SỰ:" + msns +
                " đúng không(Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Hỏi xác nhận
                //B2: XÓA nếu NSD Yes  [Nên Try...catch...: tránh phát sinh lỗi dừng đột ngột chương trình
                if (ch == DialogResult.Yes)
                {
                    try
                    {
                        pHIEULUONGTableAdapter.DeleteQuery(msns);
                        MessageBox.Show("Xóa xong !");
                    }
                    catch (System.Exception ex) { MessageBox.Show("Có lỗi =" + ex.Message); }
                }//if(Yes)
                 //B3: TẢI DL SAU KHI XÓA LÊN DATAGRIDVIEWCTNV
                try
                {
                    this.pHIEULUONGTableAdapter.Fill(this.g107NTKSalaHFDsPL.PHIEULUONG, msns);
                }
                catch (System.Exception) { }
            }//if count > 1; có thể else = thông báo không có dòng nào nên không xóa được
            else//if count > 1
            {
                MessageBox.Show("Không có CHI TIẾT nào, không có gì để xóa");
            }
        }

    }//public partial class Fr3XlRBTVNs : Form
}
