using DemoParking;
using DemoParking.Dtos;
using DemoParking.Dtos.Employee;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucEmployee : UserControl
    {
        EmployeeService _employeeService = new EmployeeService(new AppDbContext());
        public ucEmployee()
        {
            InitializeComponent();
            LoadDataGrid(string.Empty, null);
            LoadCombobox();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new fEmployee(null);
            form.FormClosing += formEmployeeClosing;
            form.ShowDialog();
        }
        private void formEmployeeClosing(object sender, FormClosingEventArgs args)
        {
            LoadDataGrid(string.Empty, null);
        }
        // hiển thị dữ liệu cho combobox trạng thái
        public void LoadCombobox()
        {
            var ccbDataSource = new List<SelectDto>()
            {
                new SelectDto(){ Id = 1 , Name = "Đang hoạt động"},
                new SelectDto(){ Id = 2 , Name = "Ngừng hoạt động"}
            };
            cbbStatus.DataSource = ccbDataSource;
            cbbStatus.DisplayMember = "Name";
            cbbStatus.ValueMember = "Id";
        }

        // hiển thị danh sách nhân viên lên datagridview
        public void LoadDataGrid(string text, Status? status)
        {
            var list = _employeeService.GetAll(text, status);
            dtgMain.DataSource = list;
            dtgMain.Columns["Id"].HeaderText = "Id";
            dtgMain.Columns["Code"].HeaderText = "Mã Nhân viên";
            dtgMain.Columns["Name"].HeaderText = "Tên nhân viên";
            dtgMain.Columns["Address"].HeaderText = "Địa chỉ";
            dtgMain.Columns["Phone"].HeaderText = "Só điện thoại";
            dtgMain.Columns["Status"].HeaderText = "Trạng thái";
            dtgMain.Columns["UserName"].HeaderText = "Tài khoản";
            dtgMain.Columns["BirthDay"].HeaderText = "Ngày sinh";

            // add nút cập nhạt vào datagirdview
            if (dtgMain.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(8, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dtgMain.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(9, btnDelete);
            }
            // add nút reset password vào datagridview
            if (dtgMain.Columns["btnReset"] == null)
            {
                DataGridViewButtonColumn btnReset = new DataGridViewButtonColumn();
                btnReset.Text = "Reset";
                btnReset.Name = "btnReset";
                btnReset.HeaderText = string.Empty;
                btnReset.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(10, btnReset);
            }
            // full width datagrid
            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var data = (dtgMain.DataSource as List<ViewDto>)[e.RowIndex];

            switch (dtgMain.Columns[e.ColumnIndex].Name)
            {
                // nếu nhân vào nút cập nhật
                case "btnUpdate":
                    var form = new fEmployee(data.Id);
                    form.FormClosing += formEmployeeClosing;
                    form.ShowDialog();
                    break;
                // nếu nhân vào nút xóa
                case "btnDelete":
                    var textDelete = _employeeService.Delete(data.Id) == true ? "Xóa nhân viên thành công" : "Xóa nhân viên thất bại";
                    MessageBox.Show(textDelete, "Thông báo");
                    LoadDataGrid(string.Empty, null);
                    break;
                // nếu nhân vào nút reset
                case "btnReset":
                    var textReset = _employeeService.Reset(data.Id);
                    MessageBox.Show(textReset, "Thông báo");
                    LoadDataGrid(string.Empty, null);
                    break;
                default:
                    break;
            }
        }
        // sự kiện change combobox trạng thái
        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Status? status = null;
            switch (cbbStatus.SelectedIndex)
            {
                // nếu chọn đang hoạt động
                case 0:
                    status = Status.Active; break;
                // nếu chọn ngừng hoạt động
                case 1:
                    status = Status.DeActive; break;
                default:
                    break;
            }
            LoadDataGrid(txtSearch.Text, status);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            // nếu nhấn nút enter thì chạy
            if (e.KeyCode == Keys.Enter)
            {
                Status? status = null;
                switch (cbbStatus.SelectedIndex)
                {
                    case 0:
                        status = Status.Active; break;
                    case 1:
                        status = Status.DeActive; break;
                    default:
                        break;
                }
                LoadDataGrid(txtSearch.Text, status);
            }
        }
    }
}
