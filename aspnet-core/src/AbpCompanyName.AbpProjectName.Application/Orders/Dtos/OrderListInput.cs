using AbpCompanyName.AbpProjectName.Base;

namespace AbpCompanyName.AbpProjectName.Orders;

public class OrderListInput : GetEntityListInput
{
    public string Keyword { get; set; }
}