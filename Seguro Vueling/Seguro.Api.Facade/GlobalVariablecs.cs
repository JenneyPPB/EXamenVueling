using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;

namespace Seguro.Api.Facade
{
    public static class GlobalVariablecs
    {
        public static HttpClient WebApiClient = new HttpClient();

    }
}