using System.Diagnostics;

namespace Recurivo_e_iterativo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Stopwatch stopwatch = new Stopwatch();

        private void BtnRecurcivo_Click(object sender, EventArgs e)
        {

            stopwatch.Start();
            int number = Convert.ToInt32( TextRecurcive.Text);
            LstViewRecurcivo.Items.Clear();
            FactorialRecursivo(number);
            stopwatch.Stop();
            LblTimeRecursivo.Text = stopwatch.ElapsedMilliseconds + "ms";

        }

        private void BtnIterativo_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            int number = Convert.ToInt32(TextIterativo.Text);
            LstViewIterativo.Items.Clear();
            FactorialIterativo(number);
            stopwatch.Stop();
            LblTimeIterativo.Text = stopwatch.ElapsedMilliseconds + "ms";

        }


        int FactorialIterativo(int n)
        {
            int resultado = 1;
            for (int i = 1; i <= n; i++)
            {
                resultado = resultado * i;
                LstViewIterativo.Items.Add(Convert.ToString(resultado));
            }
            return resultado;
        }

        int FactorialRecursivo(int n)
        {

            if (n == 0 || n == 1)
            {
                return 1;
            }
            int result = n * FactorialRecursivo(n - 1);
            LstViewRecurcivo.Items.Add(Convert.ToString(result));
            return result;
        }

    }
}
