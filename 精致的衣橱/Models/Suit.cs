//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 精致的衣橱.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Suit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suit()
        {
            this.Coordinate = new HashSet<Coordinate>();
        }
    
        public int SuitID { get; set; }
        public string Color { get; set; }
        public string Season { get; set; }
        public string Design { get; set; }
        public string Material { get; set; }
        public string Image { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public int WardrobeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Coordinate> Coordinate { get; set; }
        public virtual Wardrobe Wardrobe { get; set; }
    }
}
