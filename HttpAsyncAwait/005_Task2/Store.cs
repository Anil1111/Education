using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_Task2
{
    public class Store
    {
        private Article[] articles = new Article[5]
        {
            new Article("Ручка","Букварь",5),
            new Article("Ковать","Мебельный",5555),
            new Article("Пиво","АТБ",25),
            new Article("Ноутбук","Розетка",20000),
            new Article("Люстра","Фокстрот",1000),
        };


        public string this[string name]
        {
            get
            {
                for (int i = 0; i < articles.Length; i++)
                {
                    if (articles[i].ProductName == name)
                        return string.Concat($"Имя товара {articles[i].ProductName}\n\r",
                                             $"Магазин где его можно купить {articles[i].Shop}\n\r",
                                             $"Цена товара {articles[i].Price}\n\r");

                }

                return $"Товара с именем '{name}' не найдено.";
            }
        }

        public string this[int index]
        {
            get
            {
                if (index < articles.Length && index != 0)
                    return string.Concat($"Имя товара {articles[index].ProductName}\n\r",
                        $"Магазин где его можно купить {articles[index].Shop}\n\r",
                        $"Цена товара {articles[index].Price}\n\r");
                else
                    return $"Товара с индексом '{index}' не найдено.";
            }
        }

        public void Sort()
        {
            for (int i = 0; i <= articles.Length - 1; i++)
            {
                for (int q = 0; q <= articles.Length - 1; q++)
                {
                    if (articles[i].Price <= articles[q].Price)
                    {
                        Article g = articles[i];
                        articles[i] = articles[q];
                        articles[q] = g;
                    }
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < articles.Length; i++)
            {
                Console.WriteLine(articles[i].Info());
            }
        }
    }
}
