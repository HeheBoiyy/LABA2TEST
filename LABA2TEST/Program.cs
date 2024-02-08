using LABA2TEST;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
namespace Laba2Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<object> list1 = new List<object>()
            {
                new A(1,1),
                new B(1,"1"),
                new C(1,"aboba"),
                new B(1,"Hello")
            };
            List<object> list2 = new List<object>()
            {
                new A(1,1),
                new B(1,"1"),
                new C(1,"abob"),
                new B(1,"Hell")
 
            };
            bool areEqual = CompareLists(list1, list2);

            // Выводим результат сравнения
            Console.WriteLine($"Равны ли коллекции? {areEqual}");
        }

        static bool CompareLists(List<object> list1, List<object> list2)
        {
            // Проверяем, что списки имеют одинаковую длину

            if (list1.Count != list2.Count)
                return false;

            // Проходимся по каждому объекту в списках

            for (int i = 0; i < list1.Count; i++)
            {
                // Получаем типы объекта

                Type type = list1[i].GetType();
                Type type1 = list2[i].GetType();
                
                // Сравниваем типы объекта

                if (!(type == type1))
                {
                    Console.WriteLine($"Найдено расхождение в типах!\nВ позиции: {i+1}\nПолучено: {type1.Name}" +
                            $"\nОжидалось: {type.Name}\n");
                    if (i != list1.Count-1)
                    {
                        continue; 
                    }
                    return false;
                }
                // Получаем все свойства объекта

                PropertyInfo[] properties = type.GetProperties();
                
                // Проходимся по каждому свойству объекта

                foreach (PropertyInfo property in properties)
                {
                    // Получаем значение свойства для каждого списка

                    object ?value1 = property.GetValue(list1[i]);
                    object ?value2 = property.GetValue(list2[i]);

                    // Сравниваем значения свойств

                    if (!value1.Equals(value2))
                    {
                        Console.WriteLine($"Найдено расхождение в значениях!\nВ позиции: {i+1}\nПолучено: {property.GetValue(list2[i])}" +
                            $"\nОжидалось: {property.GetValue(list1[i])}\n");
                        if (i != list1.Count - 1)
                        {
                            continue;
                        }
                        return false;
                    }
                }
            }

            return true;
        }
    }
    
}
