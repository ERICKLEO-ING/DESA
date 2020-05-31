namespace EasyFactWebService.Controllers.EasyFact
{
    using global::EasyFact.Models;
    using global::EasyFact.Controller;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Web;
    using System.Web.Http;

    [BasicAuthorize]
    //[Authorize]
    public class DocumentoController : ApiController
    {
        public DocumentoController()
        {
        }

        [HttpPost]
        public List<string> Post(DocumentoElectronicoModel DocumentoFE)
        {
            DocumentoElectronicoController Fact = new DocumentoElectronicoController();
            List<string> Respuesta= new List<string>();
            try
            {
                Respuesta = Fact.RecibeDocumentoElectronio(DocumentoFE);

                //Respuesta[0]="0";
                //Respuesta.Add("Operacion Existosa");
                //Respuesta.Add("dahnsjdkasdbjkabdkjasbdjbajdkbajkdbajkdbasjkbdajkbdjbasjkbjkadbjkasd");
                return Respuesta;
            }
            catch (Exception ex)
            {
                Respuesta.Add("1");
                Respuesta.Add(ex.Message);
                return Respuesta;
            }
        }
    }

}