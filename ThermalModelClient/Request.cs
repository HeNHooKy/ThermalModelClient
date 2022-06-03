using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using ThermalModelClient.Model;

namespace ThermalModelClient
{
    internal class Request
    {
        private readonly string url;

        public Request()
        {
            url = ConfigurationManager.ConnectionStrings["production"].ConnectionString;
        }

        public delegate void Callback(IEnumerable<Cluster>? clusters);

        public async Task<IEnumerable<Cluster>?> Get()
        {
            using var client = new HttpClient();
            var clusters = (IEnumerable<Cluster>?) await client.GetFromJsonAsync
                ($"{url}/info", typeof(IEnumerable<Cluster>));

            return clusters;
        }

        public IEnumerable<Data>? GetData(Sensor sensor)
        {

            using var client = new HttpClient();
            var requestUrl = $"{url}/data/{sensor.Id}";
            return (IEnumerable<Data>?)client.GetFromJsonAsync
                (requestUrl, typeof(IEnumerable<Data>)).Result;
        }

        public void Post<T>(T value)
        {
            var task = new Task(async () =>
            {
                using var client = new HttpClient();
                var result = await client.PostAsJsonAsync($"{url}/{typeof(T).Name}", value);
            });

            task.Start();
        }
    }
}
