namespace EasyFactWebService.Controllers.EasyFact
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    using System.Web;
    using System.Web.Http.Controllers;
    using System.Web.Http.Filters;
    public class BasicAuthorizeAttribute : AuthorizationFilterAttribute
    {
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            var headers = actionContext.Request.Headers;
            if (headers.Authorization != null && headers.Authorization.Scheme == "Basic")
            {
                try
                {
                    var userPwd = Encoding.UTF8.GetString(Convert.FromBase64String(headers.Authorization.Parameter));
                    var user = userPwd.Substring(0, userPwd.IndexOf(":"));
                    var password = userPwd.Substring(userPwd.IndexOf(":") + 1);

                    //var erick = Seguridad.DesEncriptar("123456789")
                    // Validamos user y password (aquí asumimos que siempre son ok)
                    if (user == "erick" && password == "1234")
                    {

                    }
                    else
                    {
                        PutUnauthorizedResult(actionContext, "Invalid Authorization");
                    }
                }
                catch (Exception)
                {
                    PutUnauthorizedResult(actionContext, "Invalid Authorization header");
                }
            }
            else
            {
                // No hay el header Authorization
                PutUnauthorizedResult(actionContext, "Auhtorization needed");
            }
        }

        private void PutUnauthorizedResult(HttpActionContext actionContext, string msg)
        {
            actionContext.Response = new HttpResponseMessage(HttpStatusCode.Unauthorized)
            {
                Content = new StringContent(msg)
            };
        }
    }
}