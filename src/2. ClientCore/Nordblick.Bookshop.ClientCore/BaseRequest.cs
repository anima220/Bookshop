using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Nordblick.BookShop.ClientCore
{
    public class BaseRequest : IBaseRequest
    {
        private string _urlPrefix;

        public BaseRequest(string urlPrefix)
        {
            if (string.IsNullOrEmpty(urlPrefix))
                throw new ArgumentNullException("urlPrefix");

            if (!urlPrefix.EndsWith("/"))
                urlPrefix = string.Concat(urlPrefix, "/");

            _urlPrefix = urlPrefix;
        }

        public string UrlPrefix
        {
            get => _urlPrefix;

            set
            {
                if (string.IsNullOrWhiteSpace(value) ||
                    !Uri.IsWellFormedUriString(value, UriKind.Absolute))
                    return;

                _urlPrefix = value;
            }
        }

        public async Task<bool> DeleteAsync(string url)
        {
            try
            {
                var httpClient = CreateHttpClient();


                var response = await httpClient.DeleteAsync(url);


                if (response.IsSuccessStatusCode) return true;

                switch (response.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        throw new Exception(
                            $"Fehler: Ressource wurde nicht gefunden Statuscode: {response.StatusCode}");
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task PostAsync(string url)
        {
            try
            {
                var client = CreateHttpClient();

                var response = await client.PostAsJsonAsync(url, string.Empty);


                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task PostAsync<T>(string url, T entity)
        {
            try
            {
                var client = CreateHttpClient();

                var response = await client.PostAsJsonAsync(url, entity);


                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> PostAsyncResponse<T>(string url, T entity)
        {
            try
            {
                var client = CreateHttpClient();

                var response = await client.PostAsJsonAsync(url, entity);
                //Uri resultUrl = response.Headers.Location;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<T>();
                    return result;
                }

                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<T> PostAsync<T, TU>(string url, TU entity)
        {
            try
            {
                var client = CreateHttpClient();

                var response = await client.PostAsJsonAsync(url, entity);
                //Uri resultUrl = response.Headers.Location;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<T>();
                    return result;
                }

                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public async Task PutAsync<T>(string url, T entity)
        {
            var httpClient = CreateHttpClient();

            var content = JsonConvert.SerializeObject(entity);
            var response =
                await httpClient.PutAsync(url, new StringContent(content, Encoding.UTF8, "application/json"));

            

            response.EnsureSuccessStatusCode();
        }

        public async Task<T> PutAsyncResponse<T>(string url, T entity)
        {
            try
            {
                var client = CreateHttpClient();

                var response = await client.PutAsJsonAsync(url, entity);
                //Uri resultUrl = response.Headers.Location;

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<T>();
                    return result;
                }

                switch (response.StatusCode)
                {
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        protected async Task<IEnumerable<T>> GetIEnumerableAsync<T>(string url)
        {
            try
            {
                var httpClient = CreateHttpClient();

                var response = await httpClient.GetAsync(url);


                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<IEnumerable<T>>();
                    return result;
                }

                switch (response.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        throw new Exception(
                            $"Fehler: Ressource wurde nicht gefunden Statuscode: {response.StatusCode}");
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        protected async Task<T> GetAsync<T>(string url)
            where T : new()
        {
            try
            {
                var httpClient = CreateHttpClient();

                var response = await httpClient.GetAsync(url);


                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsAsync<T>();
                    return result;
                }

                switch (response.StatusCode)
                {
                    case HttpStatusCode.NotFound:
                        throw new Exception(
                            $"Fehler: Ressource wurde nicht gefunden Statuscode: {response.StatusCode}");
                    case HttpStatusCode.BadRequest:
                        throw new Exception(
                            $"Daten wurden im falschen Format übergeben oder sind nicht valide. Statuscode: {response.StatusCode}");
                    case HttpStatusCode.InternalServerError:
                        throw new Exception(
                            $"Es ist ein Dienstfehler auf dem Server aufgetreten. Statuscode: {response.StatusCode}");
                    default:
                        throw new Exception("Ein unbehandelter Fehler ist aufgetreten");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        protected async Task GetAsync(string url, string headerName = null, string headerValue = null)
        {
            HttpClient httpClient;

            if (!string.IsNullOrWhiteSpace(headerName) && !string.IsNullOrWhiteSpace(headerValue))
            {
                httpClient = CreateHttpClientForCustomHeaders();
                httpClient.DefaultRequestHeaders.Add(headerName, headerValue);
            }
            else
            {
                httpClient = CreateHttpClient();
            }

            await httpClient.GetStringAsync(url);
        }


        private HttpClient CreateHttpClient()
        {
            var httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            return httpClient;
        }


        private HttpClient CreateHttpClientForCustomHeaders()
        {
            var httpClient = new HttpClient();

            return httpClient;
        }


        public HttpClient GetHttpClient()
        {
            return CreateHttpClient();
        }
    }
}
