using DemoParking.EntityFramework;
using DemoParking.Services;
using System;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucPayment : UserControl
    {
        PaymentService _service = new PaymentService(new AppDbContext());
        public ucPayment()
        {
            InitializeComponent();
            LoadData(DateTime.Now.AddMonths(-1), DateTime.Now.AddMonths(1));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadData(dtpFrom.Value, dtpTo.Value);
        }
        private void LoadData(DateTime dateFrom, DateTime dateTo)
        {
            _service = new PaymentService(new AppDbContext());
            var list = _service.GetAll(dateFrom, dateTo);
            dtgMain.DataSource = list;
            dtgMain.Columns["Code"].HeaderText = "Biển số xe";
            dtgMain.Columns["Price"].HeaderText = "Gía tiền";
            dtgMain.Columns["EmployeeName"].HeaderText = "Nhân viên tạo";
            dtgMain.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
