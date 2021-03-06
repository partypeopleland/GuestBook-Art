namespace Cowell_GuestBook.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(ARTICLEMetaData))]
    public partial class ARTICLE
    {
    }
    
    public partial class ARTICLEMetaData
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public int FORUM_ID { get; set; }
        
        [StringLength(100, ErrorMessage="欄位長度不得大於 100 個字元")]
        [Required]
        [DisplayName("文章")]
        public string TITLE { get; set; }
        [Required]
        [DisplayName("內容")]
        public string BODY { get; set; }
        [Required]
        [DisplayName("發帖日期")]
        public System.DateTime BUD_DTM { get; set; }
        [Required]
        [DisplayName("修改日期")]
        public System.DateTime UPD_DTM { get; set; }
        
        [StringLength(20, ErrorMessage="欄位長度不得大於 20 個字元")]
        [Required]
        [DisplayName("發帖人")]
        public string AUTHOR { get; set; }
    
        public virtual Forum Forum { get; set; }
        public virtual ICollection<ARTICLEREPLY> ARTICLEREPLY { get; set; }
    }
}
