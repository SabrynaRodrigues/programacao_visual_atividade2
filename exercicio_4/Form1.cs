namespace exercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNum.Text);

            if (num % 5 == 0 || num > 50)
            {
                MessageBox.Show("É múltiplo de 5 ou maior que 50");
            }
            else
            {
                MessageBox.Show("Valor errado!");
            }
        }
    }
}
