namespace exercicio_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            int idade_ = Convert.ToInt32(txtIdade.Text);
            var usuario_ = txtUsuario.Text;
            var senha_ = txtSenha.Text;
            var autorizacao_ = txtAutorizacao.Text; 

            if (idade_ >= 18 && usuario_ == "admin" && senha_ == "123" && autorizacao_ == "Sim" && idade_ >= 18)
            {
                MessageBox.Show("Acesso liberado!");
            }
            else if (autorizacao_ == "Sim" && idade_ >= 16)
            {
                MessageBox.Show("Acesso Liberado!");
            }
            else
            {
                MessageBox.Show("Acesso negado!");
            }
        }
    }
}
