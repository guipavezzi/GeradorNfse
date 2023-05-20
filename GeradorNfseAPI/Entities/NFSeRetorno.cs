using System.Xml.Serialization;

namespace GeradorNfseAPI.Entities.NfseRetorno
{
    // using System.Xml.Serialization;
    // XmlSerializer serializer = new XmlSerializer(typeof(Nfse));
    // using (StringReader reader = new StringReader(xml))
    // {
    //    var test = (Nfse)serializer.Deserialize(reader);
    // }

    [XmlRoot(ElementName = "CpfCnpj")]
    public class CpfCnpj
    {

        [XmlElement(ElementName = "Cnpj")]
        public string Cnpj { get; set; }
    }

    [XmlRoot(ElementName = "tcIdentificacaoPrestador")]
    public class TcIdentificacaoPrestador
    {

        [XmlElement(ElementName = "CpfCnpj")]
        public CpfCnpj CpfCnpj { get; set; }

        
    }

    [XmlRoot(ElementName = "Prestador")]
    public class Prestador
    {

        [XmlElement(ElementName = "tcIdentificacaoPrestador")]
        public TcIdentificacaoPrestador TcIdentificacaoPrestador { get; set; }

        [XmlElement(ElementName = "nomePrestador")]
        public string NomePrestador { get; set; }

        [XmlElement(ElementName = "InscricaoMunicipal")]
        public string InscricaoMunicipal { get; set; }
    }

    [XmlRoot(ElementName = "PeriodoEmissao")]
    public class PeriodoEmissao
    {

        [XmlElement(ElementName = "DataInicial")]
        public string DataInicial { get; set; }

        [XmlElement(ElementName = "DataFinal")]
        public string DataFinal { get; set; }
    }

    [XmlRoot(ElementName = "tcIdentificacaoTomador")]
    public class TcIdentificacaoTomador
    {

        [XmlElement(ElementName = "CpfCnpj")]
        public CpfCnpj CpfCnpj { get; set; }
    }

    [XmlRoot(ElementName = "Tomador")]
    public class Tomador
    {

        [XmlElement(ElementName = "tcIdentificacaoTomador")]
        public TcIdentificacaoTomador TcIdentificacaoTomador { get; set; }

        [XmlElement(ElementName = "NomeTomador")]
        public string NomeTomador { get; set; }

        [XmlElement(ElementName = "InscricaoMunicipal")]
        public string InscricaoMunicipal { get; set; }
    }

    [XmlRoot(ElementName = "IntermediarioServico")]
    public class IntermediarioServico
    {

        [XmlElement(ElementName = "tcIdentificacaoIntermediarioServico")]
        public object TcIdentificacaoIntermediarioServico { get; set; }
    }

    [XmlRoot(ElementName = "ConsultarNfseEnvio")]
    public class ConsultarNfseEnvio
    {

        [XmlElement(ElementName = "Prestador")]
        public Prestador Prestador { get; set; }

        [XmlElement(ElementName = "NumeroNfse")]
        public int NumeroNfse { get; set; }

        [XmlElement(ElementName = "PeriodoEmissao")]
        public PeriodoEmissao PeriodoEmissao { get; set; }

        [XmlElement(ElementName = "Tomador")]
        public Tomador Tomador { get; set; }

        [XmlElement(ElementName = "IntermediarioServico")]
        public IntermediarioServico IntermediarioServico { get; set; }

        [XmlAttribute(AttributeName = "Id")]
        public string Id { get; set; }

        public InformacoesAdicionais InformacoesAdicionais { get; set; }

    }


    [XmlRoot(ElementName = "InformacoesAdicionais")]
    public class InformacoesAdicionais
    {
        [XmlElement(ElementName = "ValorServico")]
        public string ValorServico { get; set; }

        [XmlElement(ElementName = "Descricao")]
        public string Descricao { get; set; }

        [XmlElement(ElementName = "Local")]
        public string Local { get; set; }
    }

    [XmlRoot(ElementName = "Nfse")]
    public class NfseRetorno
    {

        [XmlElement(ElementName = "ConsultarNfseEnvio")]
        public ConsultarNfseEnvio ConsultarNfseEnvio { get; set; }

        [XmlAttribute(AttributeName = "xsi")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "xsd")]
        public string Xsd { get; set; }

        [XmlAttribute(AttributeName = "schemaLocation")]
        public string SchemaLocation { get; set; }

    }
}