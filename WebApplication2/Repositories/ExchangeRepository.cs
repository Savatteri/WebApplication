using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using WebApplication2.Models;
using JsonSerializer = Newtonsoft.Json.JsonSerializer;

namespace WebApplication2.Repositories
{
    public class ExchangeRepository
    {
        public async Task<CurrencyModel> GetRequestLatestAsync(string baseCurrency)
        {
            string uri = "https://api.exchangeratesapi.io/latest/";
            HttpClient client = new HttpClient();
            if (baseCurrency != "")
            {
                uri += "?base=" + baseCurrency;
            };
            
            string jsonResponse = await client.GetStringAsync(uri);
            CurrencyModel deserializedExchangeModels = JsonConvert.DeserializeObject<CurrencyModel>(jsonResponse, new JsonSerializerSettings
           {
                MaxDepth = 64
            });
            //var result = deserializedExchangeModels.Rates;
            var result = deserializedExchangeModels;

            return result;
        }

        public string GetStringLatest(string baseCurrency) {
            string strresulttest = "";
            string uri = "https://api.exchangeratesapi.io/latest";

            if (baseCurrency != "")
            {
                uri += "?base=" + baseCurrency;
            };

            WebRequest requestObjGet = WebRequest.Create(uri);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();
            
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();

                sr.Close();
            }

            return strresulttest;
        
        }

        public async Task<CurrencyModel> GetHistoricsAsync(int days)
        {
            string uri = "https://api.exchangeratesapi.io/";
            HttpClient client = new HttpClient();
            System.DateTime dt = System.DateTime.Now;
            dt = dt.AddDays(-days);
            string strurltest = string.Format(uri + "{0}-{1}-{2}", dt.Year, dt.Month, dt.Day);
            string jsonResponse = await client.GetStringAsync(strurltest);
            CurrencyModel deserializedExchangeModels = JsonConvert.DeserializeObject<CurrencyModel>(jsonResponse);
            //var result = deserializedExchangeModels.Rates;
            var result = deserializedExchangeModels;
            return result;
        }

        private static async Task<ExchangeModels> StreamWithNewtonsoftJson(string uri)
        {
            HttpClient client = new HttpClient();

            using var httpResponse = await client.GetAsync(uri);

            httpResponse.EnsureSuccessStatusCode(); // throws if not 200-299

            if (httpResponse.Content is object && httpResponse.Content.Headers.ContentType.MediaType == "application/json")
            {
                var contentStream = await httpResponse.Content.ReadAsStreamAsync();

                using var streamReader = new StreamReader(contentStream);
                using var jsonReader = new JsonTextReader(streamReader);

                JsonSerializer serializer = new JsonSerializer();

                try
                {
                    return serializer.Deserialize<ExchangeModels>(jsonReader);
                }
                catch (JsonReaderException)
                {
                    Console.WriteLine("Invalid JSON.");
                }
            }
            else
            {
                Console.WriteLine("HTTP Response was invalid and cannot be deserialised.");
            }

            return null;



        }

       
    }

}
