namespace Template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.Items.Add("Элемент 1");
            listBox1.Items.Add("Элемент 2");
            listBox1.Items.Add("Элемент 3");
            listBox1.Items.Add("Элемент 4");
            listBox1.Items.RemoveAt(0);
            Button helloButton = new Button();
            helloButton.Text = "Привет";
            groupBox1.Controls.Add(helloButton);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            anwerLabel.Text = (Convert.ToInt32(textBox1.Text) + Convert.ToInt32(textBox2.Text) + Convert.ToInt32(textBox3.Text)).ToString();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            textBox3.Hide();
            label3.Hide();
            label5.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.Text = "0";
            textBox3.Show();
            label3.Show();
            label5.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            int selectedItem = listBox1.SelectedIndex;
            listBox1.Items.RemoveAt(selectedItem);
        }
    }
}