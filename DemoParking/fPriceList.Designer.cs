namespace DemoParking
{
    partial class fPriceList
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
            this.components = new System.ComponentModel.Container();
            this.errorTextBox = new System.Windows.Forms.ErrorProvider(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.ccbTypeTicket = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // errorTextBox
            // 
            this.errorTextBox.ContainerControl = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Loại xe";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(284, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Số tiền cần trả:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(284, 25);
            this.txtPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrice.Size = new System.Drawing.Size(134, 20);
            this.txtPrice.TabIndex = 55;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(145, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Giờ kết thúc:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "HH";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(145, 25);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.ShowUpDown = true;
            this.dtpEnd.Size = new System.Drawing.Size(134, 20);
            this.dtpEnd.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Giờ bất đầu:";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "HH";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(6, 25);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.ShowUpDown = true;
            this.dtpStart.Size = new System.Drawing.Size(134, 20);
            this.dtpStart.TabIndex = 51;
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(6, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(134, 20);
            this.txtId.TabIndex = 50;
            this.txtId.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(284, 67);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(64, 20);
            this.btnCancel.TabIndex = 49;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(215, 67);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 20);
            this.btnSave.TabIndex = 48;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ccbTypeTicket
            // 
            this.ccbTypeTicket.FormattingEnabled = true;
            this.ccbTypeTicket.Location = new System.Drawing.Point(426, 24);
            this.ccbTypeTicket.Name = "ccbTypeTicket";
            this.ccbTypeTicket.Size = new System.Drawing.Size(134, 21);
            this.ccbTypeTicket.TabIndex = 59;
            // 
            // fPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 97);
            this.Controls.Add(this.ccbTypeTicket);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPriceList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fPriceList";
            ((System.ComponentModel.ISupportInitialize)(this.errorTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorTextBox;
        private System.Windows.Forms.ComboBox ccbTypeTicket;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
    }
}