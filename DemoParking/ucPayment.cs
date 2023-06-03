using DemoParking.Dtos;
using DemoParking.EntityFramework;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucPayment : UserControl
    {
        PaymentService _service = new PaymentService(new AppDbContext());
        public ucPayment()
        {
            InitializeComponent();
            loadDataCombobox();
            LoadData(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1), null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var isTicketMonth = (int)cbbTicketMonth.SelectedValue == 1 ? true : false;
            LoadData(dtpFrom.Value, dtpTo.Value, isTicketMonth);
        }
        private void loadDataCombobox()
        {
            var list = new List<SelectDto>()
            {
                new SelectDto(){ Id = 1, Name = "Vé tháng" },
                new SelectDto(){ Id = 2, Name = "không phải vé tháng" },
            };
            cbbTicketMonth.DataSource = list;
            cbbTicketMonth.DisplayMember = "Name";
            cbbTicketMonth.ValueMember = "Id";
        }
        private void LoadData(DateTime dateFrom, DateTime dateTo, bool? isTicketMonth)
        {
            _service = new PaymentService(new AppDbContext());
            var list = _service.GetAll(dateFrom, dateTo, isTicketMonth);
            dtgMain.DataSource = list;
            dtgMain.Columns["Code"].HeaderText = "Biển số xe";
            dtgMain.Columns["Price"].HeaderText = "Gía tiền";
            dtgMain.Columns["EmployeeName"].HeaderText = "Nhân viên tạo";
            dtgMain.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dtgMain.Columns["IsTicketMonth"].HeaderText = "Vé tháng";
            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
