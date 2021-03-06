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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ZalandoApiClient.Client;
using ZalandoApiClient.Model;

namespace ZalandoApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFiltersApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get Single Filter by filterName
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Filter</returns>
        Filter FiltersFilterNameGet (string filterName, string acceptLanguage = null, List<string> fields = null);

        /// <summary>
        /// Get Single Filter by filterName
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>ApiResponse of Filter</returns>
        ApiResponse<Filter> FiltersFilterNameGetWithHttpInfo (string filterName, string acceptLanguage = null, List<string> fields = null);
        /// <summary>
        /// Shop Filters
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Filters</returns>
        Filters FiltersGet (string acceptLanguage = null, List<string> fields = null);

        /// <summary>
        /// Shop Filters
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>ApiResponse of Filters</returns>
        ApiResponse<Filters> FiltersGetWithHttpInfo (string acceptLanguage = null, List<string> fields = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get Single Filter by filterName
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of Filter</returns>
        System.Threading.Tasks.Task<Filter> FiltersFilterNameGetAsync (string filterName, string acceptLanguage = null, List<string> fields = null);

        /// <summary>
        /// Get Single Filter by filterName
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of ApiResponse (Filter)</returns>
        System.Threading.Tasks.Task<ApiResponse<Filter>> FiltersFilterNameGetAsyncWithHttpInfo (string filterName, string acceptLanguage = null, List<string> fields = null);
        /// <summary>
        /// Shop Filters
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of Filters</returns>
        System.Threading.Tasks.Task<Filters> FiltersGetAsync (string acceptLanguage = null, List<string> fields = null);

        /// <summary>
        /// Shop Filters
        /// </summary>
        /// <remarks>
        /// Zalando API Filters Schema
        /// </remarks>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of ApiResponse (Filters)</returns>
        System.Threading.Tasks.Task<ApiResponse<Filters>> FiltersGetAsyncWithHttpInfo (string acceptLanguage = null, List<string> fields = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FiltersApi : IFiltersApi
    {
        private ZalandoApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FiltersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FiltersApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = ZalandoApiClient.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FiltersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FiltersApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ZalandoApiClient.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public ZalandoApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get Single Filter by filterName Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Filter</returns>
        public Filter FiltersFilterNameGet (string filterName, string acceptLanguage = null, List<string> fields = null)
        {
             ApiResponse<Filter> localVarResponse = FiltersFilterNameGetWithHttpInfo(filterName, acceptLanguage, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get Single Filter by filterName Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>ApiResponse of Filter</returns>
        public ApiResponse< Filter > FiltersFilterNameGetWithHttpInfo (string filterName, string acceptLanguage = null, List<string> fields = null)
        {
            // verify the required parameter 'filterName' is set
            if (filterName == null)
                throw new ApiException(400, "Missing required parameter 'filterName' when calling FiltersApi->FiltersFilterNameGet");

            var localVarPath = "/filters/{filterName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (filterName != null) localVarPathParams.Add("filterName", Configuration.ApiClient.ParameterToString(filterName)); // path parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FiltersFilterNameGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Filter>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Filter) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Filter)));
            
        }

        /// <summary>
        /// Get Single Filter by filterName Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of Filter</returns>
        public async System.Threading.Tasks.Task<Filter> FiltersFilterNameGetAsync (string filterName, string acceptLanguage = null, List<string> fields = null)
        {
             ApiResponse<Filter> localVarResponse = await FiltersFilterNameGetAsyncWithHttpInfo(filterName, acceptLanguage, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get Single Filter by filterName Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="filterName">To get Filter by filterName.</param>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of ApiResponse (Filter)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Filter>> FiltersFilterNameGetAsyncWithHttpInfo (string filterName, string acceptLanguage = null, List<string> fields = null)
        {
            // verify the required parameter 'filterName' is set
            if (filterName == null)
                throw new ApiException(400, "Missing required parameter 'filterName' when calling FiltersApi->FiltersFilterNameGet");

            var localVarPath = "/filters/{filterName}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (filterName != null) localVarPathParams.Add("filterName", Configuration.ApiClient.ParameterToString(filterName)); // path parameter
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FiltersFilterNameGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Filter>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Filter) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Filter)));
            
        }

        /// <summary>
        /// Shop Filters Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Filters</returns>
        public Filters FiltersGet (string acceptLanguage = null, List<string> fields = null)
        {
             ApiResponse<Filters> localVarResponse = FiltersGetWithHttpInfo(acceptLanguage, fields);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Shop Filters Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>ApiResponse of Filters</returns>
        public ApiResponse< Filters > FiltersGetWithHttpInfo (string acceptLanguage = null, List<string> fields = null)
        {

            var localVarPath = "/filters";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FiltersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Filters>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Filters) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Filters)));
            
        }

        /// <summary>
        /// Shop Filters Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of Filters</returns>
        public async System.Threading.Tasks.Task<Filters> FiltersGetAsync (string acceptLanguage = null, List<string> fields = null)
        {
             ApiResponse<Filters> localVarResponse = await FiltersGetAsyncWithHttpInfo(acceptLanguage, fields);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Shop Filters Zalando API Filters Schema
        /// </summary>
        /// <exception cref="ZalandoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="acceptLanguage">choose shop (country and language) (optional)</param>
        /// <param name="fields">Comma separated list of fields that should be returned. Fields of subobjects are specified with dots as separator. Fields of objects within lists are specified in the same way.  Example: id,name,brand.key,brand.name, units.id,units.size,units.price.formatted (optional)</param>
        /// <returns>Task of ApiResponse (Filters)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Filters>> FiltersGetAsyncWithHttpInfo (string acceptLanguage = null, List<string> fields = null)
        {

            var localVarPath = "/filters";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (fields != null) localVarQueryParams.Add("fields", Configuration.ApiClient.ParameterToString(fields)); // query parameter
            if (acceptLanguage != null) localVarHeaderParams.Add("Accept-Language", Configuration.ApiClient.ParameterToString(acceptLanguage)); // header parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FiltersGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Filters>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Filters) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Filters)));
            
        }

    }
}
