namespace atividade2_exer2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            var user = txtUsuario.Text;
            var senha_ = txtSenha.Text;

            if (user == "Sabryna" && senha_ == "1234")
            {
                MessageBox.Show("Logado com sucesso!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
        }
    }
}
