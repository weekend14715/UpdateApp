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
using LoginC.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using MailKit.Net.Smtp;
using MailKit.Security;
using MimeKit;
using System.Net;
using System.Reflection;
using System.Resources;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Download;
using System.IO.Compression;
using System.Diagnostics;






namespace LoginC
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "r1kZ8XFprzITFgKLotwA281RyUwGdJ8VqPO2cKLN",
            BasePath = "https://loginc-141a6-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;


        private void LoginForm_Load(object sender, EventArgs e)
        {

            UserCredential credential;
            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    new[] { DriveService.Scope.Drive },
                    "user",
                    System.Threading.CancellationToken.None).Result;
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "Google Drive API Sample",
            });

            // Đường dẫn đến thư mục trên Google Drive cần tải về
            var folderId = "12Bp7MhKIl4HBELF7v4uWSjZJoN20e0aD";


            // Lấy danh sách tập tin trong thư mục
            var request1 = service.Files.List();
            request1.Q = $"'{folderId}' in parents and name = 'Test.txt'";
            request1.Fields = "files(id, name)";
            var results1 = request1.Execute();
            if (results1.Files.Count > 0)
            {
                var file1 = results1.Files[0];
                var fileId1 = file1.Id;
                var requestDownload1 = service.Files.Get(fileId1);
                var streamDownload1 = new MemoryStream();
                requestDownload1.Download(streamDownload1);
                streamDownload1.Position = 0;
                var fileContent = new StreamReader(streamDownload1).ReadToEnd();
                string versionText = labelVersion.Text;


                if (fileContent != versionText)
                {
                    MessageBox.Show("Có bản cập nhật mới");

                    string tempFolderPath = Path.GetTempPath();
                    string updateFolderName = "Update";
                    string updateFolderPath = Path.Combine(tempFolderPath, updateFolderName);
                    string electronFilePath = Path.Combine(updateFolderPath, "electron.zip");

                    if (!Directory.Exists(updateFolderPath))
                    {
                        Directory.CreateDirectory(updateFolderPath);
                    }

                    var request = service.Files.List();
                    request.Q = $"'{folderId}' in parents";
                    request.Fields = "nextPageToken, files(id, name)";
                    var results = request.Execute();
                    int totalFiles = results.Files.Count;
                    int downloadedFiles = 0;

                    foreach (var file in results.Files)
                    {
                        var fileId = file.Id;
                        var fileName = file.Name;
                        var requestDownload = service.Files.Get(fileId);
                        var streamDownload = new MemoryStream();


                        requestDownload.Download(streamDownload);
                        streamDownload.Position = 0;
                        var filePath = Path.Combine(updateFolderPath, fileName);
                        var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                        streamDownload.CopyTo(fileStream);
                        fileStream.Close();
                        downloadedFiles++;
                    }
                    ZipFile.ExtractToDirectory(electronFilePath, updateFolderPath);
                    string setupFilePath = Path.Combine(updateFolderPath, "setup.exe"); // kết hợp đường dẫn của tập tin setup.exe với đường dẫn của thư mục update

                    if (File.Exists(setupFilePath)) // kiểm tra xem tập tin setup.exe có tồn tại không
                    {
                        Process.Start(setupFilePath); // chạy tập tin setup.exe bằng lớp Process
                    }
                }


            }











            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }

            catch
            {
                MessageBox.Show("Có vấn đề về kết nối Internet");

            }
            {
                // Tải thông tin đăng nhập từ đối tượng lưu trữ cục bộ
                string username = Properties.Settings.Default.Username;
                string password = Properties.Settings.Default.Password;

                // Điền thông tin đăng nhập vào các ô tương ứng trên form đăng nhập
                UsernameTbox.Text = username;
                passTbox.Text = password;

                // Chọn CheckBox nếu đã lưu thông tin đăng nhập
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    checkBox1.Checked = true;
                }
            }


        }


        private static Settings GetDefault()
        {
            return Properties.Settings.Default;
        }

        private void regBtn_Click(object sender, EventArgs e)
        {

            RegistrationForm reg = new RegistrationForm();
            reg.ShowDialog();
        }
        private bool rememberMe = false;
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                // Lưu thông tin đăng nhập vào đối tượng lưu trữ cục bộ
                Properties.Settings.Default.Username = UsernameTbox.Text;
                Properties.Settings.Default.Password = passTbox.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                // Xóa thông tin đăng nhập từ đối tượng lưu trữ cục bộ
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }

        }
        private void LogBtn_Click(object sender, EventArgs e)
        {

            #region Condition
            if (string.IsNullOrWhiteSpace(UsernameTbox.Text) &&
           string.IsNullOrWhiteSpace(passTbox.Text))
            {
                MessageBox.Show("Please Fill All The Fields");
                return;
            }
            #endregion







            FirebaseResponse res = client.Get(@"Users/" + UsernameTbox.Text);
            MyUser ResUser = res.ResultAs<MyUser>();// database result

            MyUser CurUser = new MyUser() // USER GIVEN INFO
            {
                Username = UsernameTbox.Text,
                Password = passTbox.Text
            };

            if (MyUser.IsEqual(ResUser, CurUser))
            {

                // Tắt cửa sổ đăng nhập
                this.Hide();

                // Mở cửa sổ RealApp
                Chon_Ung_Dung realAppForm = new Chon_Ung_Dung();
                realAppForm.Show();
            }

            else
            {
                MyUser.ShowError();
            }
        }






        private async void label6_Click_1(object sender, EventArgs e)
        {
            {
                // Lấy thông tin người dùng từ Firebase
                FirebaseResponse res = client.Get(@"Users/" + UsernameTbox.Text);
                MyUser ResUser = res.ResultAs<MyUser>();

                // Kiểm tra xem người dùng có tồn tại trong Firebase không
                if (ResUser == null)
                {
                    MessageBox.Show("Username không tồn tại");
                    return;
                }

                // Khởi tạo một email message
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress("Hoàng Tuấn", "ctump14715@gmail.com"));
                message.To.Add(new MailboxAddress("Tên người nhận", ResUser.Email + "@gmail.com"));
                message.Subject = "Thông tin mật khẩu";

                // Tạo nội dung email
                string body = "Mật khẩu của bạn là: " + ResUser.Password;
                message.Body = new TextPart("plain")
                {
                    Text = body
                };

                // Gửi email
                using (var client = new SmtpClient())
                {
                    await client.ConnectAsync("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    await client.AuthenticateAsync("ctump14715@gmail.com", "zxdltsqdksxwdhxm");
                    await client.SendAsync(message);
                    await client.DisconnectAsync(true);
                }

                MessageBox.Show("Mật khẩu đã được gửi về email của bạn");
            }
        }
        private void label6_MouseMove(object sender, MouseEventArgs e)
        {

            label6.Cursor = Cursors.Hand;
        }
        private void label6_MouseEnter(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Red;
        }
        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.ForeColor = Color.Cyan;

        }

        private void labelVersion_Click(object sender, EventArgs e)
        {

        }
    }

}
