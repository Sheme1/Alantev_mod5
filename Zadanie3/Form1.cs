namespace Zadanie3
{
    public partial class Form1 : Form
    {
        private ListBox tasks;
        private TextBox input;
        
        public Form1()
        {
            InitializeComponent();
            tasks = listBox1;
            input = textBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tasks.Items.Add(input.Text);
            input.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tasks.Items.Remove(tasks.SelectedItem);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int index = tasks.SelectedIndex;
            if (index != -1)
            {
                tasks.Items[index] = tasks.Items[index] + " (выполнено)";
            }
        }
    }

}