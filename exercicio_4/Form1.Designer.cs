namespace exercicio_4
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
            txtNum = new TextBox();
            lblTitulo = new Label();
            btnEnviar = new Button();
            SuspendLayout();
            // 
            // txtNum
            // 
            txtNum.Location = new Point(218, 154);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(294, 27);
            txtNum.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(167, 100);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(413, 20);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Digite o valor para saber se é múltiplo de 5 ou maior que 50:";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(266, 216);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(191, 36);
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
            Controls.Add(lblTitulo);
            Controls.Add(txtNum);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNum;
        private Label lblTitulo;
        private Button btnEnviar;
    }
}
