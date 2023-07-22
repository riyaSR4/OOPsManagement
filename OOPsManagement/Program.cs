using OOPs.StockAccountManagement;
using OOPsManagement.CommercialDataProcessing;
using OOPsManagement.DataInventoryManagement;
using OOPsManagement.InventoryManagement;
using System;
using System.Security.AccessControl;

namespace OOPsManagement
{
    class Program
    {
        static string DataInventoryManagement_filePath = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\DataInventoryManagement\InventoryData.json";
        static string InventoryManagement_filePath     = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\InventoryManagement\InventoryManagementData.json";
        static string StockAccountManagement_filePath = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\StockAccountManagement\CompanyStock.json";
        static string CommercialDataProcessing_filePath = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\CommercialDataProcessing\CustomerStock.json";
        public static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
            Console.WriteLine("Enter the option to proceed\n 1.Data Inventory Management\n 2.Inventory Management\n " +
                "3.Stock Account Management\n 4.Commercial Data Processing\n 5.Exit");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InventoryDetailsOperation detailsOperation = new InventoryDetailsOperation();
                        detailsOperation.ReadInventoryJson(DataInventoryManagement_filePath);
                        break;
                    case 2:
                        bool flag1 = true;
                        InventoryManagementOperation managementOperation = new InventoryManagementOperation();
                        while (flag1)
                        {
                            Console.WriteLine("Enter the option to proceed\n 1.Read Inventory\n 2.Add to list\n " +
                                "3.Delete from the list\n 4.Edit the list\n 5.Write to Json\n 6.Exit");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    managementOperation.ReadInventoryJson(InventoryManagement_filePath);
                                    break;
                                case 2:
                                    Console.WriteLine("Enter the name to be added:");
                                    string name = Console.ReadLine();
                                    managementOperation.AddInventoryManagement(name);
                                    break;
                                case 3:
                                    Console.WriteLine("Enter the name (rice, wheat, pulses): ");
                                    string name1 = Console.ReadLine();
                                    Console.WriteLine("Enter the name of the item to delete: ");
                                    string itemName = Console.ReadLine();
                                    managementOperation.DeleteInventoryManagement(name1, itemName);
                                    break;
                                case 4:
                                    Console.WriteLine("Enter the name (rice, wheat, pulses): ");
                                    string name2 = Console.ReadLine();
                                    Console.WriteLine("Enter the name of the item to edit: ");
                                    string itemName1 = Console.ReadLine();
                                    managementOperation.EditInventoryManagement(name2, itemName1);
                                    break;
                                case 5:
                                    managementOperation.WriteToJsonFile(InventoryManagement_filePath);
                                    break;
                                case 6:
                                    flag = false;
                                    break;
                            }
                        }
                        break;
                    case 3:
                        StockOperation stockOperation = new StockOperation();
                        stockOperation.ReadInventoryJson(StockAccountManagement_filePath);
                        break;
                    case 4:
                        Console.WriteLine("Enter the amount:");
                        int amount = Convert.ToInt32(Console.ReadLine());
                        StockOperations stockOperationCommercial = new StockOperations(amount);
                        stockOperationCommercial.ReadCompanyStock(StockAccountManagement_filePath);
                        stockOperationCommercial.ReadCustomerStock(CommercialDataProcessing_filePath);
                        bool flag2 = true;
                        while (flag2)
                        {
                            Console.WriteLine("Enter the option to proceed\n 1.Buy Stock\n 2.Sell Stock\n 3.Write to files\n" +
                                " 4.Display\n 5.Exit");
                            int option1 = Convert.ToInt32(Console.ReadLine());
                            switch (option1)
                            {
                                case 1:
                                    stockOperationCommercial.CustomerBuyStockFromCompany();
                                    break;
                                case 2:
                                    stockOperationCommercial.CustomerSellStocksToCompany();
                                    break;
                                case 3:
                                    stockOperationCommercial.WriteToCompanyFile(StockAccountManagement_filePath);
                                    stockOperationCommercial.WriteToCustomerFile(CommercialDataProcessing_filePath);
                                    break;
                                case 4:
                                    stockOperationCommercial.ReadCompanyStock(StockAccountManagement_filePath);
                                    stockOperationCommercial.ReadCustomerStock(CommercialDataProcessing_filePath);
                                    break;
                                case 5:
                                    flag2 = false;
                                    break;
                            }
                        }
                        break;
                    case 5:
                        flag1 = false;
                        break;
                }
            }
        }
    }
}
