using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class ucTicket
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
            btnCreate = new Button();
            panel1 = new Panel();
            dtgMain = new DataGridView();
            ccbTicket = new ComboBox();
            txtSearch = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMain).BeginInit();
            SuspendLayout();
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 12);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 23);
            btnCreate.TabIndex = 11;
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
            panel1.TabIndex = 10;
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
            // ccbTicket
            // 
            ccbTicket.FormattingEnabled = true;
            ccbTicket.Location = new Point(539, 12);
            ccbTicket.Name = "ccbTicket";
            ccbTicket.Size = new Size(121, 23);
            ccbTicket.TabIndex = 13;
            ccbTicket.SelectedIndexChanged += ccbTicket_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(152, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(367, 23);
            txtSearch.TabIndex = 12;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // ucTicket
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ccbTicket);
            Controls.Add(txtSearch);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Name = "ucTicket";
            Size = new Size(1080, 500);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreate;
        private Panel panel1;
        private DataGridView dtgMain;
        private ComboBox ccbTicket;
        private TextBox txtSearch;
    }
}
