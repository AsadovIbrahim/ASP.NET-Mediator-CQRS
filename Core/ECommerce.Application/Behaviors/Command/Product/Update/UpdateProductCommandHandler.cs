using ECommerce.Application.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Behaviors.Command.Product.Update
{
    public class UpdateProductCommandHandler : IRequestHandler<UpdateProductCommandRequest, UpdateProductCommandResponse>
    {
        private readonly IProductService _productService;
        public UpdateProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<UpdateProductCommandResponse> Handle(UpdateProductCommandRequest request, CancellationToken cancellationToken)
        {
            var product=await _productService.UpdateProductAsync(request);

            var response= new UpdateProductCommandResponse()
            {
                Message=product==HttpStatusCode.OK?"Updated!":"Can't Found!"
            };

            return response;
        }
    }
}
