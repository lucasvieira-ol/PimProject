using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Web;
using PimWebsite.Models.Main;
using PimWebsite.Models.Reservation;

namespace PimWebsite.Controllers
{
    public class reservationController
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

        public static async Task<List<reservationRpt>> getReservations(UserData searchFilters)
        {
            List<reservationRpt> reservationsRetrieved = new List<reservationRpt>();

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("reservationsRpt", searchFilters);

                reservationsRetrieved = await response.Content.ReadFromJsonAsync<List<reservationRpt>>();

            }
            catch (Exception ex)
            {
            }

            client.Dispose();

            return reservationsRetrieved;

        }        
        
        public static async Task<string> createReservation(reservationData sendReservation)
        {
           string reservationResponse = string.Empty;

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("reservationCreate", sendReservation);


                reservationResponse = await response.Content.ReadFromJsonAsync<string>();

            }
            catch (Exception ex)
            {
            }

            client.Dispose();

            return reservationResponse;

        }
        public static async Task<roomData> getAvailableRoom(reservationData searchAvailableRoom)
        {
            roomData roomRetrieved = new roomData();

            try
            {
                await RunAsync();

                HttpResponseMessage response = await client.PostAsJsonAsync("getAvailableRoom", searchAvailableRoom);

                roomRetrieved = await response.Content.ReadFromJsonAsync<roomData>();

            }
            catch (Exception ex)
            {
            }

            client.Dispose();

            return roomRetrieved;

        }


    }
}