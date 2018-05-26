using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace MathService1
{
    /// <summary>
    /// Descrizione di riepilogo per Service1
    /// </summary>
    [WebService(Namespace = "http://localhost/MathService/MathService.asmx")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Per consentire la chiamata di questo servizio Web dallo script utilizzando ASP.NET AJAX, rimuovere il commento dalla riga seguente. 
    // [System.Web.Script.Services.ScriptService]
    public class Service1 : System.Web.Services.WebService
    {

        [WebMethod]
        public float Add(float a, float b)
        {
            return (a + b);
        }

        [WebMethod]
        public float Subtract(System.Single A, System.Single B)
        {
            return (A - B);
        }

        [WebMethod]
        public float Multiply(System.Single A, System.Single B)
        {
            return A * B;
        }

        [WebMethod]
        public float Divide(System.Single A, System.Single B)
        {
            if (B == 0)
                return -1;
            return (A / B);
        }
    }
}
