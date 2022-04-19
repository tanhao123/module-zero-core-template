using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;

namespace AbpCompanyName.AbpProjectName.Base
{
    /// <summary>
    /// the get entity list input
    /// </summary>
    /// <seealso cref="Abp.Application.Services.Dto.IPagedAndSortedResultRequest" />
    public class GetEntityListInput : IPagedAndSortedResultRequest
    {
        public GetEntityListInput()
        {
            MaxResultCount = 10;
        }

        /// <summary>
        /// Gets or sets the maximum result count.
        /// </summary>
        /// <value>
        /// The maximum result count.
        /// </value>
        [Range(1, 200)]
        public virtual int MaxResultCount { get; set; }

        /// <summary>
        /// Gets or sets the skip count.
        /// </summary>
        /// <value>
        /// The skip count.
        /// </value>
        [Range(0, int.MaxValue)]
        public int SkipCount { get; set; }

        /// <summary>
        /// Gets or sets the sorting.
        /// </summary>
        /// <value>
        /// The sorting.
        /// </value>
        [StringLength(150)]
        public string Sorting { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether [sorted as descending].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [sorted as descending]; otherwise, <c>false</c>.
        /// </value>
        public bool SortedAsDescending { get; set; }
    }
    public class GetEntityInput : EntityDto
    {

    }

    public class GetEntityInput<TPrimaryKey> : EntityDto<TPrimaryKey>
    {

    }
}
