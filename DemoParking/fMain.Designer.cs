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
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnPriceList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnIusse = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnShift = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnPriceList);
            this.panelLeft.Controls.Add(this.label1);
            this.panelLeft.Controls.Add(this.BtnIusse);
            this.panelLeft.Controls.Add(this.btnReport);
            this.panelLeft.Controls.Add(this.btnPayment);
            this.panelLeft.Controls.Add(this.btnTicket);
            this.panelLeft.Controls.Add(this.btnShift);
            this.panelLeft.Controls.Add(this.btnEmployee);
            this.panelLeft.Controls.Add(this.btnHome);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(171, 433);
            this.panelLeft.TabIndex = 0;
            // 
            // btnPriceList
            // 
            this.btnPriceList.Location = new System.Drawing.Point(0, 375);
            this.btnPriceList.Name = "btnPriceList";
            this.btnPriceList.Size = new System.Drawing.Size(171, 34);
            this.btnPriceList.TabIndex = 7;
            this.btnPriceList.Text = "Phí gửi xe";
            this.btnPriceList.UseVisualStyleBackColor = true;
            this.btnPriceList.Click += new System.EventHandler(this.btnPriceList_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tên Đồ Án ở đây";
            // 
            // BtnIusse
            // 
            this.BtnIusse.Location = new System.Drawing.Point(0, 335);
            this.BtnIusse.Name = "BtnIusse";
            this.BtnIusse.Size = new System.Drawing.Size(171, 34);
            this.BtnIusse.TabIndex = 6;
            this.BtnIusse.Text = "Sự cố";
            this.BtnIusse.UseVisualStyleBackColor = true;
            this.BtnIusse.Click += new System.EventHandler(this.BtnIusse_Click);
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(0, 295);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(171, 34);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "Báo cáo";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Location = new System.Drawing.Point(0, 255);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(171, 34);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Doanh thu";
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.btnPayment_Click);
            // 
            // btnTicket
            // 
            this.btnTicket.Location = new System.Drawing.Point(0, 215);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(171, 34);
            this.btnTicket.TabIndex = 3;
            this.btnTicket.Text = "Phiếu tháng";
            this.btnTicket.UseVisualStyleBackColor = true;
            this.btnTicket.Click += new System.EventHandler(this.btnTicket_Click);
            // 
            // btnShift
            // 
            this.btnShift.Location = new System.Drawing.Point(0, 175);
            this.btnShift.Name = "btnShift";
            this.btnShift.Size = new System.Drawing.Size(171, 34);
            this.btnShift.TabIndex = 2;
            this.btnShift.Text = "Ca trực";
            this.btnShift.UseVisualStyleBackColor = true;
            this.btnShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(0, 135);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(171, 34);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "Nhân viên";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(0, 95);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(171, 34);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Trang chủ";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelRight
            // 
            this.panelRight.Location = new System.Drawing.Point(171, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(926, 433);
            this.panelRight.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 433);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelRight);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fMain";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.ResumeLayout(false);

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
        private Button btnPriceList;
    }
}