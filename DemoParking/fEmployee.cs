using DemoParking.Dtos;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class fEmployee : Form
    {
        EmployeeService _employeeService = new EmployeeService(new AppDbContext());
        Employee employee { get; set; }
        public fEmployee(int? id)
        {
            InitializeComponent();
            if (id.HasValue) // nếu id có giá trị nó là cập nhật
            {
                var model = _employeeService.GetById(id.Value);
                if (model != null)
                {
                    employee = model;
                    txtCode.Text = model.Code;
                    txtName.Text = model.Name;
                    txtAddress.Text = model.Address;
                    txtPhone.Text = model.Phone;
                    txtUserName.Text = model.UserName;
                    txtPassword.Text = model.Password;
                    dtpBirthDay.Value = model.BirthDay;
                    ddlStatus.SelectedValue = (int)model.Status;
                    txtId.Text = model.Id.ToString();
                }
            }
        }

        private void fEmployee_Load(object sender, EventArgs e)
        {
            // load combobx dataSource
            var ccbDataSource = new List<SelectDto>()
            {
                new SelectDto(){ Id = 1 , Name = "Đang hoạt động"},
                new SelectDto(){ Id = 2 , Name = "Ngừng hoạt động"}
            };
            ddlStatus.DataSource = ccbDataSource;
            ddlStatus.DisplayMember = "Name";
            ddlStatus.ValueMember = "Id";
        }
        private void ValidateTextBox(TextBox txt, string message, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
                errorTextBox.SetError(txt, message);
            }
            else
            {
                e.Cancel = false;
                errorTextBox.SetError(txt, "");
            }
        }
        private void txtCode_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtCode, "Vui lòng nhập mã nhân viên!", e);
        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtName, "Vui lòng nhập tên nhân viên!", e);
        }

        private void txtUserName_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtUserName, "Vui lòng nhập tên tài khoản!", e);
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtPassword, "Vui lòng nhập mật khẩu!", e);
        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtAddress, "Vui lòng nhập địa chỉ", e);
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            ValidateTextBox(txtPhone, "Vui lòng nhập số điện thoại!", e);
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var model = new Employee()
                {
                    Code = txtCode.Text,
                    Name = txtName.Text,
                    Address = txtAddress.Text,
                    Phone = txtPhone.Text,
                    Status = (Status)int.Parse(ddlStatus.SelectedValue.ToString()),
                    UserName = txtUserName.Text,
                    Password = txtPassword.Text,
                    BirthDay = dtpBirthDay.Value
                };
                if (!string.IsNullOrEmpty(txtId.Text)) // nếu id có giá trị nó là cập nhật
                {
                    model.Id = int.Parse(txtId.Text);
                    model.CreationTime = employee.CreationTime;
                    var result = _employeeService.Update(model);
                    if (!result)
                    {
                        MessageBox.Show("Cập nhật không thành công mã hoặc tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }
                else // nếu  id không có giá trị nó là tạo mới
                {
                    var result = _employeeService.Create(model);
                    if (!result)
                    {
                        MessageBox.Show("Thêm mới không thành công mã hoặc tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK);
                        return;
                    }
                }

                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
