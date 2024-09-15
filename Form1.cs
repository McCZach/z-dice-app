namespace D_D_Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtD4.Text = ((ulong)0).ToString();
            txtD6.Text = ((ulong)0).ToString();
            txtD8.Text = ((ulong)0).ToString();
            txtD10.Text = ((ulong)0).ToString();
            txtD12.Text = ((ulong)0).ToString();
            txtD20.Text = ((ulong)0).ToString();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtD4.Clear();
            txtD6.Clear();
            txtD8.Clear();
            txtD10.Clear();
            txtD12.Clear();
            txtD20.Clear();

            txtResult.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnD4Up_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD4.Text, out count);
            txtD4.Text = (++count).ToString();
        }

        private void btnD4Down_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD4.Text, out count);
            txtD4.Text = (--count).ToString();
        }

        private void btnD6Up_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD6.Text, out count);
            txtD6.Text = (++count).ToString();
        }

        private void btnD6Down_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD6.Text, out count);
            txtD6.Text = (--count).ToString();
        }

        private void btnD8Up_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD8.Text, out count);
            txtD8.Text = (++count).ToString();
        }

        private void btnD8Down_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD8.Text, out count);
            txtD8.Text = (--count).ToString();
        }

        private void btnD10Up_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD10.Text, out count);
            txtD10.Text = (++count).ToString();
        }

        private void btnD10Down_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD10.Text, out count);
            txtD10.Text = (--count).ToString();
        }

        private void btnD12Up_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD12.Text, out count);
            txtD12.Text = (++count).ToString();
        }

        private void btnD12Down_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD12.Text, out count);
            txtD12.Text = (--count).ToString();
        }

        private void btnD20Up_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD20.Text, out count);
            txtD20.Text = (++count).ToString();
        }

        private void btnD20Down_Click(object sender, EventArgs e)
        {
            ulong count;
            ulong.TryParse(txtD20.Text, out count);
            txtD20.Text = (--count).ToString();
        }
    }
}
