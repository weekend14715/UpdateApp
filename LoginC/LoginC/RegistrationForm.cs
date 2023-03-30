using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;
using learnFireBase;
using System.Net;

using Microsoft.AspNetCore.Identity;
using System.Xml.Linq;
using System.Reflection.Metadata;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;


namespace LoginC
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "r1kZ8XFprzITFgKLotwA281RyUwGdJ8VqPO2cKLN",
            BasePath = "https://loginc-141a6-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Có vấn đề về kết nối");
            }


        }



        private string otp;

        private string GenerateOtp()
        {
            // generate a random 6-digit number
            Random random = new Random();
            int otpNumber = random.Next(100000, 999999);

            // convert the number to a string and return it
            return otpNumber.ToString();
        }

        private void SendOtpEmail(string emailAddress, string otp)
        {
            // create a new email message
            MimeMessage message = new MimeMessage();
            message.From.Add(new MailboxAddress("Hoàng Tuấn", "ctump14715@gmail.com"));
            message.To.Add(new MailboxAddress("", MailTbox.Text + "@gmail.com"));
            message.Subject = "Email Verification";
            message.Body = new TextPart("plain")
            {
                Text = "Mã OTP của bạn là: " + otp
            };

            // send the email using SMTP
            using (SmtpClient client = new SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("ctump14715@gmail.com", "zxdltsqdksxwdhxm");
                client.Send(message);
                client.Disconnect(true);
            }

            // show the OTP label
            otpLabel.Text = "Điền OTP gửi về Email của bạn";
            otpLabel.Visible = true;
        }
        private async void Sendbtn_Click(object sender, EventArgs e)
        {
            // check if email already exists in Firebase
            FirebaseResponse response = await client.GetAsync("Users");
            Dictionary<string, MyUser> users = response.ResultAs<Dictionary<string, MyUser>>();

            if (users != null && users.Values.Any(u => u.Email == MailTbox.Text))
            {
                MessageBox.Show("Email đã tồn tại!");
                return;
            }

            // generate a random OTP
            otp = GenerateOtp();

            // send the OTP to the user's email address
            SendOtpEmail(MailTbox.Text + "@gmail.com", otp);
        }

        private void otpBtn_Click(object sender, EventArgs e)
        {
            // check if the entered OTP matches the generated OTP
            if (OtpTbox.Text == otp)
            {
                MessageBox.Show("Xác thực email thành công");
                isEmailVerified = true;
            }
            else
            {
                MessageBox.Show("OTP không chính xác vui lòng nhập lại");
            }
        }
        private bool isEmailVerified = false;
        private void regBtn_Click(object sender, EventArgs e)
        {
            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
                string.IsNullOrWhiteSpace(passTbox.Text) &&
                string.IsNullOrWhiteSpace(nameTbox.Text) &&
                string.IsNullOrWhiteSpace(NicTbox.Text))
            {
                MessageBox.Show("Hoàn tất thông tin đăng ký");
                return;
            }
            #endregion

            if (!isEmailVerified)
            {
                MessageBox.Show("Vui lòng xác thực Email trước khi đăng ký");
                return;
            }

            MyUser user = new MyUser()
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text,
                Email = MailTbox.Text,
                Fullname = nameTbox.Text,
                NICno = NicTbox.Text
            };

            SetResponse set = client.Set(@"Users/" + UsernameTbox.Text, user);

            MessageBox.Show("Đăng ký thành công");
            this.Hide();
        }
    }










}
