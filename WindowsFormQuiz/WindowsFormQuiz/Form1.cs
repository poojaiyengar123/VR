namespace WindowsFormQuiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //red
            label1.BackColor = Color.Red;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //blue
            label1.BackColor = Color.CornflowerBlue;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            //arial
            label1.Font = new Font("Arial", 20);
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            //algerian
            label1.Font = new Font("Algerian", 15);
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            //chiller
            label1.Font = new Font("Chiller", 25);
        }
    }
}