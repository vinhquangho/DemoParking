using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class ucPayment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.dtpTo = new System.Windows.Forms.DateTimePicker();
            this.dtpFrom = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgMain);
            this.panel1.Location = new System.Drawing.Point(3, 54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 377);
            this.panel1.TabIndex = 0;
            // 
            // dtgMain
            // 
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgMain.Location = new System.Drawing.Point(0, 0);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowTemplate.Height = 25;
            this.dtgMain.Size = new System.Drawing.Size(921, 377);
            this.dtgMain.TabIndex = 0;
            // 
            // dtpTo
            // 
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(322, 20);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(200, 20);
            this.dtpTo.TabIndex = 1;
            // 
            // dtpFrom
            // 
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(101, 20);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(200, 20);
            this.dtpFrom.TabIndex = 2;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(548, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(74, 20);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Tìm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // ucPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dtpFrom);
            this.Controls.Add(this.dtpTo);
            this.Controls.Add(this.panel1);
            this.Name = "ucPayment";
            this.Size = new System.Drawing.Size(926, 433);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView dtgMain;
        private DateTimePicker dtpTo;
        private DateTimePicker dtpFrom;
        private Button btnSearch;
    }
}
