using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;

namespace AbpCompanyName.AbpProjectName.Orders
{

    [AbpAuthorize()]
    public class OrderAppService :
        AppServiceBase<Order, OrderDto, int, OrderListInput, CreateOrderInput, UpdateOrderInput>, IOrderAppService
    {
        private readonly IRepository<Order, int> _cityRepository;

        public OrderAppService(
            IRepository<Order, int> cityRepository
        ): base(cityRepository)
        {
            this._cityRepository = cityRepository;
        }

        [RemoteService(false)]
        public async Task<PagedResultDto<OrderDto>> GetListAsync(OrderListInput input)
        {
            return await base.GetAllAsync(input);
        }
    }
}
