namespace GeradorNfseAPI.Entities
{
    public class NFSe
    {
        public string NomePrestador { get; set; }
        public string CNPJPrestador { get; set; }
        public string InscricaoPrestador { get; set; }
        public string nomeTomador { get; set; }
        public string CNPJTomador { get; set; }
        public string InscricaoTomador { get; set; }
        public int NumeroNota { get; set; }
        public string DataEmissao { get; set; }
        public string Valor { get; set; }
        public string Descricao { get; set; }
        public string LocalServico { get; set; } 
    }
}
