namespace Atividade2
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
            lblVerificar = new Label();
            txtboxValor = new TextBox();
            btnEnviar = new Button();
            lblExercicio = new Label();
            SuspendLayout();
            // 
            // lblVerificar
            // 
            lblVerificar.AutoSize = true;
            lblVerificar.Location = new Point(264, 94);
            lblVerificar.Name = "lblVerificar";
            lblVerificar.Size = new Size(278, 20);
            lblVerificar.TabIndex = 0;
            lblVerificar.Text = "Verifique se o número está entre 10 e 50:";
            // 
            // txtboxValor
            // 
            txtboxValor.Location = new Point(320, 131);
            txtboxValor.Name = "txtboxValor";
            txtboxValor.Size = new Size(125, 27);
            txtboxValor.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(336, 174);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 2;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // lblExercicio
            // 
            lblExercicio.AutoSize = true;
            lblExercicio.Location = new Point(350, 47);
            lblExercicio.Name = "lblExercicio";
            lblExercicio.Size = new Size(80, 20);
            lblExercicio.TabIndex = 3;
            lblExercicio.Text = "Exercício 1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblExercicio);
            Controls.Add(btnEnviar);
            Controls.Add(txtboxValor);
            Controls.Add(lblVerificar);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblVerificar;
        private TextBox txtboxValor;
        private Button btnEnviar;
        private Label lblExercicio;
    }
}
