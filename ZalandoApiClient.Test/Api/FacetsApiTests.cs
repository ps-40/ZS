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
    ///  Class for testing FacetsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class FacetsApiTests
    {
        private FacetsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new FacetsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of FacetsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsInstanceOfType' FacetsApi
            //Assert.IsInstanceOfType(typeof(FacetsApi), instance, "instance is a FacetsApi");
        }

        
        /// <summary>
        /// Test FacetsGet
        /// </summary>
        [Test]
        public void FacetsGetTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //List<string> ageGroup = null;
            //List<string> articleId = null;
            //List<string> activationDate = null;
            //List<string> articleModelId = null;
            //List<string> assortmentArea = null;
            //List<string> brand = null;
            //List<string> brandfamily = null;
            //List<string> category = null;
            //List<string> color = null;
            //List<string> den = null;
            //List<string> filling = null;
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
            //string acceptLanguage = null;
            //List<string> fields = null;
            //var response = instance.FacetsGet(ageGroup, articleId, activationDate, articleModelId, assortmentArea, brand, brandfamily, category, color, den, filling, gender, heelForm, heelHeight, length, occasion, pattern, price, sale, season, shaftHeight, shaftWidth, shirtCollar, shoeFastener, shoeToecap, shopArea, size, sports, technology, trouserRise, upperMaterial, volume, acceptLanguage, fields);
            //Assert.IsInstanceOf<Facets> (response, "response is Facets");
        }
        
    }

}
