using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class ucShift
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
            dtgMain = new DataGridView();
            panel1 = new Panel();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgMain).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtgMain
            // 
            dtgMain.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgMain.Dock = DockStyle.Fill;
            dtgMain.Location = new Point(0, 0);
            dtgMain.Name = "dtgMain";
            dtgMain.RowTemplate.Height = 25;
            dtgMain.Size = new Size(1074, 435);
            dtgMain.TabIndex = 0;
            dtgMain.CellContentClick += dtgMain_CellContentClick;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgMain);
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 435);
            panel1.TabIndex = 8;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 23);
            btnCreate.TabIndex = 9;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // ucShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Name = "ucShift";
            Size = new Size(1080, 500);
            ((System.ComponentModel.ISupportInitialize)dtgMain).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dtgMain;
        private Panel panel1;
        private Button btnCreate;
    }
}
