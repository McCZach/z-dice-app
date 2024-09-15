using System.Security.Cryptography;

namespace D_D_Dice
{
    enum dice
    {
        d4 = 0,
        d6 = 1,
        d8 = 2,
        d10 = 3,
        d12 = 4,
        d20 = 5
    }

    public partial class Form1 : Form
    {
        const byte DICE_LIST_SIZE = 12;
        ulong[] diceList;

        const byte TEXTBOX_ARRAY_SIZE = 6;
        TextBox[] textBoxArray;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxArray = new[] { txtD4, txtD6, txtD8,
                                 txtD10, txtD12, txtD20 };

            diceList = new ulong[DICE_LIST_SIZE];

            foreach (TextBox tb in textBoxArray)
            {
                tb.Text = ((ulong)0).ToString();
            }
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult.Clear();

            ulong diceCount, roll,
                sum = 0;

            int diceIndex;
            for (int i = 0; i < TEXTBOX_ARRAY_SIZE; i++)
            {
                diceIndex = int.Parse(Enum.GetName(typeof(dice), i).Substring(1));

                ulong.TryParse(textBoxArray[i].Text, out diceCount);
                diceList[i * 2] = diceCount;

                for (ulong j = 0; j < diceCount; j++)
                {
                    roll = (ulong)RandomNumberGenerator.GetInt32(1, (diceIndex + 1));

                    sum += roll;
                }
                diceList[(i * 2) + 1] = sum;

                sum = 0;
            }

            ulong total = 0;
            for (int i = 0; i < DICE_LIST_SIZE; i += 2)
            {
                txtResult.Text += Enum.GetName(typeof(dice), (i / 2)) + ": Count = " +
                    diceList[i].ToString() + ", Total = " + diceList[i + 1].ToString() + "\r\n";
                
                total += diceList[i + 1];
            }

            txtResult.Text += "Total: " + total.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in textBoxArray)
            {
                tb.Text = ((ulong)0).ToString();
            }

            txtResult.Clear();

            Array.Clear(diceList);
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
