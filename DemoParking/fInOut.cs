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

namespace DemoParking
{
    public partial class fInOut : Form
    {
        private InOutService _service = new InOutService(new AppDbContext());
        public fInOut()
        {
            InitializeComponent();
            LoadComboboxTypeTicket();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = _service.Create(new InOut()
            {
                Code = txtCode.Text,
                DateIn = DateTime.Now,
                DateOut = null,
                IsTicket = false, // check ticket
                Status = Status.Active,
                TypeTicket = (TypeTicket)ccbTypeTicket.SelectedValue,
                EmployeeId = Global.EmployeeId,
            });
            if (!result)
            {
                MessageBox.Show("Thêm phiếu giữ xe không thành công!", "Thông báo!", MessageBoxButtons.OK);
                return;
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
