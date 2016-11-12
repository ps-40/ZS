using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZalandoApiClient.Api;
using ZalandoApiClient.Model;

namespace ZalandoSukienki.Models
{
    public class CategoriesModel
    {
        public Categories Categories { get; private set; }

        public CategoriesModel()
        {
            var categoriesApi = new CategoriesApi();
            // Categories = categoriesApi.CategoriesGet(name: new List<string> { "sukienki" }, targetGroup: "WOMEN");
            Categories = categoriesApi.CategoriesGet(parentKey: new List<string> { "odziez-damska-sukienki" });
        }
    }
}