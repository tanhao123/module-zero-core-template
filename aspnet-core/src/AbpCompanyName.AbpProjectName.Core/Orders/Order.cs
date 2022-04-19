using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using AutoMapper;

namespace AbpCompanyName.AbpProjectName
{
    [Table("Order")]
    public class Order : FullAuditedEntity
    {
        [MaxLength(200)]
        [Required]
        public string Name { get; set; }

    }
}
