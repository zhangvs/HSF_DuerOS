using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace CloudApi.Controllers
{
    public class UnitController : Controller
    {
        [HttpPost]
        public ActionResult CallBack()
        {
            byte[] byts = new byte[Request.InputStream.Length];
            Request.InputStream.Read(byts, 0, byts.Length);
            string req = System.Text.Encoding.UTF8.GetString(byts);
            req = Server.UrlDecode(req);
            ToolHelper.FunctionHelper.writeLog("receiveObj", req, "UnitController");

            var response = new UNITRespons();
            response.error_code = 0;
            response.error_msg = "";
            response.result = new UNITResponsResult() { type = "text" };
            response.result.content = "你需要缴纳100元";

            return Json(response);
        }


        [HttpPost]
        public ActionResult city_salary()
        {
            byte[] byts = new byte[Request.InputStream.Length];
            Request.InputStream.Read(byts, 0, byts.Length);
            string req = System.Text.Encoding.UTF8.GetString(byts);
            req = Server.UrlDecode(req);
            ToolHelper.FunctionHelper.writeLog("receiveObj", req, "UnitController");

            var response = new UNITRespons();
            response.error_code = 0;
            response.error_msg = "";
            response.result = new UNITResponsResult() { type = "text" };
            response.result.content = "你需要缴纳300元";

            return Json(response);
        }
    }

    public class UNITRespons
    {
        public int error_code { get; set; }
        public string error_msg { get; set; }
        public UNITResponsResult result { get; set; }

    }
    public class UNITResponsResult
    {
        public string type { get; set; }
        public string content { get; set; }
    }

    
}
