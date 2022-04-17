namespace лр6._12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {

            String a, a0;
            a0 = "";
            String[] aa = listBox1.Text.Split(' ');
            for (int i = 0; i < aa.Count(); i++)
            {
                a = aa[i].Substring(1, aa[i].Length - 1);
                a0 += (a + " ");
            }
            label1.Text = a0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }
    }
}