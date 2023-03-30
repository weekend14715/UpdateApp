namespace LoginC
{
    partial class LoginForm
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
            passTbox = new TextBox();
            UsernameTbox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            regBtn = new Button();
            LogBtn = new Button();
            checkBox1 = new CheckBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelVersion = new Label();
            label7 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            label10 = new Label();
            label12 = new Label();
            label11 = new Label();
            label9 = new Label();
            label8 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // passTbox
            // 
            passTbox.Location = new Point(524, 159);
            passTbox.Name = "passTbox";
            passTbox.PasswordChar = '*';
            passTbox.Size = new Size(234, 27);
            passTbox.TabIndex = 2;
            // 
            // UsernameTbox
            // 
            UsernameTbox.Location = new Point(525, 84);
            UsernameTbox.Name = "UsernameTbox";
            UsernameTbox.Size = new Size(233, 27);
            UsernameTbox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(524, 125);
            label2.Name = "label2";
            label2.Size = new Size(112, 31);
            label2.TabIndex = 19;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(525, 50);
            label1.Name = "label1";
            label1.Size = new Size(111, 31);
            label1.TabIndex = 21;
            label1.Text = "Tài Khoản";
            // 
            // regBtn
            // 
            regBtn.Location = new Point(571, 360);
            regBtn.Name = "regBtn";
            regBtn.Size = new Size(134, 43);
            regBtn.TabIndex = 4;
            regBtn.Text = "Đăng ký";
            regBtn.UseVisualStyleBackColor = true;
            regBtn.Click += regBtn_Click;
            // 
            // LogBtn
            // 
            LogBtn.Location = new Point(571, 268);
            LogBtn.Name = "LogBtn";
            LogBtn.Size = new Size(134, 43);
            LogBtn.TabIndex = 3;
            LogBtn.Text = "Đăng nhập";
            LogBtn.UseVisualStyleBackColor = true;
            LogBtn.Click += LogBtn_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.ForeColor = SystemColors.ButtonHighlight;
            checkBox1.Location = new Point(525, 192);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(174, 35);
            checkBox1.TabIndex = 22;
            checkBox1.Text = "Lưu tài khoản";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(56, 50);
            label3.Name = "label3";
            label3.Size = new Size(303, 81);
            label3.TabIndex = 23;
            label3.Text = "WEEKEND";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(86, 375);
            label4.Name = "label4";
            label4.Size = new Size(213, 28);
            label4.TabIndex = 23;
            label4.Text = "HUỲNH HOÀNG TUẤN";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(120, 403);
            label5.Name = "label5";
            label5.Size = new Size(122, 28);
            label5.TabIndex = 23;
            label5.Text = "0369647957";
            label5.TextAlign = ContentAlignment.TopRight;
            // 
            // labelVersion
            // 
            labelVersion.AutoSize = true;
            labelVersion.Location = new Point(378, 411);
            labelVersion.Name = "labelVersion";
            labelVersion.Size = new Size(39, 20);
            labelVersion.TabIndex = 24;
            labelVersion.Text = "1.0.2";
            labelVersion.Click += labelVersion_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Cyan;
            label7.Location = new Point(536, 318);
            label7.Name = "label7";
            label7.Size = new Size(203, 28);
            label7.TabIndex = 25;
            label7.Text = "Bạn chưa có tài khoản";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Cyan;
            label6.Location = new Point(568, 230);
            label6.Name = "label6";
            label6.Size = new Size(145, 28);
            label6.TabIndex = 26;
            label6.Text = "Quên mật khẩu";
            label6.Click += label6_Click_1;
            label6.MouseEnter += label6_MouseEnter;
            label6.MouseLeave += label6_MouseLeave;
            label6.MouseMove += label6_MouseMove;
            // 
            // panel1
            // 
            panel1.BackColor = Color.GreenYellow;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label9);
            panel1.Location = new Point(56, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(333, 167);
            panel1.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = Color.Blue;
            label10.Location = new Point(12, 11);
            label10.Name = "label10";
            label10.Size = new Size(190, 23);
            label10.TabIndex = 23;
            label10.Text = "Đăng ký xác thực Gmail";
            label10.TextAlign = ContentAlignment.TopRight;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.GreenYellow;
            label12.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label12.ForeColor = Color.Crimson;
            label12.Location = new Point(11, 106);
            label12.Name = "label12";
            label12.Size = new Size(258, 23);
            label12.TabIndex = 23;
            label12.Text = "Cập nhật ứng dụng Nhiệt ẩm kế";
            label12.TextAlign = ContentAlignment.TopRight;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.GreenYellow;
            label11.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label11.ForeColor = Color.Crimson;
            label11.Location = new Point(11, 75);
            label11.Name = "label11";
            label11.Size = new Size(271, 23);
            label11.TabIndex = 23;
            label11.Text = "Cập nhật ứng dụng Bàn giao tiền ";
            label11.TextAlign = ContentAlignment.TopRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.GreenYellow;
            label9.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Blue;
            label9.Location = new Point(11, 45);
            label9.Name = "label9";
            label9.Size = new Size(320, 23);
            label9.TabIndex = 23;
            label9.Text = "Gửi mật khẩu về mail khi quên mật khảu";
            label9.TextAlign = ContentAlignment.TopRight;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonHighlight;
            label8.Location = new Point(56, 154);
            label8.Name = "label8";
            label8.Size = new Size(176, 28);
            label8.TabIndex = 23;
            label8.Text = "Thông tin cập nhật";
            label8.TextAlign = ContentAlignment.TopRight;
            // 
            // LoginForm
            // 
            AcceptButton = LogBtn;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(labelVersion);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(passTbox);
            Controls.Add(UsernameTbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(LogBtn);
            Controls.Add(regBtn);
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += LoginForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox passTbox;
        private TextBox UsernameTbox;
        private Label label2;
        private Label label1;
        private Button regBtn;
        private Button LogBtn;
        private CheckBox checkBox1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelVersion;
        private Label label7;
        private Label label6;
        private Panel panel1;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label12;
        private Label label11;
    }
}