namespace exercicio_6
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
            lblTitulo = new Label();
            lblUsuario = new Label();
            lblSenha = new Label();
            lblAutorizacao = new Label();
            lblIdade = new Label();
            btnEnviar = new Button();
            txtUsuario = new TextBox();
            txtSenha = new TextBox();
            txtAutorizacao = new TextBox();
            txtIdade = new TextBox();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(296, 49);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(196, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Preencha os campos abaixo:";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Location = new Point(198, 93);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 1;
            lblUsuario.Text = "Usuário";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(208, 125);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(49, 20);
            lblSenha.TabIndex = 2;
            lblSenha.Text = "Senha";
            // 
            // lblAutorizacao
            // 
            lblAutorizacao.AutoSize = true;
            lblAutorizacao.Location = new Point(23, 155);
            lblAutorizacao.Name = "lblAutorizacao";
            lblAutorizacao.Size = new Size(278, 20);
            lblAutorizacao.TabIndex = 3;
            lblAutorizacao.Text = "Possui autorização especial? Sim ou Não";
            // 
            // lblIdade
            // 
            lblIdade.AutoSize = true;
            lblIdade.Location = new Point(130, 188);
            lblIdade.Name = "lblIdade";
            lblIdade.Size = new Size(127, 20);
            lblIdade.TabIndex = 4;
            lblIdade.Text = "Qual a sua idade?";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(331, 233);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(161, 40);
            btnEnviar.TabIndex = 5;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(307, 90);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(221, 27);
            txtUsuario.TabIndex = 6;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(307, 125);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(221, 27);
            txtSenha.TabIndex = 7;
            // 
            // txtAutorizacao
            // 
            txtAutorizacao.Location = new Point(307, 156);
            txtAutorizacao.Name = "txtAutorizacao";
            txtAutorizacao.Size = new Size(221, 27);
            txtAutorizacao.TabIndex = 8;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(307, 188);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(221, 27);
            txtIdade.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIdade);
            Controls.Add(txtAutorizacao);
            Controls.Add(txtSenha);
            Controls.Add(txtUsuario);
            Controls.Add(btnEnviar);
            Controls.Add(lblIdade);
            Controls.Add(lblAutorizacao);
            Controls.Add(lblSenha);
            Controls.Add(lblUsuario);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblUsuario;
        private Label lblSenha;
        private Label lblAutorizacao;
        private Label lblIdade;
        private Button btnEnviar;
        private TextBox txtUsuario;
        private TextBox txtSenha;
        private TextBox txtAutorizacao;
        private TextBox txtIdade;
    }
}
