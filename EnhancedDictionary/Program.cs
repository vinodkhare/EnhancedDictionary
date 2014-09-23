using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK;

namespace EnhancedDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var regularDict = new Dictionary<string, int>();
            var enhancedDict = new Dict<string, int>();

            enhancedDict.CollectionChanged += enhancedDict_CollectionChanged;

            for (int i = 3; i > 0; i--)
            {
                regularDict.Add(i.ToString(), i);
                enhancedDict.Add(i.ToString(), i);
            }

            regularDict.Remove("3");
            regularDict.Add("4", 4);

            enhancedDict.Remove("3");
            enhancedDict.Add("4", 4);

            Console.WriteLine();
            Console.WriteLine("regular");
            foreach (var kvp in regularDict)
            {
                Console.WriteLine("key: " + kvp.Key + ", value: " + kvp.Value);
            }

            Console.WriteLine();
            Console.WriteLine("enhanced");
            foreach (var kvp in enhancedDict)
            {
                Console.WriteLine("key: " + kvp.Key + ", value: " + kvp.Value);
            }

            Console.ReadKey();
        }

        static void enhancedDict_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    var kvp = item as Kvp<string, int>;
                    Console.WriteLine("Added key: " + kvp.Key + ", value: " + kvp.Value);
                }
            }
        }
    }
}
