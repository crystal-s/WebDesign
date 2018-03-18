using System;
using System.Web;
using System.Web.Http;

namespace CrystalStevensAPI
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            AppDomain.CurrentDomain.SetData("DataDirectory", @"C:\Users\Crystal\Desktop\College\OIT\CST356 - Web Design\WebDesign\CrystalStevensLab9\CrystalStevensLab3Week4\App_Data");
        }
    }
}
