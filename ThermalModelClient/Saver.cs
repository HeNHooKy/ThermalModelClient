using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ThermalModelClient.Model;

namespace ThermalModelClient
{
    internal static class Saver
    {
        public static void Save(Cluster cluster)
        {
            var saveCluster = new Cluster()
            {
                Id = cluster.Id,
                Name = cluster.Name,
                Blocks = Array.Empty<Block>()
            };

            ConnectionLayer.Post(saveCluster);
        }

        public static void Save(Block block)
        {
            var saveBlock = new Block()
            {
                Id = block.Id,
                ClusterId = block.ClusterId,
                Name = block.Name,
                Number = block.Number,
                Sensors = Array.Empty<Sensor>()
            };

            ConnectionLayer.Post(saveBlock);
        }

        public static void Save(Sensor sensor)
        {
            var saveSensor = new Sensor()
            {
                Id = sensor.Id,
                BlockId = sensor.BlockId,
                Number = sensor.Number,
                LastCheck = sensor.LastCheck,
                LastValue = sensor.LastValue,
                Name = sensor.Name,
                CoordX = sensor.CoordX,
                CoordY = sensor.CoordY,
                CoordZ = sensor.CoordZ
            };

            ConnectionLayer.Post(saveSensor);
        }


    }
}
