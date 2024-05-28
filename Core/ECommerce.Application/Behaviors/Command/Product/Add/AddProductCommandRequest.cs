using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Application.Behaviors.Command.Product.Add
{
    public class AddProductCommandRequest:IRequest<AddProductCommandResponse>
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }

        // Foreign Key
        public int CategoryId { get; set; }
    }
}
