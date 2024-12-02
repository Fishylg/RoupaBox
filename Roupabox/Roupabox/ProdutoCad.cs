namespace RoupaBox
{
    internal class ProdutoCad
    {
        public string DescPro { get; set; }
        public string MarcaPro { get; set; }
        public string TamPro { get; set; }
        public string CorPro { get; set; }
        public string CatPro { get; set; }
        public double ValPro { get; set; }
        public double PesoPro { get; set; }

        public ProdutoCad(string descPro)
        {
            DescPro = descPro;
        }
    }
}
