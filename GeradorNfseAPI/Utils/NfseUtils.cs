using GeradorNfseAPI.Entities;
using GeradorNfseAPI.Entities.NfseRetorno;
using System.Reflection;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace GeradorNfseAPI.Utils
{
    public class NfseUtils
    {
        public static string MontarXml(NFSe model)
        {
            NfseRetorno nfse = new NfseRetorno
            {
                ConsultarNfseEnvio = new ConsultarNfseEnvio
                {
                    Id = "123",
                    Prestador = new Prestador
                    {
                        TcIdentificacaoPrestador = new TcIdentificacaoPrestador
                        {
                            CpfCnpj = new CpfCnpj
                            {
                                Cnpj = model.CNPJPrestador
                            },
                        },
                        NomePrestador = model.NomePrestador,
                        InscricaoMunicipal = model.InscricaoPrestador
                    },
                    NumeroNfse = model.NumeroNota,
                    PeriodoEmissao = new PeriodoEmissao
                    {
                        DataFinal = model.DataEmissao,
                        DataInicial = model.DataEmissao
                    },
                    Tomador = new Tomador
                    {
                        TcIdentificacaoTomador = new TcIdentificacaoTomador
                        {
                            CpfCnpj = new CpfCnpj
                            {
                                Cnpj = model.CNPJTomador
                            },
                        },
                        NomeTomador = model.nomeTomador,
                        InscricaoMunicipal = model.InscricaoTomador,
                    },
                    IntermediarioServico = new IntermediarioServico
                    {
                        TcIdentificacaoIntermediarioServico = ""
                    },
                    InformacoesAdicionais = new InformacoesAdicionais
                    {
                        ValorServico = model.Valor,
                        Descricao = model.Descricao,
                        Local = model.LocalServico
                    }

                }
            };

            var serializer = new XmlSerializer(typeof(NfseRetorno));

            StringWriter sw = new StringWriter();

            serializer.Serialize(sw, nfse);

            string xml = sw.ToString();

            return xml;
        }


        public static void ValidarXML(string xml)
        {

            try
            {
                XmlReaderSettings settings= new XmlReaderSettings();
                settings.ValidationType = ValidationType.Schema;
                settings.Schemas.Add("http://www.ginfes.com.br/servico_consultar_nfse_envio_v03.xsd", "./Schemas/servico_consultar_nfse_envio_v03.xsd");
                settings.Schemas.Add("http://www.ginfes.com.br/tipos_v03.xsd", "./Schemas/tipos_v03.xsd");
                settings.Schemas.Add("http://www.w3.org/2000/09/xmldsig#", "./Schemas/xmldsig-core-schema20020212_v03.xsd");
                settings.ValidationEventHandler += new ValidationEventHandler(ValidationEventHandler);

                using(XmlReader reader = XmlReader.Create(new StringReader(xml), settings))
                {
                    while(reader.Read()) { }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        static void ValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Error)
            {
                throw new Exception(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Warning)
            {
                throw new Exception($"Validation Warning: {e.Message}");
            }
        }
    }
}
