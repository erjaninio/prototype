using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Image image = new Image();
            Image clonedImage = image.Clone();
            image.GetInfo();
            clonedImage.GetInfo();
            Console.Read();
        }

        public class Image
        {
            string name;
            long size;
            string format;

            public Image()
            {
                name = "картинка";
                size = 13;
                format = ".png";
            }

            public void GetInfo()
            {
                Console.WriteLine($"Название - {name}, Размер - {size} кБ, Формат - {format}");
            }
            public Image Clone()
            {
                return new Image();
            }
        }
    }
}
