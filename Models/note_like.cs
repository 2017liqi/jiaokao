//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class note_like
    {
        public int NoteID { get; set; }
        public string img { get; set; }
        public string title { get; set; }
        public string notecontent { get; set; }
        public Nullable<System.DateTime> notetime { get; set; }
        public int noteuserid { get; set; }
        public int notelikeid { get; set; }
        public Nullable<System.DateTime> liketime { get; set; }
        public Nullable<int> likenum { get; set; }
        public int likeuserid { get; set; }
    }
}
