using DemoParking.EntityFramework;
using DemoParking.Models;
using DemoParking.Services;
using System;
using System.Windows.Forms;

namespace DemoParking
{
    public partial class fShift : Form
    {
        ShiftService _service = new ShiftService(new AppDbContext());
        Shift shift = null;
        public fShift(int? id)
        {
            InitializeComponent();
            if (id.HasValue)
            {
                var model = _service.GetById(id.Value);
                dtpStart.Value = model.HourStart;
                dtpEnd.Value = model.HourEnd;
                txtPrice.Value = model.Price;
                txtId.Text = model.Id.ToString();
                txtName.Text = model.Name;
                shift = model;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Shift()
            {
                HourStart = dtpStart.Value,
                HourEnd = dtpEnd.Value,
                Price = txtPrice.Value,
                Name = txtName.Text
            };
            if (!string.IsNullOrEmpty(txtId.Text))
            {
                model.Id = int.Parse(txtId.Text);
                var result = _service.Update(model);
                if (!result)
                {
                    MessageBox.Show("Cập nhật ca trực không thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }
            else
            {
                var result = _service.Create(model);
                if (!result)
                {
                    MessageBox.Show("Thêm mới ca trực không thành công!", "Thông báo", MessageBoxButtons.OK);
                    return;
                }
            }

            this.Close();
        }
    }
}
