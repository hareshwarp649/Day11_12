﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockAccount3
{
    public class FetchJsonStock
    {

        public Stock Read(string path)
        {
            using (StreamReader file = new StreamReader(path))

            {
                try
                {
                    string json = file.ReadToEnd();
                    var stockobject = JsonConvert.DeserializeObject<Stock>(json);
                    return stockobject;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Problem in reading the file");
                    return null;
                }
            }
        }
    }
}
