using System.ComponentModel.DataAnnotations;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace AbpCompanyName.AbpProjectName.Orders;

[AutoMapTo(typeof(Order))]
public class UpdateOrderInput : EntityDto<int>
{
    [MaxLength(200)]
    [Required]
    public string Name { get; set; }
}