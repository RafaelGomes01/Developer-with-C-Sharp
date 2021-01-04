namespace Code
{
    public static class Convesor
    {
        private static float cotacaoDolar = 5.10f;
        private static float cotacaoEuro = 6.28f;

        // Dolar - 5.10
        // Real para Dolar
        public static float ConverterRealParaDolar(float valorReal){
            return valorReal * cotacaoDolar;
        }
        // Dolar para Real
        public static float ConverterDolarParaReal(float valorDolar){
            return valorDolar / cotacaoDolar;
        }

        // Euro - 6.28
        // Real para Euro
        public static float ConverterRealParaEuro(float valorReal){
            return valorReal * cotacaoEuro;
        }
        // Euro para Real
        public static float ConverterEuroParaReal(float valorDolar){
            return valorDolar / cotacaoEuro;
        }

        
    }
}