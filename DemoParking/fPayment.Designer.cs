namespace DemoParking
{
    partial class fPayment
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.CausesValidation = false;
            this.btnCancel.Location = new System.Drawing.Point(175, 56);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 20);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(79, 56);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(90, 20);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(79, 30);
            this.txtPrice.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(187, 20);
            this.txtPrice.TabIndex = 53;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Số tiền cần thanh toán:";
            // 
            // fPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 95);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fPayment";
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown txtPrice;
        private System.Windows.Forms.Label label1;
    }
}