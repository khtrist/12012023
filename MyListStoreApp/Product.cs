﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyListStoreApp

{
    internal class Product
    {
        static int _count = 0;
        public Product()
        {
            _count++;
            this.No = _count;
        }
        public int No;
        public string Name;
        public decimal Price;
        public DateTime ExpireDate;
        public DateTime CreatedDate;

        public override string ToString()
        {
            return $"No: {No} - Name: {Name} - Price: {Price} - ExpireDate: {ExpireDate.ToString("dd-MM-yyyy")}";
        }
    }
}