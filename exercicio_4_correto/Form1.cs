namespace exercicio_4_correto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int idade = int.Parse(txtIdade.Text);

            if (idade >= 16 && idade <= 70)
            {
                MessageBox.Show("Pode votar!");
            }
            else if (idade > 70)
            {
                MessageBox.Show("Pode votar, mas é opcional!");
            }
            else
            {
                MessageBox.Show("Não pode!");
            }
        }
    }
}
