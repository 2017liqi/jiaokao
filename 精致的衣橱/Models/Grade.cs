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
    
    public partial class Grade
    {
        public int GradeID { get; set; }
        public int UserID { get; set; }
        public int GoodsID { get; set; }
        public Nullable<int> Grade1 { get; set; }
        public Nullable<System.DateTime> GradeTime { get; set; }
    
        public virtual Goods Goods { get; set; }
        public virtual Users Users { get; set; }
    }
}
