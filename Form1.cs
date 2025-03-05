namespace jurnalmod3_103022300069
{
    public partial class Form1 : Form
    {
        int angka_1, angka_2;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            angka_1 = int.Parse(lblOutput.Text);
            lblOutput.Text = "";
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "1";
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "2";
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "3";
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "4";
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "5";
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "6";
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "7";
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "8";
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            lblOutput.Text += "9";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            angka_2 = int.Parse(lblOutput.Text);
            int hasil = angka_2 + angka_1;
            lblOutput.Text = hasil.ToString();
        }
    }
}
