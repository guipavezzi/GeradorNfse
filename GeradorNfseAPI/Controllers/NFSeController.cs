using GeradorNfseAPI.Entities;
using GeradorNfseAPI.Entities.NfseRetorno;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Xml.Serialization;
using UtilsNfse = GeradorNfseAPI.Utils.NfseUtils;  

namespace GeradorNfseAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NFSeController : ControllerBase
    {



        [HttpPost]
        public string Post([FromBody] NFSe model)
        {
            string xml;

            try
            {
                xml = UtilsNfse.MontarXml(model);

                UtilsNfse.ValidarXML(xml);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return xml;
        }
    }
}
