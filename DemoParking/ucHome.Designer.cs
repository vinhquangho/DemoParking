using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class ucHome
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.ccbTypeTicket = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.dtpDateIn = new System.Windows.Forms.DateTimePicker();
            this.dtpDateOut = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 20);
            this.btnCreate.TabIndex = 15;
            this.btnCreate.Text = "Tạo";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgMain);
            this.panel1.Location = new System.Drawing.Point(3, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(921, 377);
            this.panel1.TabIndex = 14;
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
            this.dtgMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMain_CellContentClick);
            // 
            // ccbTypeTicket
            // 
            this.ccbTypeTicket.FormattingEnabled = true;
            this.ccbTypeTicket.Location = new System.Drawing.Point(779, 10);
            this.ccbTypeTicket.Name = "ccbTypeTicket";
            this.ccbTypeTicket.Size = new System.Drawing.Size(141, 21);
            this.ccbTypeTicket.TabIndex = 17;
            this.ccbTypeTicket.SelectedIndexChanged += new System.EventHandler(this.ccbTicket_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(130, 10);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 20);
            this.txtSearch.TabIndex = 16;
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Location = new System.Drawing.Point(619, 10);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(154, 21);
            this.cbbStatus.TabIndex = 18;
            this.cbbStatus.SelectedIndexChanged += new System.EventHandler(this.cbbStatus_SelectedIndexChanged);
            // 
            // dtpDateIn
            // 
            this.dtpDateIn.CustomFormat = "dd/MM/yyyy";
            this.dtpDateIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateIn.Location = new System.Drawing.Point(299, 10);
            this.dtpDateIn.Name = "dtpDateIn";
            this.dtpDateIn.Size = new System.Drawing.Size(154, 20);
            this.dtpDateIn.TabIndex = 19;
            this.dtpDateIn.ValueChanged += new System.EventHandler(this.dtpDateIn_ValueChanged);
            // 
            // dtpDateOut
            // 
            this.dtpDateOut.CustomFormat = "dd/MM/yyyy";
            this.dtpDateOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateOut.Location = new System.Drawing.Point(459, 10);
            this.dtpDateOut.Name = "dtpDateOut";
            this.dtpDateOut.Size = new System.Drawing.Size(154, 20);
            this.dtpDateOut.TabIndex = 20;
            this.dtpDateOut.ValueChanged += new System.EventHandler(this.dtpDateOut_ValueChanged);
            // 
            // ucHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dtpDateOut);
            this.Controls.Add(this.dtpDateIn);
            this.Controls.Add(this.cbbStatus);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ccbTypeTicket);
            this.Controls.Add(this.txtSearch);
            this.Name = "ucHome";
            this.Size = new System.Drawing.Size(926, 433);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCreate;
        private Panel panel1;
        private DataGridView dtgMain;
        private ComboBox ccbTypeTicket;
        private TextBox txtSearch;
        private ComboBox cbbStatus;
        private DateTimePicker dtpDateIn;
        private DateTimePicker dtpDateOut;
    }
}
