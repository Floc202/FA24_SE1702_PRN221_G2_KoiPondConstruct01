﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KoiPondConstruct.Data.Entities;

public partial class TblInspection
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public long DesignId { get; set; }

    public long InspectorId { get; set; }

    public DateTime InspectionDate { get; set; }

    public string Status { get; set; }

    public string Findings { get; set; }

    public string Recommendations { get; set; }

    public string Severity { get; set; }

    public string Note { get; set; }

    public virtual TblDesign Design { get; set; }

    public virtual ICollection<TblInspectionDetail> TblInspectionDetails { get; set; } = new List<TblInspectionDetail>();
}