using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Payment.Domain;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class RestClient
    {
        private static readonly string baseURL = "https://localhost:5001/api/";

        public RestClient()
        {

        }

        public static async Task<string> GetAllPayments()
        {

            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "payments"))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        List<PaymentResource> prl = JsonConvert.DeserializeObject<List<PaymentResource>>(data);
                        ResultT result = new ResultT();
                        result.IsSuccess = response.IsSuccessStatusCode;
                        result.StatusCode = (int)response.StatusCode;
                        result.Status = response.StatusCode.ToString();
                        result.PaymentResourceList = prl;
                        if (data != null)
                            return JsonConvert.SerializeObject(result);
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetPaymentById(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.GetAsync(baseURL + "payments/" + id))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        PaymentResource pr = JsonConvert.DeserializeObject<PaymentResource>(data);
                        ResultT result = new ResultT();
                        result.IsSuccess = response.IsSuccessStatusCode;
                        result.StatusCode = (int)response.StatusCode;
                        result.Status = response.StatusCode.ToString();
                        result.PaymentResource = pr;

                        if (data != null)
                            return JsonConvert.SerializeObject(result);
                    }
                }
                return string.Empty;
            }
        }

        public static async Task<string> Post(SavePaymentResource savePaymentResource)
        {
            var newPayment = JsonConvert.SerializeObject(savePaymentResource);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PostAsync(baseURL + "payments", new StringContent(newPayment, Encoding.UTF8, "application/json")))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = string.Empty;
                        data = await content.ReadAsStringAsync();
                        PaymentResource pr = JsonConvert.DeserializeObject<PaymentResource>(data);
                        ResultT result = new ResultT();
                        result.IsSuccess = response.IsSuccessStatusCode;
                        result.StatusCode = (int)response.StatusCode;
                        result.Status = response.StatusCode.ToString();
                        result.PaymentResource = pr;
                        if (data != null)
                            return JsonConvert.SerializeObject(result);
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Put(string id, SavePaymentResource savePaymentResource)
        {
            var newPayment = JsonConvert.SerializeObject(savePaymentResource);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.PutAsync(baseURL + "payments/" + id, new StringContent(newPayment, Encoding.UTF8, "application/json")))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        ResultT result = new ResultT();
                        result.IsSuccess = response.IsSuccessStatusCode;
                        result.StatusCode = (int)response.StatusCode;
                        result.Status = response.StatusCode.ToString();
                        if (data != null)
                            return JsonConvert.SerializeObject(result);
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Delete(string id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage response = await client.DeleteAsync(baseURL + "payments/" + id))
                {
                    using (HttpContent content = response.Content)
                    {
                        string data = string.Empty;
                        data = await content.ReadAsStringAsync();
                        ResultT result = new ResultT();
                        result.IsSuccess = response.IsSuccessStatusCode;
                        result.StatusCode = (int)response.StatusCode;
                        result.Status = response.StatusCode.ToString();
                        if (data != null)
                            return JsonConvert.SerializeObject(result);
                    }
                }
            }
            return string.Empty;
        }

        public static string BeautifyJson(string jsonstr)
        {
            JToken parseJson = JToken.Parse(jsonstr);
            return parseJson.ToString(Formatting.Indented);
        }
    }
}
