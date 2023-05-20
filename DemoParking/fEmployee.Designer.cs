using System.Drawing;
using System.Windows.Forms;

namespace DemoParking
{
    partial class fEmployee
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
            components = new System.ComponentModel.Container();
            txtCode = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            ddlStatus = new ComboBox();
            dtpBirthDay = new DateTimePicker();
            txtId = new TextBox();
            errorTextBox = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorTextBox).BeginInit();
            SuspendLayout();
            // 
            // txtCode
            // 
            txtCode.Location = new Point(12, 32);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(218, 23);
            txtCode.TabIndex = 0;
            txtCode.Validating += txtCode_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(12, 82);
            txtName.Name = "txtName";
            txtName.Size = new Size(218, 23);
            txtName.TabIndex = 1;
            txtName.Validating += txtName_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(12, 136);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(218, 23);
            txtAddress.TabIndex = 2;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 194);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(218, 23);
            txtPhone.TabIndex = 3;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(259, 32);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(218, 23);
            txtUserName.TabIndex = 4;
            txtUserName.Validating += txtUserName_Validating;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(259, 82);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(218, 23);
            txtPassword.TabIndex = 5;
            txtPassword.UseSystemPasswordChar = true;
            txtPassword.Validating += txtPassword_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 8;
            label1.Text = "Mã nhân viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 64);
            label2.Name = "label2";
            label2.Size = new Size(83, 15);
            label2.TabIndex = 9;
            label2.Text = "Tên nhân viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 118);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 10;
            label3.Text = "Địa chỉ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 176);
            label4.Name = "label4";
            label4.Size = new Size(79, 15);
            label4.TabIndex = 11;
            label4.Text = "Số điện thoại:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(259, 9);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 12;
            label5.Text = "Tài khoản:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(259, 64);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 13;
            label6.Text = "Mật khẩu:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(259, 118);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 14;
            label7.Text = "Ngày sinh:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(259, 176);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 15;
            label8.Text = "Trạng thái:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(155, 246);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.Location = new Point(259, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 17;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // ddlStatus
            // 
            ddlStatus.FormattingEnabled = true;
            ddlStatus.Location = new Point(259, 194);
            ddlStatus.Name = "ddlStatus";
            ddlStatus.Size = new Size(218, 23);
            ddlStatus.TabIndex = 18;
            // 
            // dtpBirthDay
            // 
            dtpBirthDay.CustomFormat = "dd/MM/yyyy hh:ss";
            dtpBirthDay.Format = DateTimePickerFormat.Custom;
            dtpBirthDay.Location = new Point(259, 136);
            dtpBirthDay.Name = "dtpBirthDay";
            dtpBirthDay.Size = new Size(218, 23);
            dtpBirthDay.TabIndex = 19;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 245);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 20;
            txtId.Visible = false;
            // 
            // errorTextBox
            // 
            errorTextBox.ContainerControl = this;
            // 
            // fEmployee
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 280);
            Controls.Add(txtId);
            Controls.Add(dtpBirthDay);
            Controls.Add(ddlStatus);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtCode);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fEmployee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fEmployee";
            Load += fEmployee_Load;
            ((System.ComponentModel.ISupportInitialize)errorTextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtCode;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtUserName;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button btnSave;
        private Button btnCancel;
        private ComboBox ddlStatus;
        private DateTimePicker dtpBirthDay;
        private TextBox txtId;
        private ErrorProvider errorTextBox;
    }
}