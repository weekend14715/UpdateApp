using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;


namespace LoginC
{
    public partial class RealApp : Form
    {
        private string selectedFolderPath = null;

        public RealApp()
        {
            InitializeComponent();

            // Truy vấn đường dẫn từ AppData nếu đã lưu trước đó
            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LoginC", "path.txt");
            if (File.Exists(path))
            {
                selectedFolderPath = File.ReadAllText(path);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Xác thực và tạo service
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
            var folderId = "1zSj-nqetVJyaIqA7vQDfH1DUPVmJRR1_";

            if (selectedFolderPath == null)
            {
                var dialog = new FolderBrowserDialog();
                DialogResult result = dialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    selectedFolderPath = dialog.SelectedPath;
                }
            }

            if (selectedFolderPath != null)
            {
                // Tải xuống các file từ thư mục
                var request = service.Files.List();
                request.Q = $"'{folderId}' in parents";
                request.Fields = "nextPageToken, files(id, name)";
                var results = request.Execute();
                foreach (var file in results.Files)
                {
                    var fileId = file.Id;
                    var fileName = file.Name;
                    var requestDownload = service.Files.Get(fileId);
                    var streamDownload = new MemoryStream();
                    requestDownload.Download(streamDownload);
                    streamDownload.Position = 0;
                    var filePath = Path.Combine(selectedFolderPath, fileName);
                    var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                    streamDownload.CopyTo(fileStream);
                    fileStream.Close();
                }

                MessageBox.Show("Cập nhật hoàn tất.");
                // Lưu đường dẫn vào AppData
                string directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "LoginC");
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                File.WriteAllText(Path.Combine(directory, "path.txt"), selectedFolderPath);

            }
        }

        private void RealApp_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();
            selectedFolderPath = dialog.SelectedPath;
        }
    }
}
