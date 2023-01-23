namespace ITEC145__Section_C__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            ofd.ShowDialog();

            txtRead.Text = ofd.FileName;
        }
    }
}