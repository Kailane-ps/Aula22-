namespace _444
{
    public static class conversor
    {
        private static float CotacaoDolar = 5.24f;

        public static float RealParaDolar(float ValorRS){
            return ValorRS / CotacaoDolar;
        }
        public static float DolarParaReal(float ValorUS){
            return CotacaoDolar * ValorUS;
        }
        //MINHA PARTE
        private static float CotacaoEuro = 5.93f;

        public static float RealParaEuro(float ValorRS){
            return ValorRS / CotacaoEuro;
        }    
        public static float EuroParaReal(float ValorEU){
            return CotacaoEuro * ValorEU;
        }
    }
}
