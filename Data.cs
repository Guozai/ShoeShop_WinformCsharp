using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shoe_Shop
{
    public class Shoe
    {
        private int id;
        private string name;
        private List<MyColor> colors;

        public int Id { get; set; }
        public string Name { get; set; }
        public List<MyColor> Colors { get; set; }
    }

    public class MyColor
    {
        private int color;
        private string picturePath;
        private double price;
        private int stock;

        public int Color { get; set; }
        public string PicturePath { get; set; }
        public double Price { get; set; }
        public int Stock { get; set; }
    }

    public enum Colors { BlackWhite, Black, NavyWhite, BlackPink, WhiteSilver,
        GrayBlack, BlackBlack, BlackGray, Navy,
        GrayPink, TaupePink, Charcoal,
        Natural, BurgundyPink, Gray,
        Purple, Mauve, Blue };
}
