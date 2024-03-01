using MediatR;
using InventoryProject.Application.Responses;
using System.ComponentModel.DataAnnotations;

namespace InventoryProject.Application.Queries
{
    public class GetCategoryByCategoryNameQuery : IRequest<GetCategoryByCategoryNameResponse>
    {
        [Required]
        public string CategoryName { get; set; }

        public GetCategoryByCategoryNameQuery(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
