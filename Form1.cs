using System.Data;

namespace Calculator1
{
    public partial class Form1 : Form
    {
        private string currentCalculation = "";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            currentCalculation += (sender as Button).Text;
            txtOutput.Text = currentCalculation;
        }

        private void button_Equals_Click(object sender, EventArgs e)
        {
            string formattedCalculation = currentCalculation.ToString();
            try
            {
                txtOutput.Text = new DataTable().Compute(formattedCalculation, null).ToString();
                currentCalculation = txtOutput.Text;
            }
            catch (Exception ex)
            {
                txtOutput.Text = "ERROR";
                currentCalculation = "";
            }
        }
        private void button_Clear_click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            currentCalculation = "";
        }

        private void button_clearEntery_click(object sender, EventArgs e)
        {
            if (currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
            }
            txtOutput.Text = currentCalculation;
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button13_BackColorChanged(object sender, EventArgs e)
        {

        }
    }

}