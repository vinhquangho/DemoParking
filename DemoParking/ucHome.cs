using DemoParking.Dtos;
using DemoParking.Dtos.InOut;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucHome : UserControl
    {
        private InOutService _service = new InOutService(new AppDbContext());
        public ucHome()
        {
            InitializeComponent();
            LoadComboboxTypeTicket();
            LoadComboboxStatus();
            LoadData(string.Empty, null, null);
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var form = new fInOut();
            form.FormClosing += formClosing;
            form.ShowDialog();
        }
        private void formClosing(object sender, FormClosingEventArgs args)
        {
            LoadData(string.Empty, null, null);
        }

        private void ccbTicket_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            try
            {
                Status? status = null;
                TypeTicket? typeTicke = null;

                if (cbbStatus.SelectedValue != null)
                    status = (Status?)cbbStatus.SelectedValue;

                if (ccbTypeTicket.SelectedValue != null)
                    typeTicke = (TypeTicket?)ccbTypeTicket.SelectedValue;

                LoadData(txtSearch.Text, status, typeTicke);
            }
            catch (Exception ex)
            {
                LoadData(string.Empty, null, null);
            }
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dtgMain.DataSource as List<ViewDto>)[e.RowIndex];

            switch (dtgMain.Columns[e.ColumnIndex].Name)
            {
                // nếu nhân vào nút cập nhật
                case "btnPayment":
                    if (data.IsTicket)
                    {
                        _service.UpdateInOut(data.Id);
                        LoadData(string.Empty, null, null);
                    }
                    else
                    {
                        var form = new fPayment(data.Id);
                        form.FormClosing += formClosing;
                        form.ShowDialog();
                    }
                    break;
                // nếu nhân vào nút xóa
                case "btnDelete":
                    var textDelete = _service.Delete(data.Id) == true ? "Xóa phiếu thành công" : "Xóa phiếu thất bại";
                    MessageBox.Show(textDelete, "Thông báo");
                    LoadData(string.Empty, null, null);
                    break;
                default:
                    break;
            }
        }
        private void LoadData(string text, Status? status, TypeTicket? typeTicket)
        {
            status = status == 0 ? null : status;
            typeTicket = typeTicket == 0 ? null : typeTicket;
            _service = new InOutService(new AppDbContext());
            var list = _service.GetAll(text, status, typeTicket);
            dtgMain.DataSource = list;
            dtgMain.Columns["Id"].HeaderText = "Id";
            dtgMain.Columns["Code"].HeaderText = "Biển số xe";
            dtgMain.Columns["DateIn"].HeaderText = "Ngày bất đầu";
            dtgMain.Columns["DateOut"].HeaderText = "Ngày kết thúc";
            dtgMain.Columns["IsTicket"].HeaderText = "Vé tháng";
            dtgMain.Columns["Status"].HeaderText = "Trạng thái";
            dtgMain.Columns["EmployeeName"].HeaderText = "Nhân viên tạo";

            // add nút xóa vào datagridview
            if (dtgMain.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                btnDelete.Text = "Xóa";
                btnDelete.Name = "btnDelete";
                btnDelete.HeaderText = string.Empty;
                btnDelete.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(7, btnDelete);
            }

            if (dtgMain.Columns["btnPayment"] == null)
            {
                DataGridViewButtonColumn btnPayment = new DataGridViewButtonColumn();
                btnPayment.Text = "Thanh toán";
                btnPayment.Name = "btnPayment";
                btnPayment.HeaderText = string.Empty;
                btnPayment.UseColumnTextForButtonValue = true;
                dtgMain.Columns.Insert(8, btnPayment);
            }

            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void LoadComboboxTypeTicket()
        {
            var result = new List<SelectDto>()
            {
                new SelectDto(){ Id = 0, Name = "--Chọn loại xe--"},
                new SelectDto(){ Id = 1, Name = "Xe Đạp" },
                new SelectDto(){ Id = 2, Name = "2 bánh" },
                new SelectDto(){ Id = 3, Name = "4 bánh" },
                new SelectDto(){ Id = 4, Name = "8 bánh" },
                new SelectDto(){ Id = 5, Name = "16 bánh" },
            };
            ccbTypeTicket.DataSource = result;
            ccbTypeTicket.DisplayMember = "Name";
            ccbTypeTicket.ValueMember = "Id";
        }
        private void LoadComboboxStatus()
        {
            var result = new List<SelectDto>()
            {
                new SelectDto(){ Id = 0, Name = "--Chọn trạng thái--"},
                new SelectDto(){ Id = 2, Name = "Đã lấy xe" },
                new SelectDto(){ Id = 1, Name = "Chưa lấy xe" },
            };
            cbbStatus.DataSource = result;
            cbbStatus.DisplayMember = "Name";
            cbbStatus.ValueMember = "Id";
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var status = (Status)int.Parse(cbbStatus.SelectedValue.ToString());
                var typeTicket = (TypeTicket)int.Parse(ccbTypeTicket.SelectedValue.ToString());
                LoadData(txtSearch.Text, status, typeTicket);
            }
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var status = (Status)int.Parse(cbbStatus.SelectedValue.ToString());
                var typeTicket = (TypeTicket)int.Parse(ccbTypeTicket.SelectedValue.ToString());
                LoadData(txtSearch.Text, status, typeTicket);
            }
            catch (Exception ex)
            {
                LoadData(string.Empty, null, null);
            }
        }
    }
}
