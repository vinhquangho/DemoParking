using System.Drawing;
using System.Windows.Forms;
namespace DemoParking
{
    partial class ucPayment
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
            panel1 = new Panel();
            btnCreate = new Button();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            dtgMain = new DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgMain).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(dtgMain);
            panel1.Location = new Point(3, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 435);
            panel1.TabIndex = 0;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(3, 21);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(130, 23);
            btnCreate.TabIndex = 1;
            btnCreate.Text = "Tạo";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(367, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(526, 21);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
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
            // 
            // ucPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(btnCreate);
            Controls.Add(panel1);
            Name = "ucPayment";
            Size = new Size(1080, 500);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgMain).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private DataGridView dtgMain;
        private Button btnCreate;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}
