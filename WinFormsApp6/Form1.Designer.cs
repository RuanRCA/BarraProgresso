namespace WinFormsApp6
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
            lblNumero = new Label();
            mtbNumeros = new MaskedTextBox();
            rtbNumeros = new RichTextBox();
            pgbPorcentagem = new ProgressBar();
            lblPorcentagem = new Label();
            btnOk = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitulo.Location = new Point(288, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(320, 47);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Insira 10 Números";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Location = new Point(142, 123);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(51, 15);
            lblNumero.TabIndex = 1;
            lblNumero.Text = "Número";
            // 
            // mtbNumeros
            // 
            mtbNumeros.Location = new Point(213, 120);
            mtbNumeros.Mask = "99";
            mtbNumeros.Name = "mtbNumeros";
            mtbNumeros.Size = new Size(100, 23);
            mtbNumeros.TabIndex = 2;
            mtbNumeros.ValidatingType = typeof(int);
            // 
            // rtbNumeros
            // 
            rtbNumeros.Location = new Point(442, 107);
            rtbNumeros.Name = "rtbNumeros";
            rtbNumeros.Size = new Size(166, 163);
            rtbNumeros.TabIndex = 3;
            rtbNumeros.Text = "";
            // 
            // pgbPorcentagem
            // 
            pgbPorcentagem.Location = new Point(97, 368);
            pgbPorcentagem.Name = "pgbPorcentagem";
            pgbPorcentagem.Size = new Size(600, 58);
            pgbPorcentagem.TabIndex = 4;
            pgbPorcentagem.Click += pgbPorcentagem_Click;
            // 
            // lblPorcentagem
            // 
            lblPorcentagem.AutoSize = true;
            lblPorcentagem.Location = new Point(378, 386);
            lblPorcentagem.Name = "lblPorcentagem";
            lblPorcentagem.Size = new Size(0, 15);
            lblPorcentagem.TabIndex = 5;
            // 
            // btnOk
            // 
            btnOk.BackColor = Color.LimeGreen;
            btnOk.ForeColor = SystemColors.ControlText;
            btnOk.Location = new Point(213, 247);
            btnOk.Name = "btnOk";
            btnOk.Size = new Size(100, 40);
            btnOk.TabIndex = 6;
            btnOk.Text = "Ok";
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += btnOk_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOk);
            Controls.Add(lblPorcentagem);
            Controls.Add(pgbPorcentagem);
            Controls.Add(rtbNumeros);
            Controls.Add(mtbNumeros);
            Controls.Add(lblNumero);
            Controls.Add(lblTitulo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblNumero;
        private MaskedTextBox mtbNumeros;
        private RichTextBox rtbNumeros;
        private ProgressBar pgbPorcentagem;
        private Label lblPorcentagem;
        private Button btnOk;
    }
}