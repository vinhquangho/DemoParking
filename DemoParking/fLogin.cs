using DemoParking.EntityFramework;
using DemoParking.Services;
using System;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class fLogin : Form
    {
        EmployeeService _employeeService = new EmployeeService(new AppDbContext());
        public fLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (_employeeService.FindEmployeeByLogin(new DemoParking.Dtos.LoginDto() { Password = txbPassWord.Text, UserName = txbUserName.Text }) == null)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông báo");
                return;
            }
                
            Hide();
            var fmain = new fMain();
            fmain.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
