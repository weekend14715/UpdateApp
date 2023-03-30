using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginC
{
    public partial class Chon_Ung_Dung : Form
    {
        public Chon_Ung_Dung()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Tắt cửa sổ đăng nhập
            this.Hide();

            // Mở cửa sổ RealApp
            RealApp realAppForm = new RealApp();
            realAppForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nhietamke realAppForm = new Nhietamke();
            realAppForm.Show();
        }

        private void Chon_Ung_Dung_Load(object sender, EventArgs e)
        {

        }
    }
}
