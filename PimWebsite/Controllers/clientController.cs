using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Web;
using PimWebsite.Models.Client;
using PimWebsite.Models.Main;

namespace PimWebsite.Controllers
{
    public class clientController
    {
        static HttpClient client = new HttpClient();

        static async Task RunAsync()
        {
            // Update port # in the following line.
            client = new HttpClient();

            client.BaseAddress = new Uri("https://pimbackend.azurewebsites.net/api/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
        public static async Task<clientData> LoginHandler(LoginData loginData)
        {
            clientData clientInfo = new clientData();


            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("Login", loginData);

                clientInfo = await response.Content.ReadFromJsonAsync<clientData>();

            }
            catch (Exception ex)
            {
                
            }

            client.Dispose();

            return clientInfo;

        }

        public static async Task<clientData> getClient(clientData getClientData)
        {
            clientData clientRetrieved = new clientData();

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("clientInfo", getClientData);

                clientRetrieved = await response.Content.ReadFromJsonAsync<clientData>();

            }
            catch (Exception ex)
            {
            }

            client.Dispose();

            return clientRetrieved;

        }
        public static async Task<clientData> getClientByDocument(string clientDocument, string clientTypeDocument)
        {
            clientData clientRetrieved = new clientData();

            try
            {
                await RunAsync();

                clientData search = new clientData()
                {
                    clientDocument = clientDocument,
                    typeDocument = clientTypeDocument
                };

                HttpResponseMessage response = await client.PostAsJsonAsync("clientInfoByDocument", search);

                clientRetrieved = await response.Content.ReadFromJsonAsync<clientData>();

            }
            catch (Exception ex)
            {
            }

            client.Dispose();

            return clientRetrieved;

        }
        public static async Task<string> clientUpdate(clientData clientUpdateData)
        {
            string messageResult = string.Empty;

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PutAsJsonAsync("clientUpdate", clientUpdateData);

                messageResult = await response.Content.ReadFromJsonAsync<string>();

            }
            catch (Exception ex)
            {
                messageResult = "Erro ao se comunicar com o servidor";
            }

            client.Dispose();

            return messageResult;

        }
        public static async Task<string> clientCreate(clientData clientCreateData)
        {
            string messageResult = string.Empty;

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("clientCreate", clientCreateData);

                messageResult = await response.Content.ReadFromJsonAsync<string>();

            }
            catch (Exception ex)
            {
                messageResult = "Erro ao se comunicar com o servidor";
            }

            client.Dispose();

            return messageResult;

        }
        public static async Task<string> clientUserCreate(clientData clientUSerCreateData)
        {
            string messageResult = string.Empty;

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("clientUserCreate", clientUSerCreateData);

                messageResult = await response.Content.ReadFromJsonAsync<string>();

            }
            catch (Exception ex)
            {
                messageResult = "Erro ao se comunicar com o servidor";
            }

            client.Dispose();

            return messageResult;

        }
    }
}