using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using InfoService.Rappi.Model;
using InfoService.Infomatica.Model;
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
                    TR.token = VariableGeneral.TokenRappi;//"EoC_*ll=W6CBQh9mzR5r4xw!208Z4|ZIel9dLtWr";
                    string json = JsonConvert.SerializeObject(TR, Formatting.None);
                    string requestBody = json.Replace("\r\n", "");
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(VariableGeneral.LoginRappi);
                    httpWebRequest.Accept = "*/*";
                    httpWebRequest.ContentType = "application/json";
                    httpWebRequest.Method = "POST";
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
                    }
                }
                return Valor;

            }
            catch (WebException e)
            {
                return "";
            }
            catch (Exception e)
            {
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
                    var httpWebRequest = (HttpWebRequest)WebRequest.Create(VariableGeneral.OrdersRappi);
                    //httpWebRequest.Accept = "application/json";
                    httpWebRequest.Method = "GET";
                    httpWebRequest.Headers.Add("x-auth-int", Token);
                    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    {
                        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                        {
                            var Valor = streamReader.ReadToEnd();
                            //txtResultado.Text = result.ToString();

                        }
                    }
                    //using (var streamWriter = new StreamWriter(httpWebRequest.GetRequestStream()))
                    //{
                    //    streamWriter.Flush();
                    //    streamWriter.Close();
                    //    var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                    //    if (httpResponse.StatusCode == HttpStatusCode.OK)
                    //    {
                    //        using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    //        {
                    //            var Valor = streamReader.ReadToEnd();
                    //            //txtResultado.Text = result.ToString();

                    //        }
                    //    }

                    //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                    //{
                    //    Valor=streamReader.ReadToEnd();
                    //    //txtResultado.Text = result.ToString();

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
