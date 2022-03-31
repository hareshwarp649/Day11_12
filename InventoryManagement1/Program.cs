using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement1
{
    public class Program
    {
        static void Main(string[] args)
        {

            string path = "C:/Users/ADMIN/source/repos/day11_12/JsonInventoryManage1/InventoryManagement1/Rice1.json";
            

            FetchJsonRice fetchJsonForRice = new FetchJsonRice();
            Rice data = fetchJsonForRice.Read(path);

            for (int i = 0; i < data.typesofRice.Count; i++)
            {
                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].weight);
                Console.WriteLine(data.typesofRice[i].Price);
                Console.WriteLine("---------***--------******--------");
            }

            for (int i = 0; i < data.typesofPulse.Count; i++)
            {
                Console.WriteLine(data.typesofPulse[i].name);
                Console.WriteLine(data.typesofPulse[i].weight);
                Console.WriteLine(data.typesofPulse[i].Price);
                Console.WriteLine("---------***--------******--------");

            }

            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].weight);
                Console.WriteLine(data.typesofWheat[i].Price);
                Console.WriteLine("---------***--------******--------");

            }
        }
    }
}
