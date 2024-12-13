namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pgbPorcentagem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            mtbNumeros.Focus();
            rtbNumeros.Text = rtbNumeros.Text + mtbNumeros.Text + "\n";

            if (pgbPorcentagem.Value<=90 )
            {
                pgbPorcentagem.Value += 10;
                lblPorcentagem.Text = pgbPorcentagem.Value + "%";
            }
            else 
            {              
                btnOk.Visible = false;
                lblPorcentagem.Visible = false;
                mtbNumeros.Visible = false;
                lblNumero.Visible = false;
                MessageBox.Show("Você atingiu o limite");              
            }
        }
    }
}