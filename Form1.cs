using Microsoft.VisualBasic.Devices;

namespace SimulacroParcialForms
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

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            if (textGeneratriz.Text == "" || textAltura.Text == "" || textRadio.Text == "")
                MessageBox.Show("Ingrese valores para los 3 campos por favor");
            else
            {
                double NumeroGeneratriz = double.Parse(textGeneratriz.Text);
                double NumeroAltura = double.Parse(textAltura.Text);
                double NumeroRadio = double.Parse(textRadio.Text);

                double Area = Math.PI * NumeroRadio * (NumeroRadio + NumeroGeneratriz);
                double Volumen = (Math.PI * Math.Pow(NumeroRadio, 2) * NumeroAltura) / 3;

                textResultadoArea.Text = Area.ToString(".000") + " cm�";
                textResultadoVolumen.Text = Volumen.ToString(".000") + " cm�";
            }
        }
        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            textGeneratriz.Text = "0";
            textAltura.Text = "0";
            textRadio.Text = "0";
            textResultadoArea.Text = "0";
            textResultadoVolumen.Text = "0";
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("�Est�s seguro de que quieres salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ResultadoAreaText(object sender, EventArgs e)
        {

        }

        private void ResoltadoVolumenText(object sender, EventArgs e)
        {

        }

        private void GeneratrizTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textGeneratriz.Text, out double NumeroGeneratriz)) ;
            else
            {
                textGeneratriz.Text = "0";
                MessageBox.Show("Ingrese un valor de generatriz v�lido");
            }
        }

        private void AlturaTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textAltura.Text, out double NumeroAltura)) ;
            else
            {
                textAltura.Text = "0";
                MessageBox.Show("Ingrese un valor de altura v�lido");
            }
        }

        private void RadioTextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textRadio.Text, out double NumeroRadio)) ;
            else
            {
                textRadio.Text = "0";
                MessageBox.Show("Ingrese un valor de radio v�lido");
            }
        }

        private void ResultadoVolumenText(object sender, EventArgs e)
        {

        }
    }
}