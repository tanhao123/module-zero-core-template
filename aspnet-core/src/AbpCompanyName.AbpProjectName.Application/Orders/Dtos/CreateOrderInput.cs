using System.ComponentModel.DataAnnotations;
using Abp.AutoMapper;

namespace AbpCompanyName.AbpProjectName.Orders;

[AutoMapTo(typeof(Order))]
public class CreateOrderInput
{
    [MaxLength(200)]
    [Required]
    public string Name { get; set; }
}