using DemoParking;
using DemoParking.Dtos;
using DemoParking.Dtos.Ticket;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucTicket : UserControl
    {
        private TicketService _service = new TicketService(new AppDbContext());
        public ucTicket()
        {
            InitializeComponent();
            LoadDataGrid(string.Empty, null);
            LoadComboboxTypeTicket();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new fTicket(null);
            form.FormClosing += formClosing;
            form.ShowDialog();
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            LoadDataGrid(string.Empty, null);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var selectType = (TypeTicket)ccbTicket.SelectedValue;
                LoadDataGrid(txtSearch.Text, selectType);
            }
        }

        private void ccbTicket_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var selectType = (TypeTicket)ccbTicket.SelectedValue;
                LoadDataGrid(txtSearch.Text, selectType);
            }
            catch(Exception ex)
            {
                LoadDataGrid(string.Empty, null);
            }
        }
        public void LoadDataGrid(string text, TypeTicket? status)
        {
            _service = new TicketService(new AppDbContext());
            var list = _service.GetAll(text, status);
            dtgMain.DataSource = list;
            dtgMain.Columns["Id"].HeaderText = "Id";
            dtgMain.Columns["Code"].HeaderText = "Biển số xe";
            dtgMain.Columns["Name"].HeaderText = "Tên người đăng ký";
            dtgMain.Columns["StartDate"].HeaderText = "Ngày bất đầu";
            dtgMain.Columns["EndDate"].HeaderText = "Ngày kết thúc";
            dtgMain.Columns["Price"].HeaderText = "Giá";
            dtgMain.Columns["TypeTicket"].HeaderText = "Loại vé";
            dtgMain.Columns["Status"].HeaderText = "Trạng thái";
            dtgMain.Columns["EmployeeName"].HeaderText = "Nhân viên đăng ký";

            if (dtgMain.Columns["btnUpdate"] == null)
            {
                DataGridViewButtonColumn btnUpdate = new DataGridViewButtonColumn();
                btnUpdate.Text = "Sửa";
                btnUpdate.Name = "btnUpdate";
                btnUpdate.HeaderText = string.Empty;
                btnUpdate.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(9, btnUpdate);
            }
            // add nút xóa vào datagridview
            if (dtgMain.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(10, btnDelete);
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
                    var form = new fTicket(data.Id);
                    form.FormClosing += formClosing;
                    form.ShowDialog();
                    break;
                // nếu nhân vào nút xóa
                case "btnDelete":
                    var textDelete = _service.Delete(data.Id) == true ? "Xóa vé thành công" : "Xóa vé thất bại";
                    MessageBox.Show(textDelete, "Thông báo");
                    LoadDataGrid(string.Empty, null);
                    break;

                default:
                    break;
            }
        }
        private void LoadComboboxTypeTicket()
        {
            var result = new List<SelectDto>()
            {
                new SelectDto(){ Id = 1, Name = "Xe Đạp" },
                new SelectDto(){ Id = 2, Name = "2 bánh" },
                new SelectDto(){ Id = 3, Name = "4 bánh" },
                new SelectDto(){ Id = 4, Name = "8 bánh" },
                new SelectDto(){ Id = 5, Name = "16 bánh" },
            };
            ccbTicket.DataSource = result;
            ccbTicket.DisplayMember = "Name";
            ccbTicket.ValueMember = "Id";
        }
    }
}
