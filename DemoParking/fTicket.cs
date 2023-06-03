using DemoParking.Dtos;
using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class fTicket : Form
    {
        private TicketService _service = new TicketService(new AppDbContext());
        private InOutService _inOutService = new InOutService(new AppDbContext());
        Ticket ticket { get; set; }
        public fTicket(int? id)
        {
            InitializeComponent();
            LoadComboboxTypeTicket();
            if (id.HasValue)
            {
                var model = _service.GetById(id.Value);
                if(model != null)
                {
                    ticket = model;
                    txtId.Text = model.Id.ToString();
                    txtCode.Text = model.Code;
                    txtName.Text = model.Name;
                    txtPrice.Value = model.Price;
                    dtpEndDate.Value = model.EndDate;
                    dtpStartDate.Value = model.StartDate;
                    ccbTypeTicket.SelectedValue = (int)model.TypeTicket;
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Ticket()
            {
                Code = txtCode.Text,
                Name = txtName.Text,
                Price = txtPrice.Value,
                StartDate = dtpStartDate.Value,
                EndDate = dtpEndDate.Value,
                EmployeeId = Global.EmployeeId,
                TypeTicket = (TypeTicket)ccbTypeTicket.SelectedValue
            };
            _inOutService.CreatePayment(new Payment() { Code = model.Code, Price = model.Price, EmployeeId = Global.EmployeeId, isTicketMonth = true });
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                model.Id = int.Parse(txtId.Text);
                var result = _service.Update(model);
                if (!result)
                {
                    MessageBox.Show("Cập nhật phiếu tháng không thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                var result = _service.Create(model);
                if (!result)
                {
                    MessageBox.Show("Thêm mới phiếu tháng không thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
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