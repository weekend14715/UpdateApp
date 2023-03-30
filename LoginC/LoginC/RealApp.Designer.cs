namespace LoginC
{
    partial class RealApp
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
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(273, 362);
            button1.Name = "button1";
            button1.Size = new Size(248, 76);
            button1.TabIndex = 0;
            button1.Text = "UPDATE";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(167, 43);
            label1.Name = "label1";
            label1.Size = new Size(477, 81);
            label1.TabIndex = 1;
            label1.Text = "BÀN GIAO TIỀN";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Honeydew;
            panel1.Location = new Point(170, 153);
            panel1.Name = "panel1";
            panel1.Size = new Size(465, 192);
            panel1.TabIndex = 26;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkGoldenrod;
            button2.Location = new Point(234, 459);
            button2.Name = "button2";
            button2.Size = new Size(339, 30);
            button2.TabIndex = 27;
            button2.Text = "Thay đổi đường dẫn đến thư mục Ban giao tiền";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(170, 124);
            label2.Name = "label2";
            label2.Size = new Size(162, 23);
            label2.TabIndex = 28;
            label2.Text = "Thông tin cập nhật";
            // 
            // RealApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Cornsilk;
            ClientSize = new Size(800, 520);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "RealApp";
            Text = "RealApp";
            Load += RealApp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        internal Label label1;
        private Panel panel1;
        private Button button2;
        private Label label2;
    }
}