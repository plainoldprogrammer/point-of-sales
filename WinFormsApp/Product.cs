using System;

namespace WinFormsApp
{
    public class Product
    {
        public String Name { get; set; }
        public int Price { get; set; }

        public override String ToString()
        {
            return Name;
        }
    }
}
