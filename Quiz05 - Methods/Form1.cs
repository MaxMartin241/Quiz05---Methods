using Microsoft.VisualBasic;

namespace Quiz05___Methods
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void bonusButton_Click(object sender, EventArgs e)
        {
            Form3 Form3 = new Form3();
            Form3.Show();
            Form3.BackColor = Color.Green;
            Refresh();

            Thread.Sleep(500);
            Refresh();
            Form3.BackColor = Color.Red;
            Form3.BackColor = Color.Green;
            Refresh();

            Thread.Sleep(500);
            Refresh();
            Form3.BackColor = Color.Red;
            Form3.BackColor = Color.Green;
            Refresh();

            Thread.Sleep(500);
            Refresh();
            Form3.BackColor = Color.Red;
            Form3.BackColor = Color.Green;
            Refresh();

            Thread.Sleep(500);
            Refresh();
            Form3.BackColor = Color.Red;
            Form3.BackColor = Color.Green;
            Refresh();

            Thread.Sleep(500);
            Refresh();
            Form3.BackColor = Color.Red;
            
        }

        private void q1Button_Click(object sender, EventArgs e)
        {
            genNumber();
        }
        private void genNumber()
        {
            Random numberGen = new Random();
            int number = 0;
            number = numberGen.Next(1, 11);
            outputLabel.Text = number.ToString();
        }

        private void q2Button_Click(object sender, EventArgs e)
        {
            productNumber();

        }
        private void productNumber()
        {
            int num = 0;
            for (int i = 0; i < 10; i++)
            {
                num = num + i;
            }
            outputLabel.Text = num.ToString();
        }

        private void q3Button_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(aTextBox.Text);
            double b = Convert.ToDouble(bTextBox.Text);

            
            double c = triangleCalc(a, b);

            outputLabel.Text = c.ToString("F") + " is the length of the hypotenuse";
        }

        private double triangleCalc(double a, double b)
        {
            double c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
    }
}
