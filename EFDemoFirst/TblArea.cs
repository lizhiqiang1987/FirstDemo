namespace EFDemoFirst
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TblArea")]
    public partial class TblArea
    {
        [Key]
        public int AreaId { get; set; }

        [StringLength(50)]
        public string AreaName { get; set; }

        public int? AreaPId { get; set; }
    }
}
