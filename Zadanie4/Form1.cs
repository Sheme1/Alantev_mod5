namespace Zadanie4
{
    public partial class Form1 : Form
    {
        private PictureBox pictureBox;
        private Button selectButton;
        private OpenFileDialog openFileDialog;
        public Form1()
        {
            InitializeComponent();
            pictureBox = pictureBox1;
            selectButton = button1;
            openFileDialog = new OpenFileDialog
            {
                Filter = "Изображения|*.jpg;*.jpeg;*.png;*.bmp"
            };
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox.BackgroundImage = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}
