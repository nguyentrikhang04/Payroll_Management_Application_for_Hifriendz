using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace G107NTKSlrHF
{
    public partial class Fr4ChuyenNhom : Form
    {
        public Fr4ChuyenNhom()
        {
            InitializeComponent();
        }

        private void FrChuyenNhom_Load(object sender, EventArgs e)
        {
            //Tải 2 Danh mục BP lên 2 ComboBox (S, D)
            this.dMBPTableAdapterS.Fill(this.g107NTKSalaHFDsDmbpS.DMBP);
            this.dMBPTableAdapterD.Fill(this.g107NTKSalaHFDsDmbpD.DMBP);
            //Tải 2 danh mục nhân sự hifriendz lên 2 ListBox (S, D) theo danh mục bộ phận tương ứng đã chon
            try
            {
                this.dMNSHFTableAdapterS.Fill(this.g107NTKSalaHFDsDmnsHfS.DMNSHF, comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.dMNSHFTableAdapterD.Fill(this.g107NTKSalaHFDsDmnsHfD.DMNSHF, comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        //CHỌN LẠI NHÓM BÊN: NGUỒN (S) = CHỌN LẠI NHÓM BÊN NGUỒN (SOURCE) : L
        private void comboBoxS_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nếu 2 Combobox Nhóm [Bên Source: Left] và [Bên Destination: Right] GIỐNG NHAU: KHÔNG CÓ GÌ ĐỂ CHUYỂN NHÓM
            if (comboBoxS.SelectedValue.ToString().Trim() == comboBoxD.SelectedValue.ToString().Trim())
            //GIỐNG NHAU
            {//Không có gì để Chuyển Nhóm 
                btnLR.Enabled = false;
                btnRL.Enabled = false;
                btnALR.Enabled = false;
                btnARL.Enabled = false;
                MessageBox.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.");
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxS);
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxD);
            }
            else// 2 Combobox Nhóm đã chọn Khác nhau: Chuyển nhóm được 
            {//chuyển nhóm được
                btnLR.Enabled = true;
                btnRL.Enabled = true;
                btnALR.Enabled = true;
                btnARL.Enabled = true;
                toolTip1.Show("", comboBoxS);
                toolTip1.Show("", comboBoxD);
            }

            //tải lại Dữ liệu trên ListBox sau khi chọn Combobox Nhóm [Bên Source: Left]
            try
            {
                dMNSHFTableAdapterS.Fill(this.g107NTKSalaHFDsDmnsHfS.DMNSHF,
                                                        comboBoxS.SelectedValue.ToString().Trim());
                
            }
            catch (System.Exception) { }


        }


        //CHỌN LẠI NHÓM BÊB: ĐÍCH (d) (DESTINATION) : R
        private void comboBoxD_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Nếu 2 Combobox Nhóm [Bên Source: Left] và [Bên Destination: Right] GIỐNG NHAU: KHÔNG CÓ GÌ ĐỂ CHUYỂN NHÓM
            if (comboBoxS.SelectedValue.ToString().Trim() == comboBoxD.SelectedValue.ToString().Trim())
            //GIỐNG NHAU
            {//Không có gì để Chuyển Nhóm 
                btnLR.Enabled = false;
                btnRL.Enabled = false;
                btnALR.Enabled = false;
                btnARL.Enabled = false;
                MessageBox.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.");
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxS);
                toolTip1.Show("Phải chọn 2 Nhóm khác nhau thì mới Chuyển nhóm được.", comboBoxD);
            }
            else// 2 Combobox Nhóm đã chọn Khác nhau: Chuyển nhóm được 
            {//chuyển nhóm được
                btnLR.Enabled = true;
                btnRL.Enabled = true;
                btnALR.Enabled = true;
                btnARL.Enabled = true;
                toolTip1.Show("", comboBoxS);
                toolTip1.Show("", comboBoxD);
            }

            //tải lại Dữ liệu trên ListBox sau khi chọn Combobox Nhóm [Bên Destination: Right]
            try
            {
                this.dMNSHFTableAdapterD.Fill(this.g107NTKSalaHFDsDmnsHfD.DMNSHF,
                                                     comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        //VỀ MÀN HÌNH  (ĐÓNG MÀN HÌNH CHUYỂN NHÓM)
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt đóng không (Y/N)?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes) { this.Close(); }
        }

        //THOÁT TOÀN BỘ CHƯƠNG TRÌNH
        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt đóng không (Y/N)?", "Xác nhận",
                                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes) { Application.Exit(); }
        }

        //CHUYỂN 1 NS TỪ NHÓM S (L) => NHÓM D (R)
        private void btnLR_Click(object sender, EventArgs e)
        {
            //B1: Chuyển NS từ Nhóm S sang Nhóm D;
            try
            {
                dMNSHFTableAdapterS.Update(comboBoxD.SelectedValue.ToString().Trim(),
                                                listBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển 1 MH L=>R" + ex.Message); }

            //B2: Tải 2 danh sách NS lên 2 ListBox (S, D) theo Bộ phận tương ứng đã chon
            try
            {
                this.dMNSHFTableAdapterS.Fill(this.g107NTKSalaHFDsDmnsHfS.DMNSHF,
                                                    comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.dMNSHFTableAdapterD.Fill(this.g107NTKSalaHFDsDmnsHfD.DMNSHF,
                                                      comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        //CHUYỂN 1 NS TỪ NHÓM D (R) => NHÓM S (L)
        private void btnRL_Click(object sender, EventArgs e)
        {
            //B1: Chuyển NS từ Nhóm D sang Nhóm S;
            try
            {
                dMNSHFTableAdapterD.Update(comboBoxS.SelectedValue.ToString().Trim(),
                                                 listBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển 1 MH R=>L" + ex.Message); }
            //B2: Tải 2 danh sách NS lên 2 ListBox (S, D) theo Bộ phận tương ứng đã chon
            try
            {
                this.dMNSHFTableAdapterS.Fill(this.g107NTKSalaHFDsDmnsHfS.DMNSHF,
                                                    comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.dMNSHFTableAdapterD.Fill(this.g107NTKSalaHFDsDmnsHfD.DMNSHF,
                                                      comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        /// <summary>
        /// CHUYỂN TẤT CẢ NS TỪ NHÓM S (L) => NHÓM D (R)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnALR_Click(object sender, EventArgs e)
        {
            //B1: Chuyển Tất cả NS từ Nhóm S sang Nhóm D;
            try
            {
                dMNSHFTableAdapterS.UpdateQuery(comboBoxD.SelectedValue.ToString().Trim(),
                                                    comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển tất cả các NS L=>R" + ex.Message); }
            //B2: Tải 2 danh sách NS lên 2 ListBox (S, D) theo Bộ phận tương ứng đã chon
            try
            {
                this.dMNSHFTableAdapterS.Fill(this.g107NTKSalaHFDsDmnsHfS.DMNSHF,
                                                    comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.dMNSHFTableAdapterD.Fill(this.g107NTKSalaHFDsDmnsHfD.DMNSHF,
                                                      comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }

        /// <summary>
        /// CHUYỂN TẤT CẢ NS TỪ NHÓM D (R) => NHÓM S (L)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnARL_Click(object sender, EventArgs e)
        {
            //B1: Chuyển Tất cả NS từ Nhóm D sang Nhóm S;
            try
            {
                dMNSHFTableAdapterD.UpdateQuery(comboBoxS.SelectedValue.ToString().Trim(),
                                                       comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception ex) { MessageBox.Show("Có lỗi chuyển tất cả các NS R=>L" + ex.Message); }

            //B2: Tải 2 danh sách NS lên 2 ListBox (S, D) theo Bộ phận tương ứng đã chon
            try
            {
                this.dMNSHFTableAdapterS.Fill(this.g107NTKSalaHFDsDmnsHfS.DMNSHF,
                                                    comboBoxS.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
            try
            {
                this.dMNSHFTableAdapterD.Fill(this.g107NTKSalaHFDsDmnsHfD.DMNSHF,
                                                      comboBoxD.SelectedValue.ToString().Trim());
            }
            catch (System.Exception) { }
        }
    }
}
