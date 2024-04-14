namespace passwordGenerator
{
    public partial class Form1 : Form
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string symbols = "-=!@#$%^&*()_+[]\\{}|;':\",.<>/?";

        public Form1()
        {

            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Text = textBox1.Text;
            int n;
            string Result = "";
            bool isNumeric = int.TryParse(Text, out n);
            if (!isNumeric) 
            {
                return;
            }
            Random random = new Random();
            for (int i = 0; i < int.Parse(Text); i++) 
            {
                int IsCapital = random.Next(0,2);
                string alphabet2 = alphabet;
                if (checkBox2.Checked)
                {
                    alphabet2 += symbols;
                }
                int index = random.Next(alphabet2.Length);
                char key = alphabet2[index];
                if (IsCapital == 0)
                {
                    Result += key.ToString().ToUpper();
                }
                else
                {
                    Result += key.ToString();
                }

            }
            label3.Text = Result;
        }
    }
}
