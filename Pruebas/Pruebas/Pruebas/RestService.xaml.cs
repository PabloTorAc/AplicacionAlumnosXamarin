using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using System.Text.Json;
using System.Text.Json.Serialization;
using Xamarin.Essentials;
using Newtonsoft.Json;


namespace Pruebas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RestService : ContentPage
    {

        HttpClient client;

        JsonSerializerOptions serializerOptions;

        public class CurrencyList
        {
            public string idresponse { get; set; }
            public string emailresponse { get; set; }

        }

        public class RootObject
        {
            public List<CurrencyList> currencylist { get; set; }
        }

        public RestService()
        {
            InitializeComponent();

            client = new HttpClient();

            serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        }

        public async void RefreshDataAsync(object sender, EventArgs args)
        {

            Debug.WriteLine("Entro al método");

            Uri uri = new Uri(string.Format("https://ucqwebcuatro.azurewebsites.net/apiUCQUno",string.Empty));

            Debug.WriteLine("Valor de la URL: " + uri);

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                Debug.WriteLine("Valor del response: " + response);

                string contentPrimero = await response.Content.ReadAsStringAsync();

                Debug.WriteLine("Valor del response primero:" + contentPrimero);

                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();

                    Debug.WriteLine("Respuesta del Content: "+content);
                }

            }catch (Exception ex)
            {
                Debug.WriteLine("Error: "+ex);            
            }

        }

        public async void SaveTodoItemAsync(object sender, EventArgs args)
        {

            try
            {
                Uri uri = new Uri(string.Format("https://ucqwebcuatro.azurewebsites.net/apiUCQUno", string.Empty));

                var formcontent = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("email_id","pablo_t@ucq.com"),
                new KeyValuePair<string, string>("password","ucq12345")
            });

                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, formcontent);

                Debug.WriteLine("Respuesta de content en update API: " + response);

                string content2 = await response.Content.ReadAsStringAsync();

                Debug.WriteLine("Respuesta de content en update Api Update : " + content2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }

        }

        public async void ConsultarTodoItemAsync(object sender,EventArgs args)
        {
            try
            {
                Uri uri = new Uri(string.Format("https://ucqwebcuatro.azurewebsites.net/apiUCQUnoConsulta", string.Empty));

                var formcontent = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("idconsulta","101"),
                });

                HttpResponseMessage response = null;

                response = await client.PostAsync(uri, formcontent);

                Debug.WriteLine("Respuesta de content en Método Consulta Api: " + response);

                string content2 = await response.Content.ReadAsStringAsync();

                Debug.WriteLine("Respuesta de content en Método Consulta Api Formato: " + content2);

                CurrencyList curren1 = new CurrencyList();

                curren1 = JsonConvert.DeserializeObject<CurrencyList>(content2);

                Debug.WriteLine("Valor de email en CurrencyList: " + curren1.emailresponse);

            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error: "+ex);
            }

        }

    }
}