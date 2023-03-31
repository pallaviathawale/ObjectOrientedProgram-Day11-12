using Newtonsoft.Json;

namespace JsonInventoryDataManagement
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            InventoryManager manager = new InventoryManager();
            string file = @"C:\Users\PALLAVI\source\repos\StockManagement\JsonInventoryDataManagement\Datamanager.json";
            InventoryUtility utility = JsonConvert.DeserializeObject<InventoryUtility>(File.ReadAllText(file));
            Console.WriteLine("Display inventory Press 1-Rice Inventory 2-Wheat Inventory 3-Pulse Inventory ");
            int ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    manager.DisplayInventory(utility.RiceList);
                    break;
                case 2:
                    manager.DisplayInventory(utility.WheatList);
                    break;
                case 3:
                    manager.DisplayInventory(utility.PulseList);
                    break;
            }
        }

    }
}
