﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagement1
{
    public class Rice
    {
        //public List<TypesOfRice> typesofRice;
        public List<TypesOfRice> typesofRice;
        public List<TypesOfWheat> typesofWheat;
        public List<TypesOfPulse> typesofPulse;
    }


    public class TypesOfRice
    {
        public string name;
        public string weight;
        public int Price;
    }
    public class TypesOfWheat
    {
        public string name;
        public string weight;
        public int Price;
    }
    public class TypesOfPulse
    {
        public string name;
        public string weight;
        public int Price;
    }
}
