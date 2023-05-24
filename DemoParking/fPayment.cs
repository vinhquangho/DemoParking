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
    public partial class fPayment : Form
    {
        private InOutService _service = new InOutService(new AppDbContext());
        InOut inOut { get; set; }
        public fPayment(int? id)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                var model = _service.GetById(id.Value);
                inOut = model;
                var price = _service.GetPaymentByTicketType(model.TypeTicket);
                txtPrice.Value = price;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _service.UpdateInOut(inOut.Id);
            _service.CreatePayment(new Payment() { Code = inOut.Code, EmployeeId = Global.EmployeeId, Price = txtPrice.Value});
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
