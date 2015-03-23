using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//
using TinToy;

namespace TinToyWeb
{
    /// <summary>
    /// Summary description for ImageHandler
    /// </summary>
    public class ImageHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            boClsProduct boPro = new boClsProduct();
            ErrorMessage err = new ErrorMessage();
            int id = Int32.Parse(context.Request.QueryString["ID"]);
            Product prod = boPro.GetProductByID(id, ref err);
            context.Response.BinaryWrite(prod.Image);
            context.Response.End();
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