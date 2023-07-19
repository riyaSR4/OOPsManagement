using OOPsManagement.DataInventoryManagement;
using OOPsManagement.InventoryManagement;
using System;

namespace OOPsManagement
{
    class Program
    {
        static string DataInventoryManagement_filePath = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\DataInventoryManagement\InventoryData.json";
        static string InventoryManagement_filePath     = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\InventoryManagement\InventoryManagementData.json";
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
            Console.WriteLine("Enter the option to proceed\n 1.Data Inventory Management\n 2.Inventory Management\n 3.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryDetailsOperation detailsOperation = new InventoryDetailsOperation();
                        detailsOperation.ReadInventoryJson(DataInventoryManagement_filePath);
                        break;
                    case 2:
                        bool flag1 = true;
                        while (flag1)
                        {
                            Console.WriteLine("Enter the option to proceed\n 1.Display the list\n 2.Add to list\n 3.Exit");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                            InventoryManagementOperation managementOperation = new InventoryManagementOperation();
                            switch (option1)
                            {
                                case 1:
                                    managementOperation.ReadInventoryJson(InventoryManagement_filePath);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the name to be added:");
                                    string name = Console.ReadLine();
                                    managementOperation.AddInventoryManagement(name, InventoryManagement_filePath);
                                    managementOperation.WriteToJsonFile(InventoryManagement_filePath);
                                    break;
                                case 3:
                                    flag = false;
                                    break;
                            }
                        }
                        break;
                        case 3:
                        flag1 = false;
                        break;
                    default:
                        flag1 = false; break;
                }
            }
        }
    }
}
