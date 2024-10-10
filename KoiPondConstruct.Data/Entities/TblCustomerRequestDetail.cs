﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KoiPondConstruct.Data.Entities;

public partial class TblCustomerRequestDetail
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public long Id { get; set; }

    public long RequestId { get; set; }

    public long SampleDesignId { get; set; }

    public string HomeownerFirstName { get; set; }

    public string HomeownerLastName { get; set; }

    public string HomeownerPhone { get; set; }

    public DateOnly HomeownerDateOfBirth { get; set; }

    public long Height { get; set; }

    public long Width { get; set; }

    public long Length { get; set; }

    public string Shape { get; set; }

    public long Budget { get; set; }

    public string Type { get; set; }

    public string Address { get; set; }

    public string Note { get; set; }

    public bool IsDeleted { get; set; }

    public virtual TblCustomerRequest Request { get; set; }

    public virtual TblSampleDesign SampleDesign { get; set; }

    public virtual TblDesign TblDesign { get; set; }

    public virtual TblQuotationCost TblQuotationCost { get; set; }

    public virtual ICollection<TblSuggestionDoc> TblSuggestionDocs { get; set; } = new List<TblSuggestionDoc>();
}