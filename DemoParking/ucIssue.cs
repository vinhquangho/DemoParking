using DemoParking.Models;
using DemoParking.Services;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DemoParking
{
    public partial class ucIssue : UserControl
    {
        private IssueService _service = new IssueService(new EntityFramework.AppDbContext());
        public ucIssue()
        {
            InitializeComponent();
            LoadDataGrid(string.Empty);
        }

        private void btnCreate_Click(object sender, System.EventArgs e)
        {
            var form = new fIssue();
            form.FormClosing += formClosing;
            form.ShowDialog();
        }
        private void formClosing(object sender, FormClosingEventArgs e)
        {
            LoadDataGrid(string.Empty);
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataGrid(txtSearch.Text);
            }
        }
        public void LoadDataGrid(string text)
        {
            _service = new IssueService(new EntityFramework.AppDbContext());
            var list = _service.GetAll(text);
            dtgMain.DataSource = list;
            dtgMain.Columns["Code"].HeaderText = "Biển số xe";
            dtgMain.Columns["Reason"].HeaderText = "Lý do";
            dtgMain.Columns["Content"].HeaderText = "Nội dung";
            dtgMain.Columns["CreationTime"].HeaderText = "Ngày tạo";
            dtgMain.Columns["EmployeeName"].HeaderText = "Người tạo";
            dtgMain.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
