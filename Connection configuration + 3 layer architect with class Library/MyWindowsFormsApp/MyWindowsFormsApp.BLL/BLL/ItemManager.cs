﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MyWindowsFormsApp.Model.Model;
using MyWindowsFormsApp.Repository.Repository;

namespace MyWindowsFormsApp.BLL.BLL
{
    public class ItemManager
    {
        ItemRepository _itemRepository = new ItemRepository();
        public bool Add(Item item)
        {
            return _itemRepository.Add(item);
        }
        public bool IsNameExists(Item item)
        {
            return _itemRepository.IsNameExists(item);
        }

        public bool Delete(int id)
        {
            return _itemRepository.Delete(id);
        }
        public List<Item> Display()
        {
            return _itemRepository.Display();
        }

        public DataTable Search(string name)
        {
            return _itemRepository.Search(name);
        }

        public bool Update(string name, double price, int id)
        {
            return _itemRepository.Update(name, price, id);
        }

        public DataTable ItemCombo()
        {
            return _itemRepository.ItemCombo();
        }
    }
}
