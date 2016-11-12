using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ZalandoApiClient.Api;
using ZalandoApiClient.Model;

namespace ZalandoSukienki.Models
{
    public class CategoryModel
    {
        public Category Category { get; private set; }

        public Articles Articles { get; private set; }

        public CategoryModel(Category category)
        {
            this.Category = category;
            var articlesApi = new ArticlesApi();
            Articles = articlesApi.ArticlesGet(category: new List<string> { category.Key });
        }

        public List<string> ImageUrls
        {
           get
            {
                return Articles.Content.Select(article => getArticleImage(article)).ToList();
            }
        }

        private String getArticleImage(Article article)
        {
            return article.Media.Images.Where(image => image.Type.Equals("STYLE")).Select(image => image.SmallHdUrl).FirstOrDefault();
        }

    }
}