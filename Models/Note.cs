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
    
    public partial class Note
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Note()
        {
            this.NoteLike = new HashSet<NoteLike>();
            this.NoteSelect = new HashSet<NoteSelect>();
            this.NoteTrasmit = new HashSet<NoteTrasmit>();
        }
    
        public int NoteID { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
        public string NoteContent { get; set; }
        public Nullable<System.DateTime> Time { get; set; }
        public int UserID { get; set; }
        public int NotecommentID { get; set; }
    
        public virtual NoteComment NoteComment { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoteLike> NoteLike { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoteSelect> NoteSelect { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NoteTrasmit> NoteTrasmit { get; set; }
    }
}
