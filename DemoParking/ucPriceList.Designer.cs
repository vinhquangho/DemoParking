namespace DemoParking
{
    partial class ucPriceList
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
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(3, 10);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(111, 20);
            this.btnCreate.TabIndex = 11;
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
            this.panel1.TabIndex = 10;
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
            // ucPriceList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.panel1);
            this.Name = "ucPriceList";
            this.Size = new System.Drawing.Size(926, 433);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgMain;
    }
}
