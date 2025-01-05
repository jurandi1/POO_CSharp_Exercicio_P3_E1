namespace POO_CSharp_Exercicio_P3_E1
{
    internal class ConversorDeMoeda
    {
        public static double Iof = 6.0;
        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
