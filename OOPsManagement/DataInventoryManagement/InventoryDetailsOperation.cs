using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OOPsManagement.DataInventoryManagement
{
    public class InventoryDetailsOperation
    {
        public void ReadInventoryJson(string filePath)
        {
            var json =File.ReadAllText(filePath);
            List<InventoryDetails> list = JsonConvert.DeserializeObject<List<InventoryDetails>>(json);
            foreach (var data in list)
            {
                Console.WriteLine("Name:" + data.Name + " Weight:" + data.Weight + " PricePerKg:" + data.PricePerKg);
            }
        }
    }
}
