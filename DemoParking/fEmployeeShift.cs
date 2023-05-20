using DemoParking.Dtos.EmployeeShift;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class fEmployeeShift : Form
    {
        EmployeeService _employeeService = new EmployeeService(new AppDbContext());
        ShiftService _shiftService = new ShiftService(new AppDbContext());
        EmployeeShiftService _employeeShiftService = new EmployeeShiftService(new AppDbContext());
        int _id;
        public fEmployeeShift(int id)
        {
            _id = id;
            InitializeComponent();
            LoadCbbEmployee();
            LoadDataGrid(id);
        }
        private void LoadCbbEmployee()
        {
            var list = _employeeService.GetForCombobox();
            cbbEmployee.DataSource = list;
            cbbEmployee.DisplayMember = "Name";
            cbbEmployee.ValueMember = "Id";
        }
        private void LoadDataGrid(int id)
        {
            var list = _employeeShiftService.GetByShiftId(id);
            dgvMain.DataSource = list;
            dgvMain.Columns["Id"].HeaderText = "Id";
            dgvMain.Columns["ShiftName"].HeaderText = "Tên ca trực";
            dgvMain.Columns["EmployeeName"].HeaderText = "Tên nhân viên";
            if (dgvMain.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dgvMain.Columns.Insert(3, btnDelete);
            }
            dgvMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            var valueEmployee = (int)cbbEmployee.SelectedValue;
            var result = _employeeShiftService.Create(new EmployeeShift() { EmployeeId = valueEmployee, ShiftId = _id });
            if (!result)
                MessageBox.Show("Đã có nhân viên này trong ca trực", "Thông báo");
            else
                LoadDataGrid(_id);
        }

        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dgvMain.DataSource as List<ViewDto>)[e.RowIndex];

            switch (dgvMain.Columns[e.ColumnIndex].Name)
            {
                case "btnDelete":
                    var textDelete = _employeeShiftService.Delete(data.Id) == true ? "Xóa nhân viên từ ca trực thành công" : "Xóa nhân viên từ ca trực thất bại";
                    MessageBox.Show(textDelete, "Thông báo");
                    LoadDataGrid(_id);
                    break;
                default:
                    break;
            }
        }
    }
}
