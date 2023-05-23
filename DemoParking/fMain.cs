using System;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }
        private void formClosing(object sener, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo!", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var ucHome = new ucHome();
            if (!panelRight.Controls.Contains(ucHome))
            {
                panelRight.Controls.Add(ucHome);
                ucHome.Dock = DockStyle.Fill;
                ucHome.BringToFront();
            }
            else
            {
                ucHome.BringToFront();
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            var ucEmployee = new ucEmployee();
            if (!panelRight.Controls.Contains(ucEmployee))
            {
                panelRight.Controls.Add(ucEmployee);
                ucEmployee.Dock = DockStyle.Fill;
                ucEmployee.BringToFront();
            }
            else
            {
                ucEmployee.BringToFront();
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            var ucShift = new ucShift();
            if (!panelRight.Controls.Contains(ucShift))
            {
                panelRight.Controls.Add(ucShift);
                ucShift.Dock = DockStyle.Fill;
                ucShift.BringToFront();
            }
            else
            {
                ucShift.BringToFront();
            }
        }

        private void btnTicket_Click(object sender, EventArgs e)
        {
            var ucTicket = new ucTicket();
            if (!panelRight.Controls.Contains(ucTicket))
            {
                panelRight.Controls.Add(ucTicket);
                ucTicket.Dock = DockStyle.Fill;
                ucTicket.BringToFront();
            }
            else
            {
                ucTicket.BringToFront();
            }
        }

        private void btnPayment_Click(object sender, EventArgs e)
        {
            var ucPayment = new ucPayment();
            if (!panelRight.Controls.Contains(ucPayment))
            {
                panelRight.Controls.Add(ucPayment);
                ucPayment.Dock = DockStyle.Fill;
                ucPayment.BringToFront();
            }
            else
            {
                ucPayment.BringToFront();
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var ucReport = new ucReport();
            if (!panelRight.Controls.Contains(ucReport))
            {
                panelRight.Controls.Add(ucReport);
                ucReport.Dock = DockStyle.Fill;
                ucReport.BringToFront();
            }
            else
            {
                ucReport.BringToFront();
            }
        }

        private void BtnIusse_Click(object sender, EventArgs e)
        {
            var ucIssue = new ucIssue();
            if (!panelRight.Controls.Contains(ucIssue))
            {
                panelRight.Controls.Add(ucIssue);
                ucIssue.Dock = DockStyle.Fill;
                ucIssue.BringToFront();
            }
            else
            {
                ucIssue.BringToFront();
            }
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            var ucHome = new ucHome();
            if (!panelRight.Controls.Contains(ucHome))
            {
                panelRight.Controls.Add(ucHome);
                ucHome.Dock = DockStyle.Fill;
                ucHome.BringToFront();
            }
            else
            {
                ucHome.BringToFront();
            }
        }

        private void btnPriceList_Click(object sender, EventArgs e)
        {
            var ucPriceList = new ucPriceList();
            if (!panelRight.Controls.Contains(ucPriceList))
            {
                panelRight.Controls.Add(ucPriceList);
                ucPriceList.Dock = DockStyle.Fill;
                ucPriceList.BringToFront();
            }
            else
            {
                ucPriceList.BringToFront();
            }

        }
    }
}
