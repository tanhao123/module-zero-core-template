using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;

namespace AbpCompanyName.AbpProjectName
{
    public class AppServiceBase<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput>
        :
            AsyncCrudAppService<TEntity, TEntityDto, TPrimaryKey, TGetAllInput, TCreateInput, TUpdateInput,
                EntityDto<TPrimaryKey>>
        where TEntity : class, IEntity<TPrimaryKey>
        where TEntityDto : IEntityDto<TPrimaryKey>
        where TUpdateInput : IEntityDto<TPrimaryKey>
    {

        public AppServiceBase(IRepository<TEntity, TPrimaryKey> repository) : base(repository)
        {
        }

        /// <summary>
        ///     Gets the order string.
        /// </summary>
        /// <param name="input">The input.</param>
        /// <returns></returns>
        /*protected virtual string GetOrderString(GetEntityListInput input)
        {
            var orderString = "CreationTime desc";
            if (!string.IsNullOrEmpty(input.Sorting))
                orderString = input.SortedAsDescending ? $"{input.Sorting} desc" : input.Sorting;
            return orderString;
        }

        protected virtual List<T> SortList<T>(List<T> list, GetEntityListInput input)
            where T : class
        {
            var orderString = "CreationTime";
            if (!string.IsNullOrEmpty(input.Sorting))
                orderString = input.Sorting;

            if (input.SortedAsDescending)
                return list.OrderByDescending(p => p.GetType()
                    .GetProperty(orderString)
                    ?.GetValue(p, null)).ToList();

            return list.OrderBy(p => p.GetType()
                .GetProperty(orderString)
                ?.GetValue(p, null)).ToList();
        }*/
    }
}
