using InventoryProject.Application.Commands;
using InventoryProject.Application.Mappers;
using InventoryProject.Application.Responses;
using InventoryProject.Core.Entities;
using InventoryProject.Core.Repositories;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace InventoryProject.Application.Handlers
{
    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, CreateCategoryResponse>
    {
        private readonly ICategoryRepository _categoryRepository;
        public CreateCategoryCommandHandler(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<CreateCategoryResponse> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            var categoryEntity = InventoryMapper.Mapper.Map<Category>(request);
            if (categoryEntity is null)
            {
                throw new ApplicationException(message: "There is an issue with mapping...");
            }
            var newCategory = await _categoryRepository.AddAsync(categoryEntity);
            var categoryResponse = InventoryMapper.Mapper.Map<CreateCategoryResponse>(newCategory);
            return categoryResponse;
        }
    }
}
