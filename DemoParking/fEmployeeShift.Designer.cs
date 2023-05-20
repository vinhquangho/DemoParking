using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class fEmployeeShift
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            dgvMain = new DataGridView();
            cbbEmployee = new ComboBox();
            btnCreate = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvMain).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dgvMain);
            panel1.Location = new Point(12, 70);
            panel1.Name = "panel1";
            panel1.Size = new Size(611, 272);
            panel1.TabIndex = 0;
            // 
            // dgvMain
            // 
            dgvMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMain.Dock = DockStyle.Fill;
            dgvMain.Location = new Point(0, 0);
            dgvMain.Name = "dgvMain";
            dgvMain.RowTemplate.Height = 25;
            dgvMain.Size = new Size(611, 272);
            dgvMain.TabIndex = 0;
            dgvMain.CellContentClick += dgvMain_CellContentClick;
            // 
            // cbbEmployee
            // 
            cbbEmployee.FormattingEnabled = true;
            cbbEmployee.Location = new Point(93, 29);
            cbbEmployee.Name = "cbbEmployee";
            cbbEmployee.Size = new Size(173, 23);
            cbbEmployee.TabIndex = 1;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(12, 28);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 23);
            btnCreate.TabIndex = 3;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // fEmployeeShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(635, 354);
            Controls.Add(btnCreate);
            Controls.Add(cbbEmployee);
            Controls.Add(panel1);
            Name = "fEmployeeShift";
            Text = "fEmployeeShift";
            MaximizeBox = false;
            MinimizeBox = false;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvMain).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvMain;
        private ComboBox cbbEmployee;
        private Button btnCreate;
    }
}