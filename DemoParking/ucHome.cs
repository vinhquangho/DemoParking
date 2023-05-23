using DemoParking.Dtos;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
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

        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadData(string text, Status? status, TypeTicket? typeTicket)
        {
            _service = new InOutService(new AppDbContext());
            var list = _service.GetAll(text, status, typeTicket);
            dtgMain.DataSource = list;
            dtgMain.Columns["Id"].HeaderText = "Id";
            dtgMain.Columns["Code"].HeaderText = "Biển số xe";
            dtgMain.Columns["DateIn"].HeaderText = "Ngày bất đầu";
            dtgMain.Columns["DateOut"].HeaderText = "Ngày kết thúc";
            dtgMain.Columns["IsTicket"].HeaderText = "Vé tháng";
            dtgMain.Columns["Status"].HeaderText = "Trạng thái";
            dtgMain.Columns["EmployeeName"].HeaderText = "Nhân viên đăng ký";

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
    }
}
