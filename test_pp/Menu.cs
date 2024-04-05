using System;
using System.Windows.Forms;

namespace test_pp
{
    public partial class startForm : Form
    {
        public startForm()
        {
            InitializeComponent();
        }
        private void info_btn_Click(object sender, EventArgs e)
        {
            Info nf = new Info();
            this.Hide();
            nf.ShowDialog();
            this.Show();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void startTest_btn_Click(object sender, EventArgs e)
        {
            TestForm nf = new TestForm();
            this.Hide();
            nf.ShowDialog();
            this.Show();
        }
    }
}
