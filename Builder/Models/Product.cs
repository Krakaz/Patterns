using System;
using System.Collections;

namespace Builder.Models
{
    class Product
    {
        private ArrayList parts = new ArrayList();

        public void Add(object part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (var el in parts)
            {
                Console.WriteLine(el);
            }
        }

    }
}
