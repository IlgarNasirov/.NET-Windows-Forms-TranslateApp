using Newtonsoft.Json.Linq;
using RestSharp;
using TranslateApp.Entities;

namespace TranslateApp.Services
{
    public class TranslateService:ITranslateService
    {
        const string URL= "https://api.apilayer.com/language_translation/translate?target=";
        public string Translate(TranslateEntity translateEntity)
        {
            var client = new RestClient(URL+translateEntity.To);
            var request = new RestRequest();
            request.AddHeader("apikey", "yourapikeyforapilayerwebsite");
            request.AddParameter("text/plain", translateEntity.Text, ParameterType.RequestBody);
            var response = client.Post(request);
            dynamic data=JObject.Parse(response.Content);
            if (data.error != null)
            {
                return null;
            }
            return data.translations[0].translation.ToString();
        }
    }
}
