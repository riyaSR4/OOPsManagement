using Newtonsoft.Json;
using OOPsManagement.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsManagement.InventoryManagement
{
    public class InventoryManagementOperation
    {
        InventoryManagementDetails list;
        public void ReadInventoryJson(string filePath)
        {
            var json = File.ReadAllText(filePath);
            list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);
            Console.WriteLine("RiceList:");
            Display(list.RiceList);
            Console.WriteLine("WheatList:");
            Display(list.WheatList);
            Console.WriteLine("PulsesList:");
            Display(list.PulsesList);
        }
        public void AddInventoryManagement(string objectName, string filePath)
        {
            Console.WriteLine("Enter the name, weight and price per kg to be added:");
            {
                if (objectName.ToLower().Equals("rice"))
                {
                    var json = File.ReadAllText(filePath);
                    list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);
                    InventoryDetails details = new InventoryDetails()
                    {
                        Name = Console.ReadLine(),
                        Weight = Convert.ToInt32(Console.ReadLine()),
                        PricePerKg = Convert.ToInt32(Console.ReadLine())
                    };
                    list.RiceList.Add(details);
                }
                if (objectName.ToLower().Equals("wheat"))
                {
                    var json = File.ReadAllText(filePath);
                    list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);
                    InventoryDetails details = new InventoryDetails()
                    {
                        Name = Console.ReadLine(),
                        Weight = Convert.ToInt32(Console.ReadLine()),
                        PricePerKg = Convert.ToInt32(Console.ReadLine())
                    };
                    list.WheatList.Add(details);
                }
                if (objectName.ToLower().Equals("pulses"))
                {
                    var json = File.ReadAllText(filePath);
                    list = JsonConvert.DeserializeObject<InventoryManagementDetails>(json);
                    InventoryDetails details = new InventoryDetails()
                    {
                        Name = Console.ReadLine(),
                        Weight = Convert.ToInt32(Console.ReadLine()),
                        PricePerKg = Convert.ToInt32(Console.ReadLine())
                    };
                    list.PulsesList.Add(details);
                }

            }
        }
        public void WriteToJsonFile(string filePath)
        {
            var json = JsonConvert.SerializeObject(list);
            File.WriteAllText(filePath, json);
        }
        public void Display(List<InventoryDetails> list)
        {
            foreach (var data in list)
            {
                Console.WriteLine("Name:" + data.Name + " Weight:" + data.Weight + " PricePerKg:" + data.PricePerKg);
            }
        }
    }
}
