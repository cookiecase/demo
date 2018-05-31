using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace demo
{
    /// <summary>
    /// Summary description for _123
    /// </summary>
    public class _123 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
           string a= context.Request["x"];
            
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}