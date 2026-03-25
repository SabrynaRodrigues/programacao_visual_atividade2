namespace exercicio_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Enviar_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(txtNumero.Text);

            if (num % 2 == 0 && num > 100)
            {
                MessageBox.Show("O número é par e maior que 100");
            }
            else
            {
                MessageBox.Show("O número é ímpar e menor que 100.");
            }
        }
    }
}
