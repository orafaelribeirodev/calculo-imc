namespace projeto02
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtAltura.Clear();
            cmbsexo.Text = "";
            txtNome.Focus();
        }

        private void textnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPesoideal_Click(object sender, EventArgs e)
        {
            try // tente fazer tudo isso 
            {
                double Altura = 0, Pesoideal = 0;
                Altura = double.Parse(txtAltura.Text);
                if (cmbsexo.Text == "Feminino")
                {
                    Pesoideal = (62.7 * Altura) - 44.7;
                    MessageBox.Show(txtNome.Text + "Seu Peso ideal é :" + Pesoideal.ToString() + "KG", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cmbsexo.Text == "Mascolino")
                {
                    Pesoideal = (72.7 * Altura) - 58;
                    MessageBox.Show(txtNome.Text + "Seu Peso ideal é :" + Pesoideal.ToString() + "KG", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Escolha o sexo", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception) // se nao faça isso
            {

                MessageBox.Show("Verifique os Valores Informados", "Peso Ideal", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}