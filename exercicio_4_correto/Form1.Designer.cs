namespace exercicio_4_correto
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
            txtIdade = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(212, 46);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(341, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Verifique se está apto para votar, digite sua idade:";
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(248, 91);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(263, 27);
            txtIdade.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(290, 140);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(167, 39);
            btnEnviar.TabIndex = 2;
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
            Controls.Add(txtIdade);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtIdade;
        private Button btnEnviar;
    }
}
