using System;
using System.Collections.Generic;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> names = new Dictionary<string,string>();


            names.Add("number one","muba vai");
            names.Add("number one1", "bijoy vai");


            double? a;
            Console.WriteLine(a = 0); ;


            // Dictionary data remove by key
            //names.Remove("number one");


            // you can count total Dictionary data
            Console.WriteLine(names.Count);

         

            // you can iterate only Dictionary values
            foreach (var item in names.Values)
            {
                Console.WriteLine(item);
            }




            // you can also iterate only keys
            foreach (var item in names.Keys)
            {
                Console.WriteLine(item);
            }




            // you can also iterate like this
            foreach (KeyValuePair<string,string> item in names)
            {
                Console.WriteLine($"key is - {item.Key} and name is - {item.Value}");
            }



            // you can also iterate like this
            foreach (var item in names)
            {
                Console.WriteLine($"key is - {item.Key} and name is - {item.Value}");
            }



            // you can clear Dictionary
            //names.Clear();


            // you can check this key exist or not,it's return bool value
            Console.WriteLine(names.ContainsKey("number one"));


            // you can also check this value exist or not, it's also return bool value
            Console.WriteLine(names.ContainsValue("mridul vai"));



            Console.WriteLine(names.EnsureCapacity(9999));// confused


            // it search by key and if found it out the value if not found nothing to return
            var str = string.Empty;
            names.TryGetValue("number one", out str);
            Console.WriteLine(str);

            Console.WriteLine(names.GetHashCode()); // dictionary hashcode
        }
    }
}


