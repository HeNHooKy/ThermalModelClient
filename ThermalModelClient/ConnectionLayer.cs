using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermalModelClient.Model;

namespace ThermalModelClient
{
    internal static class ConnectionLayer
    {
        public static Task<IEnumerable<Cluster>?> GetInfo()
        {
            var request = new Request();
            return request.Get();
        }

        public static IEnumerable<Data>? GetData(Sensor sensor)
        {
            var request = new Request();
            return request.GetData(sensor);
        }

        public static void Post<T>(T value)
        {
            var request = new Request();
            request.Post(value);
        }
    }
}
