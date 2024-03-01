using InventoryProject.Application.Commands;
using InventoryProject.Application.Queries;
using InventoryProject.Application.Responses;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InventoryProject.API.Controllers
{
    public class CategoryController : ApiController
    {
        private readonly IMediator _mediator;
        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<GetCategoryByCategoryNameResponse>> GetCategoryByCategoryName([FromQuery] string categoryName)
        {
            var query = new GetCategoryByCategoryNameQuery(categoryName);
            var result = await _mediator.Send(query);
            return Ok(result);
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CreateCategoryResponse>> CreateCategory([FromBody] CreateCategoryCommand createCategoryCommand)
        {
            var result = await _mediator.Send(createCategoryCommand);
            return Ok(result);
        }
    }
}
