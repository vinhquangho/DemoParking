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
    public partial class fIssue : Form
    {
        private IssueService _service = new IssueService(new AppDbContext());
        public fIssue()
        {
            InitializeComponent();
            LoadComboboxTypeTicket();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            var model = new Issue()
            {
                Code = ccbInOut.SelectedValue.ToString(),
                Reason = txtReason.Text,
                Content = txtContent.Text,
                EmployeeId = Global.EmployeeId
            };
            _service.Create(model);
            MessageBox.Show("Thêm sự cố thành công!", "Thông báo", MessageBoxButtons.OK);
            this.Close();
        }
        private void LoadComboboxTypeTicket()
        {
            var list = _service.GetCode();
            ccbInOut.DataSource = list;
            ccbInOut.DisplayMember = "Name";
            ccbInOut.ValueMember = "Name";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
