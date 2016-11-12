/* 
 * Zalando Shop API
 *
 * The shop API empowers developers to build amazing new apps or websites using Zalando shop data and services.
 *
 * OpenAPI spec version: v1.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using ZalandoApiClient.Client;
using ZalandoApiClient.Api;
using ZalandoApiClient.Model;

namespace ZalandoApiClient.Test
{
    /// <summary>
    ///  Class for testing ArticlesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ArticlesApiTests
    {
        private ArticlesApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ArticlesApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ArticlesApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' ArticlesApi
            //Assert.IsInstanceOfType(typeof(ArticlesApi), instance, "instance is a ArticlesApi");
        }

        
        /// <summary>
        /// Test ArticleReviewsGet
        /// </summary>
        [Test]
        public void ArticleReviewsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> reviewId = null;
            //List<string> articleId = null;
            //List<string> articleModelId = null;
            //string minStarRating = null;
            //string maxStarRating = null;
            //string sort = null;
            //string page = null;
            //string pageSize = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticleReviewsGet(reviewId, articleId, articleModelId, minStarRating, maxStarRating, sort, page, pageSize, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleReviews> (response, "response is ArticleReviews");
        }
        
        /// <summary>
        /// Test ArticleReviewsReviewIdGet
        /// </summary>
        [Test]
        public void ArticleReviewsReviewIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string reviewId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticleReviewsReviewIdGet(reviewId, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleReview> (response, "response is ArticleReview");
        }
        
        /// <summary>
        /// Test ArticleReviewsSummariesArticleModelIdGet
        /// </summary>
        [Test]
        public void ArticleReviewsSummariesArticleModelIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleModelId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticleReviewsSummariesArticleModelIdGet(articleModelId, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleReviewsSummary> (response, "response is ArticleReviewsSummary");
        }
        
        /// <summary>
        /// Test ArticleReviewsSummariesGet
        /// </summary>
        [Test]
        public void ArticleReviewsSummariesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> articleModelId = null;
            //string page = null;
            //string pageSize = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticleReviewsSummariesGet(articleModelId, page, pageSize, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleReviewsSummaries> (response, "response is ArticleReviewsSummaries");
        }
        
        /// <summary>
        /// Test ArticlesArticleIdGet
        /// </summary>
        [Test]
        public void ArticlesArticleIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesArticleIdGet(articleId, acceptLanguage, fields);
            //Assert.IsInstanceOf<Article> (response, "response is Article");
        }
        
        /// <summary>
        /// Test ArticlesArticleIdMediaGet
        /// </summary>
        [Test]
        public void ArticlesArticleIdMediaGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesArticleIdMediaGet(articleId, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleMedia> (response, "response is ArticleMedia");
        }
        
        /// <summary>
        /// Test ArticlesArticleIdReviewsGet
        /// </summary>
        [Test]
        public void ArticlesArticleIdReviewsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleId = null;
            //string minStarRating = null;
            //string maxStarRating = null;
            //string sort = null;
            //string page = null;
            //string pageSize = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesArticleIdReviewsGet(articleId, minStarRating, maxStarRating, sort, page, pageSize, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleReviews> (response, "response is ArticleReviews");
        }
        
        /// <summary>
        /// Test ArticlesArticleIdReviewsSummaryGet
        /// </summary>
        [Test]
        public void ArticlesArticleIdReviewsSummaryGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesArticleIdReviewsSummaryGet(articleId, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleReviewsSummary> (response, "response is ArticleReviewsSummary");
        }
        
        /// <summary>
        /// Test ArticlesArticleIdUnitsGet
        /// </summary>
        [Test]
        public void ArticlesArticleIdUnitsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesArticleIdUnitsGet(articleId, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleUnits> (response, "response is ArticleUnits");
        }
        
        /// <summary>
        /// Test ArticlesArticleIdUnitsUnitIdGet
        /// </summary>
        [Test]
        public void ArticlesArticleIdUnitsUnitIdGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string articleId = null;
            //string unitId = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesArticleIdUnitsUnitIdGet(articleId, unitId, acceptLanguage, fields);
            //Assert.IsInstanceOf<ArticleUnit> (response, "response is ArticleUnit");
        }
        
        /// <summary>
        /// Test ArticlesGet
        /// </summary>
        [Test]
        public void ArticlesGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> articleId = null;
            //List<string> articleModelId = null;
            //List<string> articleUnitId = null;
            //List<string> activationDate = null;
            //List<string> ageGroup = null;
            //List<string> assortmentArea = null;
            //List<string> brand = null;
            //List<string> brandfamily = null;
            //List<string> category = null;
            //List<string> color = null;
            //List<string> den = null;
            //List<string> filling = null;
            //string fullText = null;
            //List<string> gender = null;
            //List<string> heelForm = null;
            //List<string> heelHeight = null;
            //string length = null;
            //List<string> occasion = null;
            //List<string> pattern = null;
            //string price = null;
            //List<string> sale = null;
            //List<string> season = null;
            //List<string> shaftHeight = null;
            //List<string> shaftWidth = null;
            //List<string> shirtCollar = null;
            //List<string> shoeFastener = null;
            //List<string> shoeToecap = null;
            //List<string> shopArea = null;
            //string size = null;
            //List<string> sports = null;
            //List<string> technology = null;
            //List<string> trouserRise = null;
            //List<string> upperMaterial = null;
            //List<string> volume = null;
            //string page = null;
            //string pageSize = null;
            //string sort = null;
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.ArticlesGet(articleId, articleModelId, articleUnitId, activationDate, ageGroup, assortmentArea, brand, brandfamily, category, color, den, filling, fullText, gender, heelForm, heelHeight, length, occasion, pattern, price, sale, season, shaftHeight, shaftWidth, shirtCollar, shoeFastener, shoeToecap, shopArea, size, sports, technology, trouserRise, upperMaterial, volume, page, pageSize, sort, acceptLanguage, fields);
            //Assert.IsInstanceOf<Articles> (response, "response is Articles");
        }
        
    }

}