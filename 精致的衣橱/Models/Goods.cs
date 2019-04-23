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
    
    public partial class Goods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Goods()
        {
            this.Cart = new HashSet<Cart>();
            this.Collect = new HashSet<Collect>();
            this.GoodsComment = new HashSet<GoodsComment>();
            this.GoodsLike = new HashSet<GoodsLike>();
            this.Grade = new HashSet<Grade>();
            this.OrderDetails = new HashSet<OrderDetails>();
        }
    
        public int GoodsID { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Season { get; set; }
        public string Material { get; set; }
        public string Style { get; set; }
        public string GoodsImage { get; set; }
        public Nullable<int> Amount { get; set; }
        public Nullable<double> Unitprice { get; set; }
        public int CategoryID { get; set; }
        public string SizeImage { get; set; }
        public Nullable<System.DateTime> ShangjiaTime { get; set; }
        public Nullable<int> Pageview { get; set; }
        public string Size { get; set; }
        public Nullable<int> StorageAmount { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cart> Cart { get; set; }
        public virtual Category Category { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Collect> Collect { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsComment> GoodsComment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GoodsLike> GoodsLike { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Grade> Grade { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
    }
}
