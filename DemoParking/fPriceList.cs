using DemoParking.Dtos;
using DemoParking.EntityFramework;
using DemoParking.Models;
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
using System.Xml.Linq;

namespace DemoParking
{
    public partial class fPriceList : Form
    {
        PriceListService _service = new PriceListService(new AppDbContext());
        PriceList priceList { get; set; }
        private int _id;
        public fPriceList(int? id)
        {
            InitializeComponent();
            LoadComboboxTypeTicket();
            if (id.HasValue)
            {
                _id = id.Value;
                var model = _service.GetById(id.Value);
                dtpStart.Value = model.DateIn;
                dtpEnd.Value = model.DateOut;
                txtPrice.Value = model.Price;
                txtId.Text = model.Id.ToString();
                ccbTypeTicket.SelectedValue = (int)model.TypeTicket;
                priceList = model;
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
            ccbTypeTicket.DataSource = result;
            ccbTypeTicket.DisplayMember = "Name";
            ccbTypeTicket.ValueMember = "Id";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = new PriceList()
            {
                DateIn = dtpStart.Value,
                DateOut = dtpEnd.Value,
                Price = txtPrice.Value,
                TypeTicket = (TypeTicket)ccbTypeTicket.SelectedValue
            };
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                model.Id = int.Parse(txtId.Text);
                var result = _service.Update(model);
                if (!result)
                {
                    MessageBox.Show("Cập nhật phí gửi xe không thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                var result = _service.Create(model);
                if (!result)
                {
                    MessageBox.Show("Thêm mới phí gửi xe không thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            this.Close();
        }
    }
}
