using ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand;
using ECommerceApplication.UseCases.Commands.ProductCommands.RemoveProductCommand;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// New entity creating to Product
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public async Task<int> AddProduct([FromBody] AddProductCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return result;
        }

        /// <summary>
        /// Deletes the Product entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<bool> RemoveProduct([FromRoute] int id)
        {
            var result = await _mediator.Send(new RemoveProductCommandRequest(id));

            return result;
        }
    }
}
