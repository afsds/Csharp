namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {
            decimal media;
            decimal nota1;
            decimal nota2;
            decimal nota3;
            nota1 = Convert.ToDecimal(Nota1.Text);
            nota2 = Convert.ToDecimal(Nota2.Text);
            nota3 = Convert.ToDecimal(Nota3.Text);
            media = ((nota1*2) + (nota2*3) + (nota3*5)) / 10;
            result.Text = media.ToString();
            if (media >= 6)
            {
                sit.Text = "Aprovado";
            }
            else
            {
                sit.Text = "Reprovado";
            }
        }

       
    }
}
    

