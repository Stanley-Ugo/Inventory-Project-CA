using InventoryProject.Application.Mappers;
using InventoryProject.Application.Queries;
using InventoryProject.Application.Responses;
using InventoryProject.Core.Repositories;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryProject.Application.Handlers
{
    public class GetCategoryByCategoryNameHandler : IRequestHandler<GetCategoryByCategoryNameQuery, GetCategoryByCategoryNameResponse>
    {
        private readonly ICategoryRepository _categoryRepository;
        public GetCategoryByCategoryNameHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<GetCategoryByCategoryNameResponse> Handle(GetCategoryByCategoryNameQuery request, CancellationToken cancellationToken)
        {
            var categoryEntity = await _categoryRepository.GetCategoryByName(request.CategoryName);
            var categoryResponse = InventoryMapper.Mapper.Map<GetCategoryByCategoryNameResponse>(categoryEntity);
            return categoryResponse;
        }
    }
}
