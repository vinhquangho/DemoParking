using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class fTicket
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
            btnCancel = new Button();
            btnSave = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtName = new TextBox();
            txtCode = new TextBox();
            dtpStartDate = new DateTimePicker();
            dtpEndDate = new DateTimePicker();
            txtPrice = new NumericUpDown();
            ccbTypeTicket = new ComboBox();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.Location = new Point(265, 246);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(161, 247);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 35;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(265, 97);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 32;
            label6.Text = "Loại phiếu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(265, 42);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 31;
            label5.Text = "Giá tiền:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(265, 151);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 30;
            label4.Text = "Ngày kết thúc:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 151);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 29;
            label3.Text = "Ngày bắt đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 97);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 28;
            label2.Text = "Tên chủ xe:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 42);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 27;
            label1.Text = "Biển số xe:";
            // 
            // txtName
            // 
            txtName.Location = new Point(18, 115);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 23);
            txtName.TabIndex = 22;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(18, 65);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(218, 23);
            txtCode.TabIndex = 21;
            // 
            // dtpStartDate
            // 
            dtpStartDate.Format = DateTimePickerFormat.Short;
            dtpStartDate.Location = new Point(18, 169);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(218, 23);
            dtpStartDate.TabIndex = 40;
            // 
            // dtpEndDate
            // 
            dtpEndDate.Format = DateTimePickerFormat.Short;
            dtpEndDate.Location = new Point(265, 169);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.Size = new Size(218, 23);
            dtpEndDate.TabIndex = 41;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(265, 65);
            txtPrice.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(218, 23);
            txtPrice.TabIndex = 42;
            // 
            // ccbTypeTicket
            // 
            ccbTypeTicket.FormattingEnabled = true;
            ccbTypeTicket.Location = new Point(265, 115);
            ccbTypeTicket.Name = "ccbTypeTicket";
            ccbTypeTicket.Size = new Size(218, 23);
            ccbTypeTicket.TabIndex = 43;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(18, 248);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 44;
            txtId.Visible = false;
            // 
            // fTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 280);
            Controls.Add(txtId);
            Controls.Add(ccbTypeTicket);
            Controls.Add(txtPrice);
            Controls.Add(dtpEndDate);
            Controls.Add(dtpStartDate);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fTicket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fTicket";
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnCancel;
        private Button btnSave;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtName;
        private TextBox txtCode;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private NumericUpDown txtPrice;
        private ComboBox ccbTypeTicket;
        private TextBox txtId;
    }
}