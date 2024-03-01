using InventoryProject.Application.Responses;
using MediatR;
using System.ComponentModel.DataAnnotations;

namespace InventoryProject.Application.Commands
{
    public class CreateCategoryCommand : IRequest<CreateCategoryResponse>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
