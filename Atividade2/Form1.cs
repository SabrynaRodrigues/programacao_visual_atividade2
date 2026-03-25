namespace Atividade2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(txtboxValor.Text);

            if (valor >= 10 && valor <= 50)
            {
                MessageBox.Show("Está no intervalo!");
                return;
            }
            MessageBox.Show("Valor errado!");
        }
    }
}
