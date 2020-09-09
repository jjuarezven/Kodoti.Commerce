using Catalog.Services.Queries.DTO;
using Service.Common.Collection;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.Services.Queries
{
    public interface IProductQueryService
    {
        Task<DataCollection<ProductDto>> GetAllAsync(int page, int take, IEnumerable<int> products = null);
        Task<ProductDto> GetAsync(int id);
    }
}