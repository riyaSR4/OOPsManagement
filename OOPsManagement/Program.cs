using OOPsManagement.DataInventoryManagement;
using System;

namespace OOPsManagement
{
    class Program
    {
        static string DataInventoryManagement_filePath = @"D:\BridgeLabs Training\OOPsManagement\OOPsManagement\DataInventoryManagement\InventoryData.json";
        public static void Main(string[] args)
        {
            InventoryDetailsOperation detailsOperation = new InventoryDetailsOperation();
            detailsOperation.ReadInventoryJson(DataInventoryManagement_filePath);
        }
    }
}
