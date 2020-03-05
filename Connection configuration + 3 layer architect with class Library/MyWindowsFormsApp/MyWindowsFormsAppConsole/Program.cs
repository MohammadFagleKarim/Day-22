using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyWindowsFormsApp.Model.Model;
using MyWindowsFormsApp.BLL.BLL;

namespace MyWindowsFormsAppConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemManager _itemManager = new ItemManager();

            Item item = new Item();

            DataTable dataTable = new DataTable();
            
            Console.WriteLine("Please enter name: ");
            string name = Console.ReadLine();

            dataTable = _itemManager.Search(name);
            
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var a in row.ItemArray)
                {
                    Console.WriteLine(a);
                }
            }
            Console.ReadKey();
        }
    }
}
