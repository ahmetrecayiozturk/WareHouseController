using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    internal class Reflections
    {
        public static void GetProperties(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                Console.WriteLine(property.Name);
            }
        }
        /*
            public static string GetProductName(object obj) {             
                var properties = obj.GetType().GetProperties();
                foreach (var property in properties)
                {
                    if (property.Name == "Name")
                    {
                        return property.GetValue(obj).ToString();
                    }
                }
                return null;
            } 
        */
        /*
        public static string GetProductName(object obj)
        {
            var type = obj.GetType();
            var instance = Activator.CreateInstance(obj);
            return type.GetProperty("Name").GetValue(instance).ToString();
        }*/
        public static void GetPropertiesWithAttribute<T>(object obj)
        {
            var properties = obj.GetType().GetProperties();
            foreach (var property in properties)
            {
                var attributes = property.GetCustomAttributes(typeof(T), false);
                foreach (var attribute in attributes)
                {
                    Console.WriteLine(property.Name + " : " + attribute.GetType().Name);
                }
            }
        }
    }
}
