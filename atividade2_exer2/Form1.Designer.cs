namespace atividade2_exer2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            lblTitulo = new Label();
            lblSenha = new Label();
            lblUsuario = new Label();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(191, 106);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(351, 27);
            txtUsuario.TabIndex = 0;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(191, 157);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(351, 27);
            txtSenha.TabIndex = 1;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(294, 54);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(156, 20);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "Digite usuário e senha";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(94, 160);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 3;
            lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(94, 99);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuário";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(288, 214);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(162, 44);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(lblUsuario);
            Controls.Add(lblSenha);
            Controls.Add(lblTitulo);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtSenha;
        private Label lblTitulo;
        private Label lblSenha;
        private Label lblUsuario;
        private Button btnEnviar;
    }
}
