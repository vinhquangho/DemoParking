using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class ucEmployee
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
            cbbStatus = new ComboBox();
            txtSearch = new TextBox();
            btnCreate = new Button();
            panel1 = new Panel();
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
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Location = new Point(526, 12);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(121, 23);
            cbbStatus.TabIndex = 7;
            cbbStatus.SelectedIndexChanged += cbbStatus_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(139, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 23);
            txtSearch.TabIndex = 6;
            txtSearch.KeyDown += textBox1_KeyDown;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 23);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgMain);
            panel1.Location = new Point(3, 53);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 435);
            panel1.TabIndex = 4;
            // 
            // ucEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cbbStatus);
            Controls.Add(txtSearch);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Name = "ucEmployee";
            Size = new Size(1080, 500);
            ((System.ComponentModel.ISupportInitialize)dtgMain).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgMain;
        private ComboBox cbbStatus;
        private TextBox txtSearch;
        private Button btnCreate;
        private Panel panel1;
    }
}
