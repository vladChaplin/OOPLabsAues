namespace lab1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection()
            { 
                "1234",
                "2345",
                "3456",
                "4545",
                "5765",
                "6764",
                "7765",
                "8349",
                "9024"
            };
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] arrText = textBox1.Text.ToCharArray();
            int[] arrInt = new int[arrText.Length];

            for(int i = 0; i < arrText.Length; i++)
            {
                arrInt[i] = (int)Char.GetNumericValue(arrText[i]);
            }

            int max = arrInt[0]; 
            int min = arrInt[0];

            for (int i = 0; i < arrInt.Length; i++)
            {
                if(arrInt[i] > max)
                {
                    max = arrInt[i];
                }
                if(arrInt[i] < min)
                {
                    min = arrInt[i];
                }
            }

            label4.Text = max + "";
            label5.Text = min + "";
            label4.Visible = true;
            label5.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Visible = false;
            label5.Visible = false;
        }
    }
}