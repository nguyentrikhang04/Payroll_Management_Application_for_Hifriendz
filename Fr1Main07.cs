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
    public partial class Fr1Main07 : Form
    {
        public Fr1Main07()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form.._Load: TỰ ĐỘNG CHẠY MỖI KHI FORM NÀY ĐƯỢC MỞ LÊN
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Fr1Main07_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Payroll Accounting Software compiled by Nguyễn Trí Khang, 07, 2221004196, FDS, UFM, 2024");
            lbDate.Text = "Ngày hôm nay: " + System.DateTime.Now.ToShortDateString();
        }//private void Fr1Main07_Load(object sender, EventArgs e)

        /// <summary>
        /// THOÁT CHƯƠNG TRÌNH
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult ch = MessageBox.Show("Thiệt thoát không (Y/N)?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ch == DialogResult.Yes)
            {
                Application.Exit(); // this.Close();
            }
        }//private void thoátKhỏiChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)

        /// <summary>
        /// NHẢY ĐỒNG HỒ
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void timer1_Tick(object sender, EventArgs e)
        {
                lbTime.Text = "Giờ hiện tại: " + System.DateTime.Now.ToLongTimeString(); //lấy giờ hệ thống Now... gán bào Label DongHo
        }//private void timer1_Tick(object sender, EventArgs e)

        /// <summary>
        /// GỌI FORM QUẢN LÝ DANH MỤC
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void danhMụcNhânSựMenuStrip_Click(object sender, EventArgs e)
        {
            Fr2QlDmNsHF fr = new Fr2QlDmNsHF();
            fr.ShowDialog();
        }//private void dANHMỤCTRÌNHĐỘToolStripMenuItem_Click(object sender, EventArgs e)

        private void ChuyenNhom_Click(object sender, EventArgs e)
        {
            Fr4ChuyenNhom fr = new Fr4ChuyenNhom();
            fr.ShowDialog();

        }


    }//public partial class Fr1Main07 : Form
}//namespace G107NTKSlrHF