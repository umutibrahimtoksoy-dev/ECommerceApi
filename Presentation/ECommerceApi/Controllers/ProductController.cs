using ECommerceApplication.UseCases.Commands.ProductCommands.AddProductCommand;
using ECommerceApplication.UseCases.Commands.ProductCommands.RemoveProductCommand;
using ECommerceApplication.UseCases.Commands.ProductCommands.UpdateProductCommand;
using ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetAllQuery;
using ECommerceApplication.UseCases.Queries.ProductQueries.ProductGetByIdQuery;
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
        public async Task<IActionResult> AddProduct([FromBody] AddProductCommandRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(result);
        }

        /// <summary>
        /// Deletes the Product entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(bool))]
        public async Task<IActionResult> RemoveProduct([FromRoute] int id)
        {
            var result = await _mediator.Send(new RemoveProductCommandRequest(id));
            return Ok(result);
        }

        /// <summary>
        /// Update the Product entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(int))]
        public async Task<IActionResult> UpdateProduct([FromBody] UpdateProductCommandRequest request)
        {
            var result = await _mediator.Send(request);

            return Ok(result);
        }

        /// <summary>
        /// Get the Product entity by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(ProductGetByIdQueryResponse))]
        public async Task<IActionResult> GetByProductId([FromRoute] int id)
        {
            var result = await _mediator.Send(new ProductGetByIdQueryRequest(id));
            return Ok(result);
        }

        /// <summary>
        /// Get the all Product entity
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(List<ProductGetAllQueryResponse>))]
        public async Task<IActionResult> GetAll()
        {
            var result = await _mediator.Send(new ProductGetAllQueryRequest());
            return Ok(result);
        }
    }
}
