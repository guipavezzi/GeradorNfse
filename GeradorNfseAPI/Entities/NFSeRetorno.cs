using System.Xml.Serialization;

namespace GeradorNfseAPI.Entities.NfseRetorno
{
    public class Prestador
    {
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string InscricaoMunicipal { get; set; }
    }

    public class Tomador
    {
        public string Nome { get; set; }

        public string CNPJ { get; set; }

        public string InscricaoMunicipal { get; set; }
    }

    public class DadosNota
    {
        public int Numero { get; set; }

        public string DataEmissao { get; set; }

        public string ValorTotal { get; set; }
    }

    public class OutrasInformacoes
    {
        public string LocalPrestacao { get; set; }
    }

    [XmlRoot("Nfse")]
    public class NfseRetorno
    {
        public Prestador Prestador { get; set; }

        public Tomador Tomador { get; set; }

        public DadosNota DadosNota { get; set; }

        public string Descricao { get; set; }

        public OutrasInformacoes OutrasInformacoes { get; set; }
    }
}