using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZalandoApiClient.Client;

namespace ZalandoSukienki
{
    public class ApiConfig
    {
        public static void ConfigureZalandoApi()
        {
            Configuration.Default.AddDefaultHeader("Accept-Language", "pl-PL");
        }
    }
}