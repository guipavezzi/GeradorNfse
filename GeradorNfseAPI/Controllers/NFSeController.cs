using GeradorNfseAPI.Entities;
using GeradorNfseAPI.Entities.NfseRetorno;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Xml.Serialization;

namespace GeradorNfseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NFSeController : ControllerBase
    {



        [HttpPost]
        public string Post([FromBody] NFSe model)
        {

            NfseRetorno nfse = new NfseRetorno 
            {
                Prestador = new Prestador
                {
                    Nome = model.NomePrestador,
                    CNPJ = model.CNPJPrestador,
                    InscricaoMunicipal = model.InscricaoPrestador
                },
                Tomador = new Tomador
                {
                    Nome = model.nomeTomador,
                    CNPJ = model.CNPJTomador,
                    InscricaoMunicipal = model.InscricaoTomador
                },
                DadosNota = new DadosNota 
                {
                    Numero = model.NumeroNota,
                    DataEmissao = model.DataEmissao,
                    ValorTotal = model.Valor,
                },
                Descricao = model.Descricao,
                OutrasInformacoes = new OutrasInformacoes
                {
                    LocalPrestacao = model.LocalServico
                }
            };

            var serializer = new XmlSerializer(typeof(NfseRetorno));

            StringWriter sw = new StringWriter();

            serializer.Serialize(sw, nfse);

            string xml = sw.ToString();

            return xml;
        }
    }
}
