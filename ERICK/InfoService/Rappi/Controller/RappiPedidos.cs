using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using InfoService.Rappi.Model;
namespace InfoService.Rappi.Controller
{
    public class RappiPedidos
    {
        public string ConsultarToken()
        {
            string Valor = string.Empty;
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    TokenRappi TR = new TokenRappi();
                    TR.token = "EoC_*ll=W6CBQh9mzR5r4xw!208Z4|ZIel9dLtWr";
                    //DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(List<EstadoPedidoMamboBE>));
                    //ser.WriteObject(ms, _EstadoPedidoMamboBE);
                    string json = JsonConvert.SerializeObject(TR, Formatting.None);
                    string requestBody = json.Replace("\r\n", "");

                    //string resourceUrl = "/gueststays";
                    //string credentials = "infhotel:4XQ2850GU3hK";

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://microservices.dev.rappi.com/api/restaurants-integrations-public-api/login");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
                    //httpWebRequest.Headers.Add("Api-Key", "" + APIKEY);
                    //httpWebRequest.Accept = "application/vnd.pardos.v1+json";
                    using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    {
                        streamWriter.Write(requestBody);
                        streamWriter.Flush();
                        streamWriter.Close();
                        var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                        if (httpResponse.StatusCode == HttpStatusCode.OK)
                        {
                            Valor = httpResponse.Headers["X-Auth-Int"].ToString();
                        }
                        //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        //{
                        //    Valor=streamReader.ReadToEnd();
                        //    //txtResultado.Text = result.ToString();

                        //}
                    }
                }
                return Valor;

            }
            catch (WebException e)
            {
                //txtResultado.Text = txtResultado.Text +" \r\n "+ e.Message;

                //if (e.Response != null)
                //{
                //    ErrorBE _ErrorBE = new ErrorBE();
                //    using (var errorResponse = (HttpWebResponse)e.Response)
                //    {
                //        using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                //        {
                //            string error = reader.ReadToEnd();
                //            _ErrorBE = JsonConvert.DeserializeObject<ErrorBE>(error);
                //            txtResultado.Text = txtResultado.Text + " \r\n " + _ErrorBE.error.status_code + ":" + _ErrorBE.error.message;
                //            _ErroresDA.GuardarErrores(_ErrorBE.error.status_code + ":" + _ErrorBE.error.message);
                //        }
                //    }
                //}
                return "";
            }
            catch (Exception e)
            {
                //txtResultado.Text = txtResultado.Text + " \r\n " + e.Message;
                //_ErroresDA.GuardarErrores(e.Message);
                return "";
            }
            finally
            {

            }
        }
        public void BuscarOrdenes(string Token)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream())
                {

                    var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://microservices.dev.rappi.com/api/restaurants-integrations-public-api/orders");
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "GET";
                    httpWebRequest.Headers.Add("X-Auth-Int", Token);
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                    //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    //{
                    //    streamWriter.Write(requestBody);
                    //    streamWriter.Flush();
                    //    streamWriter.Close();
                    //    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    //    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    //    {
                    //        Valor = httpResponse.Headers["X-Auth-Int"].ToString();
                    //    }
                    //    //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    //    //{
                    //    //    Valor=streamReader.ReadToEnd();
                    //    //    //txtResultado.Text = result.ToString();

                    //    //}
                    //}
                }


            }
            catch (WebException e)
            {


            }
            catch (Exception e)
            {

            }
            finally
            {

            }
        }
    }
}
