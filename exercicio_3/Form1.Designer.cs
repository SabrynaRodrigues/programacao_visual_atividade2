namespace exercicio_3
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
            txtNumero = new TextBox();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(315, 56);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(121, 20);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Digite o número:";
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(274, 96);
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(209, 27);
            txtNumero.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(299, 145);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(153, 35);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += Enviar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnviar);
            Controls.Add(txtNumero);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private TextBox txtNumero;
        private Button btnEnviar;
    }
}
