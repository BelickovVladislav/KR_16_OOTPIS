using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KR_16_OOTPIS
{
    class ProductList
    {
        private System.Collections.Generic.List<Product> list;
        public int Length { get => this.list == null ? 0 : this.list.Count; private set { } }
        public ProductList()
        {
            this.list = new System.Collections.Generic.List<Product>();
        }

        public void Add(Product item)
        {
            this.list.Add(item);
        }

        public Product this[int i]
        {
            get
            {
                return list[i];
            }

            set
            {
                this.list[i] = value;
            }
        }

        public void Remove(int index)
        {
            this.list.RemoveAt(index);
        }

        public string GetInfo(int index)
        {
            return this[index].GetInfo();
        }

        public void Unloading(int index, int count)
        {
            if (this[index].Count > count)
            {
                Console.WriteLine("Вы успешно выгрузили {0} товаров", count);
                this[index].Count -= count;
            }
            else
            {
                Console.WriteLine("Успешно выгружено {0}, товаров. Товар на складе закончился!", this[index].Count);
                this.Remove(index);
            }
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in list)
            {
                result += item.GetInfo();
            }
            return result;
        }
    }
}
