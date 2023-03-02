namespace Magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            if (label1.Text != "")
            {
                form2.checkBox1.Checked = true;
                form2.numericUpDown1.Value = Convert.ToInt32(label1.Text);
            }

            form2.ShowDialog();

            int a = (int)form2.numericUpDown1.Value;

            if (form2.checkBox1.Checked == true)
            {
                label1.Text = a.ToString();
            }
            else label1.Text = "";
        }
    }
}