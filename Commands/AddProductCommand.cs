using DataStore;
using MediatR;

namespace MyCommand
{
   public record AddProductCommand(Product Product) : IRequest<Product>;
}