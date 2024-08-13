using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    public class Product
    {
        // Product sınıfı oluşturuldu ve özellikleri tanımlandı.
        [RequiredProperty] // Id property'si zorunlu olarak işaretlendi
        public int Id { get; set; }

        [RequiredProperty] // Name property'si zorunlu olarak işaretlendi
        public string Name { get; set; }

        public decimal UnitPrice { get; set; }

        [RequiredProperty] // StockAmount property'si zorunlu olarak işaretlendi
        public int StockAmount { get; set; }

        [RequiredProperty] // ProductCategoryId property'si zorunlu olarak işaretlendi
        public int ProductCategoryId { get; set; }
    }

    // Oluşturacağımız attribute'ün hangi özelliklerde kullanılacağını belirtmek için AttributeUsage kullanılır.
    
    [AttributeUsage(AttributeTargets.Property, Inherited = true)]
    // Attribue oluşturarak zorunlu olan özellikleri işaretliyoruz.
    public class RequiredPropertyAttribute : Attribute
    {
        public RequiredPropertyAttribute()
        {
            // Burada herhangi bir ek işlem yapılması gerekmediği için boş bırakıldı.
            // Ancak, özel bir işlem yapılmak istenirse burada tanımlanabilir.
        }
    }
}

/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WareHouseController3
{
    public class Product
    {
        //Product sınıfı oluşturuldu ve özellikleri tanımlandı.
        [RequiredPropertyAttribute(Id)]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        [RequiredPropertyAttribute(StockAmount)]
        public int StockAmount { get; set; }
        [RequiredPropertyAttribute(ProductCategoryId)]
        public int ProductCategoryId { get; set; }

    }
    //Attribue oluşturarak istenilen değer aralığını belirledik.
    public class RequiredPropertyAttribute : Attribute
    {
        private int _T;

        public RequiredPropertyAttribute(int T)
        {
            T = _T;
        }
    }
}
*/