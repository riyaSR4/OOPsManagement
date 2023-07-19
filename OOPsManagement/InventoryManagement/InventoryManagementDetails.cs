using OOPsManagement.DataInventoryManagement;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsManagement.InventoryManagement
{
    public class InventoryManagementDetails
    {
        public List<InventoryDetails> RiceList { get; set; }
        public List<InventoryDetails> WheatList { get; set; }
        public List<InventoryDetails> PulsesList { get; set; }
    }
}
