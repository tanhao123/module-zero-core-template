using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;

namespace AbpCompanyName.AbpProjectName.Orders;

public interface IOrderAppService : IAsyncCrudAppService<OrderDto, int, OrderListInput, CreateOrderInput, UpdateOrderInput>
{
    Task<PagedResultDto<OrderDto>> GetListAsync(OrderListInput input);
}