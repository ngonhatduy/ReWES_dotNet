using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace ReWES.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public String GetData()
        {
            //string reportName = "status=QVBQUk9WRS1USElMLU5FVw==&value=MTUzLVRISUwtTkVX";
            //string data = string.Format("status={0}&value={1}", status, value);
            var client = new HttpClient();
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Encode());
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //var apiUrl = ConfigurationManager.AppSettings["MuleLink"].ToString();
            var response = client.GetAsync("https://envi-hcmus.herokuapp.com/mongodb").Result;
            
            return response.Content.ReadAsStringAsync().Result.ToString();
        }

        public String GetFakeData()
        {
            //string reportName = "status=QVBQUk9WRS1USElMLU5FVw==&value=MTUzLVRISUwtTkVX";
            //string data = string.Format("status={0}&value={1}", status, value);
            var client = new HttpClient();
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Base64Encode());
            //ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3 | SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            //var apiUrl = ConfigurationManager.AppSettings["MuleLink"].ToString();
            var response = client.GetAsync("https://samples.openweathermap.org/data/2.5/weather?q=London,uk&appid=b6907d289e10d714a6e88b30761fae22").Result;

            return response.Content.ReadAsStringAsync().Result.ToString();
        }
    }
}