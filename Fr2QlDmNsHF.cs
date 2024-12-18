using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace G107NTKSlrHF
{
    public partial class Fr2QlDmNsHF : Form
    {
        //KHAI BÁO CÁC THAM SỐ TOÀN CỤC 
        //static string name = "", pass = "";
        string apppath = System.IO.Path.GetDirectoryName(System.IO.Path.GetDirectoryName(Application.StartupPath)) + "\\Media\\";//BIẾN TOÀN CỤC LƯU ĐƯỜNG DẪN ĐẾN THƯ MỤC LƯU APP BÀI LÀM NÀY: string apppath = "C:\\Users\\TRIKHANGPC\\Downloads\\Học\\Lập trình kế toán\\G107NTKSlrHifriendz\\G107NTKSlrHF\\Media"; 
        public Fr2QlDmNsHF()
        {
            InitializeComponent();
        }

        private void Fr2QlDmNsHF_Load(object sender, EventArgs e)
        {
            this.dMCVTableAdapter.Fill(this.g107NTKSalaHFDsDMCV.DMCV);
            this.dMTDTableAdapter.Fill(this.g107NTKSalaHFDsDMTD.DMTD);
            this.dMCMTableAdapter.Fill(this.g107NTKSalaHFDsDMCM.DMCM);
            this.dMBPTableAdapter.Fill(this.g107NTKSalaHFDsDMBP.DMBP);
            comboBoxDMBP_SelectedIndexChanged(sender, e);
        }

        private void comboBoxDMBP_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                this.dMNSHFTableAdapter.Fill(this.g107NTKSalaHFDsDMNS.DMNSHF, comboBoxDMBP.SelectedValue.ToString());
            }
            catch (Exception) { }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt thoát không (Y/N)?", "Xác nhận",
                                               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt đóng màn hình này, về Màn hình chinh (Y/N)?",
                      "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                this.Close();
            }
        }

        /// <summary>
        /// XỬ LÝ CHỌN HÌNH (THÊM, SỬA) = CHỌN HÌNH MẪU CHO NHÂN SỰ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 
        static string imagechoose = "";//Biến toàn cục Lưu tên file hình mà NSD đã chọn (Thêm/Sửa) đối với PictureBox
        private void ChonHinh(object sender, EventArgs e)
        {
            DialogResult ch = openFileDialogHinh.ShowDialog();//Mở hộp thoại cho phép NSD chọn hình cho sản phẩm
            if (ch == DialogResult.OK)//NSD đồng ý với hình đã chọn
            {
                //1. Lưu tên file của hình vừa copy nêu trên vào biến toàn cục để sau này (Thêm/Sửa) sẽ cập nhật vào 2 thuộc tính hinh(Win Acc) và hinhweb(của Web) trong Table MH của DB
                imagechoose = System.IO.Path.GetFileName(openFileDialogHinh.FileName);//chỉ lấy tên file ko lấy đường dẫn
                //2. Copy hình vừa chọn vào thư mục hình Media của App (để sau này Copy App đi nơi khác thư mục hình sẽ tự đi theo)
                try
                {
                    System.IO.File.Copy(openFileDialogHinh.FileName, apppath + imagechoose, true);
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sao chép hình vào thư mục của App" + ex.Message); }
            }
            //MessageBox.Show(imagechoose);  // chỉ viết để thực nghiệm (sau này Khóa lại)

        }//private void ChonHinh(object sender, EventArgs e)

        /// <summary>
        /// THÊM NHÂN SỰ HIFRIENDZ MỚI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnThem_Click(object sender, EventArgs e)
        {
            //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC THAY ĐỔI CÁC TEXTBOX THÔNG TIN MẶT HÀNG
                txtmsns.Enabled = !txtmsns.Enabled;
                txttenns.Enabled = !txttenns.Enabled;
                txtsdt.Enabled = !txtsdt.Enabled;
                richtxtTTkhac.Enabled = !richtxtTTkhac.Enabled;
                cbNu.Enabled = !cbNu.Enabled;
                dateTimePickerNgaySinh.Enabled = !dateTimePickerNgaySinh.Enabled;
                dateTimePickerNgayTuyen.Enabled = ! dateTimePickerNgayTuyen.Enabled;
                comboBoxCM.Enabled = !comboBoxCM.Enabled;
                comboBoxCV.Enabled = !comboBoxCV.Enabled;
                comboBoxTD.Enabled = !comboBoxTD.Enabled;
                //khóa các nút lệnh khác (ngoại trừ được Đóng form)
                btnSua.Enabled = !btnSua.Enabled;
                btnXoa.Enabled = !btnXoa.Enabled;
                btnExit.Enabled = !btnExit.Enabled;
                if (btnThem.Text == "Tuyển dụng nhân sự mới")//CHUẨN BỊ THÊM MH
                {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH CHO SP MỚI
                    pictureBoxHinh.ImageLocation = apppath + "ImageChoose.png";
                    //hiện hình ảnh thông báo NSD chọn hình
                    pictureBoxHinh.Click += new EventHandler(ChonHinh);
                    // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                    //XÓA CÁC Ô TEXTBOX TRONG CHI TIẾT Ở BÊN PHẢI ĐỂ CHUẨN BỊ CHO NSD NHẬP THÔNG TIN SP MỚI
                    txtmsns.Text = "";
                    txttenns.Text = "";
                    txtsdt.Text = "";
                    richtxtTTkhac.Text = "";
                    btnThem.Text = "Lưu (Thêm)";
                    //đổi nhãn Thêm => Lưu (sau khi NSD đã nhập đủ các thông tin MH mới)
                }
                else //THÊM MH MỚI VÀO DATABASE VÀ HIỆN LÊN DATAGRIDVIEW
                {
                    //1. THÊM SP MỚI VÀO DB 
                    try{//nếu NSD ko chọn hình thì biến toàn cục imagechoose = "" và có nghĩa là SP mới chưa có hình ảnh & ComboBox...ValueMenber = msnhom
                        dMNSHFTableAdapter.Insert(txtmsns.Text.Trim(), txttenns.Text, cbNu.Checked, dateTimePickerNgaySinh.Text, dateTimePickerNgayTuyen.Text, txtsdt.Text, richtxtTTkhac.Text, apppath + imagechoose, comboBoxCM.SelectedValue.ToString(), comboBoxTD.SelectedValue.ToString(), comboBoxDMBP.SelectedValue.ToString(), comboBoxCV.SelectedValue.ToString());
                        MessageBox.Show("THÊM XONG, XEM ĐI");
                    }catch(System.Exception ex) { MessageBox.Show("CÓ LỖI KHI THÊM SP MỚI " + ex.Message); }

                    //2. TẢI LẠI DL SAU KHI THÊM SP MỚI TỪ DB LÊN DATAGRIDWIEW ĐỂ NSD BIẾT KQ 
                    comboBoxDMBP_SelectedIndexChanged(sender, e);
                    //3. THAY ĐỔI TRANG THÁI THÊM SP MỚI
                    //pictureBoxHinh.Click -= pictureBoxHinh_Click;//KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                    pictureBoxHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình
                    btnThem.Text = "Tuyển dụng nhân sự mới";//đổi nhãn trả lại Lưu => Thêm (thêm thêm mới NS khác)
                }

            }//private void btnThem_Click(object sender, EventArgs e)   

        private void btnSua_Click(object sender, EventArgs e)
        {
            //B1: ĐÓNG _ MỞ : ĐƯỢC PHÉP HAY KHÔNG ĐƯỢC SỬA
            txtmsns.Enabled = !txtmsns.Enabled;
            txttenns.Enabled = !txttenns.Enabled;
            txtsdt.Enabled = !txtsdt.Enabled;
            richtxtTTkhac.Enabled = !richtxtTTkhac.Enabled;
            cbNu.Enabled = !cbNu.Enabled;
            dateTimePickerNgaySinh.Enabled = !dateTimePickerNgaySinh.Enabled;
            dateTimePickerNgayTuyen.Enabled = !dateTimePickerNgayTuyen.Enabled;
            comboBoxCM.Enabled = !comboBoxCM.Enabled;
            comboBoxCV.Enabled = !comboBoxCV.Enabled;
            comboBoxTD.Enabled = !comboBoxTD.Enabled;
            //khóa các nút lệnh khác (ngoại trừ được Đóng form)
            btnThem.Enabled = !btnThem.Enabled;
            btnXoa.Enabled = !btnXoa.Enabled;
            btnExit.Enabled = !btnExit.Enabled;
            if (btnSua.Text == "Cập nhật thông tin nhân sự")//Bắt đầu sửa
            {//MỞ CHẾ ĐỘ CHO NSD CHỌN HÌNH MỚI CHO NS
                pictureBoxHinh.ImageLocation = apppath + "ImageChoose.png";
                //hiện hình ảnh thông báo NSD chọn hình
                pictureBoxHinh.Click += new EventHandler(ChonHinh);
                // cho phép NSD click vào PictureBox để chọn hình (Gán Event Click vào PictureBox Hình)
                //B2: HƯỚNG DẪN CÁCH SỬA
                MessageBox.Show("Mọi người SỬA trong các ô Text bên phải, CHỌN LẠI HÌNH BẰNG CÁCH CLICK VÀO HÌNH ĐỂ CHỌN HÌNH MỚI THAY THẾ");

                btnSua.Text = "Lưu (Sửa)";
            }
            else //LƯU SAU KHI SỬA XONG
            {//KIỂM TRA NSD CÓ THAY ĐỔI HÌNH HAY KHÔNG: NẾU CHỌN HÌNH MỚI THÌ THAY; NẾU KHÔNG THÌ GIỮ LẠI HÌNH CŨ
                if (imagechoose == "") imagechoose = pictureBoxHinh.ImageLocation;
                //NSD KHÔNG THAY ĐỔI HÌNH (NÊN giữa lại hình cũ)
                try
                { //B3: lưu DB
                    dMNSHFTableAdapter.Update(txttenns.Text, cbNu.Checked, dateTimePickerNgaySinh.Text, dateTimePickerNgayTuyen.Text, txtsdt.Text, richtxtTTkhac.Text, apppath + imagechoose, txtmsns.Text.Trim());
                    MessageBox.Show("Sửa xong rồi, xem đi !");
                }
                catch (System.Exception ex) { MessageBox.Show("Có lỗi sửa chữa thông tin nhân sự " + ex.Message); }
                //B4: ĐỔI NHÃN 
                btnSua.Text = "Thay đổi thông tin nhân sự";
                pictureBoxHinh.Click -= ChonHinh;
                //KHÔNG CHO NSD click vào PictureBoX hình (Xóa Event Click của PictureBox Hình)
                pictureBoxHinh.ImageLocation = ""; //GỠ BỎ hình ảnh thông báo chọn hình

                //B5: Tải BD lên DataGridView sau khi xóa
                try
                {
                    // Tai ds cac NS vao DataGridView ben duoi theo Nhom MH da chon trong ComboBox phia tren
                    this.dMNSHFTableAdapter.Fill(this.g107NTKSalaHFDsDMNS.DMNSHF,
                                                                comboBoxDMBP.SelectedValue.ToString());
                }
                catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung  dot ngot
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //B1: Hỏi xác nhận 
            DialogResult ch = MessageBox.Show("Thiệt xóa nhân sự có mã " + txtmsns.Text.Trim() + " không(Y / N) ? ", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //B2: XÓA
            if (ch == DialogResult.Yes)
            {
                try
                {
                    dMNSHFTableAdapter.Delete(txtmsns.Text.Trim());
                    MessageBox.Show("Xóa xong rồi, xem đi !");
                }
                catch (System.Exception ex) 
                { 
                    MessageBox.Show("Có lỗi XÓA nhân sự, do còn RÀNG BUỘC TOÀN VẸN DỮ LIỆU: " + "\n\n" + ex.Message);
                    Fr3XlRBTVNs fr = new Fr3XlRBTVNs(txtmsns.Text.Trim(), txttenns.Text);
                    //Gọi form Xl RBTV DL : truyền ms và tên NS cần xóa sang Fr RBTV
                    fr.ShowDialog(); //Mở form XL RBTV lên
                }
            }
            //B3: Tải BD lên DataGridView sau khi xóa
            try
            {
                // Tai ds cac NS vao DataGridView ben duoi theo Bo Phan da chon trong ComboBox phia tren
                this.dMNSHFTableAdapter.Fill(this.g107NTKSalaHFDsDMNS.DMNSHF,
                                                               comboBoxDMBP.SelectedValue.ToString());
            }
            catch (System.Exception) { } //bat moi he thong = tranh truong hop ctr bi dung dot ngot
        }
        private void ChuyenNhom_Click(object sender, EventArgs e)
        {
            Fr4ChuyenNhom fr = new Fr4ChuyenNhom();
            fr.ShowDialog();
        }
    }
}