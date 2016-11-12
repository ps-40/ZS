using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZalandoApiClient.Api;
using ZalandoApiClient.Model;

namespace ZalandoSukienki.Models
{
    public class RootModel
    {
        private static RootModel instance;

        public static RootModel Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RootModel();
                }
                return instance;
            }
        }

        public CategoriesModel CategoriesModel { get; private set; }
        public CategoryModel SelectedCategory { get; private set; }

        private RootModel()
        {
            CategoriesModel = new CategoriesModel();
        }

        public void SelectCategory(String categoryKey)
        {
            Category category = CategoriesModel.Categories.Content.FirstOrDefault(cat => cat.Key.Equals(categoryKey));
            SelectedCategory = categoryKey == null ? null : new CategoryModel(category);
        }
        
    }
}