using Abp.Application.Services.Dto;
using Abp.AutoMapper;

namespace AbpCompanyName.AbpProjectName.Orders;

[AutoMapFrom(typeof(Order))]
public class OrderDto : FullAuditedEntityDto
{
    public string Name { get; set; }
}