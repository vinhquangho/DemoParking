using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class fShift
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
            errorTextBox = new ErrorProvider(components);
            txtId = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            dtpStart = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            dtpEnd = new DateTimePicker();
            txtPrice = new NumericUpDown();
            label3 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)errorTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).BeginInit();
            SuspendLayout();
            // 
            // errorTextBox
            // 
            errorTextBox.ContainerControl = this;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(12, 85);
            txtId.Name = "txtId";
            txtId.Size = new Size(156, 23);
            txtId.TabIndex = 39;
            txtId.Visible = false;
            // 
            // btnCancel
            // 
            btnCancel.CausesValidation = false;
            btnCancel.Location = new Point(336, 84);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 36;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(255, 84);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 35;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dtpStart
            // 
            dtpStart.CustomFormat = "HH";
            dtpStart.Format = DateTimePickerFormat.Custom;
            dtpStart.Location = new Point(12, 36);
            dtpStart.Name = "dtpStart";
            dtpStart.ShowUpDown = true;
            dtpStart.Size = new Size(156, 23);
            dtpStart.TabIndex = 40;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(71, 15);
            label1.TabIndex = 41;
            label1.Text = "Giờ bất đầu:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 18);
            label2.Name = "label2";
            label2.Size = new Size(74, 15);
            label2.TabIndex = 43;
            label2.Text = "Giờ kết thúc:";
            // 
            // dtpEnd
            // 
            dtpEnd.CustomFormat = "HH";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.Location = new Point(174, 36);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.ShowUpDown = true;
            dtpEnd.Size = new Size(156, 23);
            dtpEnd.TabIndex = 42;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(336, 36);
            txtPrice.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            txtPrice.Name = "txtPrice";
            txtPrice.RightToLeft = RightToLeft.No;
            txtPrice.Size = new Size(156, 23);
            txtPrice.TabIndex = 44;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 18);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 45;
            label3.Text = "Số tiền cần trả:";
            // 
            // txtName
            // 
            txtName.Location = new Point(498, 35);
            txtName.Name = "txtName";
            txtName.Size = new Size(156, 23);
            txtName.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 17);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 47;
            label4.Text = "Tên:";
            // 
            // fShift
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(657, 112);
            Controls.Add(label4);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(txtPrice);
            Controls.Add(label2);
            Controls.Add(dtpEnd);
            Controls.Add(label1);
            Controls.Add(dtpStart);
            Controls.Add(txtId);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fShift";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "fShift";
            ((System.ComponentModel.ISupportInitialize)errorTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)txtPrice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ErrorProvider errorTextBox;
        private TextBox txtId;
        private Button btnCancel;
        private Button btnSave;
        private Label label3;
        private NumericUpDown txtPrice;
        private Label label2;
        private DateTimePicker dtpEnd;
        private Label label1;
        private DateTimePicker dtpStart;
        private Label label4;
        private TextBox txtName;
    }
}