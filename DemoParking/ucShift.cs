using DemoParking;
using DemoParking.Dtos.Shift;
using DemoParking.EntityFramework;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucShift : UserControl
    {
        ShiftService _service = new ShiftService(new AppDbContext());
        public ucShift()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new fShift(null);
            form.FormClosing += formClosing;
            form.ShowDialog();
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            _service = new ShiftService(new AppDbContext());
            var list = _service.GetAll();
            dtgMain.DataSource = list;
            dtgMain.Columns["Id"].HeaderText = "Id";
            dtgMain.Columns["Name"].HeaderText = "Tên ca trực";
            dtgMain.Columns["HourStart"].HeaderText = "Giờ bất đầu";
            dtgMain.Columns["HourEnd"].HeaderText = "Giờ kết thúc";
            dtgMain.Columns["Price"].HeaderText = "Số tiền cần trả";

            if (dtgMain.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(5, btnUpdate);
            }

            if (dtgMain.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(6, btnDelete);
            }

            if (dtgMain.Columns["btnAddEmployee"] == null)
            {
                DataGridViewButtonColumn btnReset = new DataGridViewButtonColumn();
                btnReset.Text = "Thêm nhân viên";
                btnReset.Name = "btnAddEmployee";
                btnReset.HeaderText = string.Empty;
                btnReset.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(7, btnReset);
            }
            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dtgMain.DataSource as List<ViewDto>)[e.RowIndex];

            switch (dtgMain.Columns[e.ColumnIndex].Name)
            {
                // nếu nhân vào nút cập nhật
                case "btnUpdate":
                    var form = new fShift(data.Id);
                    form.FormClosing += formClosing;
                    form.ShowDialog();
                    break;
                // nếu nhân vào nút xóa
                case "btnDelete":
                    var textDelete = _service.Delete(data.Id) == true ? "Xóa ca trực thành công" : "Xóa ca trực thất bại";
                    MessageBox.Show(textDelete, "Thông báo");
                    LoadData();
                    break;
                // nếu nhân vào nút reset
                case "btnAddEmployee":
                    var formEmployeeShift = new fEmployeeShift(data.Id);
                    formEmployeeShift.ShowDialog();
                    break;
                default:
                    break;
            }
        }
    }
}
