namespace LoginC
{
    partial class Chon_Ung_Dung
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
            label1 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Crimson;
            label1.Location = new Point(168, 69);
            label1.Name = "label1";
            label1.Size = new Size(480, 41);
            label1.TabIndex = 0;
            label1.Text = "Chọn ứng dụng mà muốn sử dụng";
            // 
            // button1
            // 
            button1.BackColor = Color.GreenYellow;
            button1.Location = new Point(166, 209);
            button1.Name = "button1";
            button1.Size = new Size(218, 79);
            button1.TabIndex = 1;
            button1.Text = "Bàn Giao Tiền";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Coral;
            button2.Location = new Point(466, 209);
            button2.Name = "button2";
            button2.Size = new Size(218, 79);
            button2.TabIndex = 1;
            button2.Text = "Nhiệt Ẩm Kế";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Chon_Ung_Dung
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlText;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "Chon_Ung_Dung";
            Text = "Chon_Ung_Dung";
            Load += Chon_Ung_Dung_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
    }
}