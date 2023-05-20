using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class fMain
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
            panelLeft = new Panel();
            label1 = new Label();
            BtnIusse = new Button();
            btnReport = new Button();
            btnPayment = new Button();
            btnTicket = new Button();
            btnShift = new Button();
            btnEmployee = new Button();
            btnHome = new Button();
            panelRight = new Panel();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(label1);
            panelLeft.Controls.Add(BtnIusse);
            panelLeft.Controls.Add(btnReport);
            panelLeft.Controls.Add(btnPayment);
            panelLeft.Controls.Add(btnTicket);
            panelLeft.Controls.Add(btnShift);
            panelLeft.Controls.Add(btnEmployee);
            panelLeft.Controls.Add(btnHome);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(200, 500);
            panelLeft.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 54);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 7;
            label1.Text = "Tên Đồ Án ở đây";
            // 
            // BtnIusse
            // 
            BtnIusse.Location = new Point(0, 446);
            BtnIusse.Name = "BtnIusse";
            BtnIusse.Size = new Size(200, 50);
            BtnIusse.TabIndex = 6;
            BtnIusse.Text = "Sự cố";
            BtnIusse.UseVisualStyleBackColor = true;
            BtnIusse.Click += BtnIusse_Click;
            // 
            // btnReport
            // 
            btnReport.Location = new Point(0, 390);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(200, 50);
            btnReport.TabIndex = 5;
            btnReport.Text = "Báo cáo";
            btnReport.UseVisualStyleBackColor = true;
            btnReport.Click += btnReport_Click;
            // 
            // btnPayment
            // 
            btnPayment.Location = new Point(0, 334);
            btnPayment.Name = "btnPayment";
            btnPayment.Size = new Size(200, 50);
            btnPayment.TabIndex = 4;
            btnPayment.Text = "Doanh thu";
            btnPayment.UseVisualStyleBackColor = true;
            btnPayment.Click += btnPayment_Click;
            // 
            // btnTicket
            // 
            btnTicket.Location = new Point(0, 278);
            btnTicket.Name = "btnTicket";
            btnTicket.Size = new Size(200, 50);
            btnTicket.TabIndex = 3;
            btnTicket.Text = "Phiếu tháng";
            btnTicket.UseVisualStyleBackColor = true;
            btnTicket.Click += btnTicket_Click;
            // 
            // btnShift
            // 
            btnShift.Location = new Point(0, 222);
            btnShift.Name = "btnShift";
            btnShift.Size = new Size(200, 50);
            btnShift.TabIndex = 2;
            btnShift.Text = "Ca trực";
            btnShift.UseVisualStyleBackColor = true;
            btnShift.Click += btnShift_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.Location = new Point(0, 166);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(200, 50);
            btnEmployee.TabIndex = 1;
            btnEmployee.Text = "Nhân viên";
            btnEmployee.UseVisualStyleBackColor = true;
            btnEmployee.Click += btnEmployee_Click;
            // 
            // btnHome
            // 
            btnHome.Location = new Point(0, 110);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(200, 50);
            btnHome.TabIndex = 0;
            btnHome.Text = "Trang chủ";
            btnHome.UseVisualStyleBackColor = true;
            btnHome.Click += btnHome_Click;
            // 
            // panelRight
            // 
            panelRight.Location = new Point(200, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(1080, 500);
            panelRight.TabIndex = 0;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1280, 500);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fMain";
            FormClosing += formClosing;
            Load += fMain_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Button btnHome;
        private Button BtnIusse;
        private Button btnReport;
        private Button btnPayment;
        private Button btnTicket;
        private Button btnShift;
        private Button btnEmployee;
        private Label label1;
    }
}