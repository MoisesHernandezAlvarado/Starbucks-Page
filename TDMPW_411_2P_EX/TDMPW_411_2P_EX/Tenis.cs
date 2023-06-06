using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDMPW_411_2P_EX
{
    internal class Tenis
    {
        public String image;
        public String title;
        public String category;
        public String size;
        public String brand;
        public double price;

        public Tenis(String image, String title, String category, String size, String brand, double price)
        {
            this.image = image;
            this.title = title;
            this.category = category;
            this.size = size;
            this.brand = brand;
            this.price = price;
        }

    }
}
