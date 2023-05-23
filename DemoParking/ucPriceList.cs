using DemoParking.Dtos.PriceList;
using DemoParking.EntityFramework;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class ucPriceList : UserControl
    {
        PriceListService _service = new PriceListService(new AppDbContext());
        public ucPriceList()
        {
            InitializeComponent();
            LoadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var form = new fPriceList(null);
            form.FormClosing += formClosing;
            form.ShowDialog();
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            _service = new PriceListService(new AppDbContext());
            var list = _service.GetAll();
            dtgMain.DataSource = list;
            dtgMain.Columns["Id"].HeaderText = "Id";
            dtgMain.Columns["TypeTicket"].HeaderText = "Loại xe";
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
            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void dtgMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var data = (dtgMain.DataSource as List<ViewDto>)[e.RowIndex];

            switch (dtgMain.Columns[e.ColumnIndex].Name)
            {
                // nếu nhân vào nút cập nhật
                case "btnUpdate":
                    var form = new fPriceList(data.Id);
                    form.FormClosing += formClosing;
                    form.ShowDialog();
                    break;
                // nếu nhân vào nút xóa
                case "btnDelete":
                    var textDelete = _service.Delete(data.Id) == true ? "Xóa phí gửi xe thành công" : "Xóa phí gửi xe thất bại";
                    MessageBox.Show(textDelete, "Thông báo");
                    LoadData();
                    break;
                default:
                    break;
            }
        }
    }
}
