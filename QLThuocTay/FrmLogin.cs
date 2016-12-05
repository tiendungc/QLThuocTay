using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLThuocTay
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnTh_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        QLTHUOCTAYDataContext context = new QLTHUOCTAYDataContext();
        private void btnDn_Click(object sender, EventArgs e)
        {

            var result = (from LOGIN in context.LOGINs
                         where LOGIN.USERNAME == txtTK.Text && LOGIN.Password == txtMk.Text
                         select LOGIN).SingleOrDefault();

            if (result == null)
                MessageBox.Show("Tài khoản hoặc mật khẩu không đúng! ");
            else
            {
                if (string.Compare(result.AUTHORICATION, "admin")==1)
                {
                    MessageBox.Show("đăng nhập' "+result.AUTHORICATION+"'thành công\nđang lấy thông tin nhân vật!");
                }
                else
                {
                    MessageBox.Show("đăng nhập'"+ result.AUTHORICATION+"' thành công\nđang lấy thông tin nhân vật!");
                }
               
                this.Hide();
                Application.Exit();
            }

        }

      

    

       
       
        
    }
}
