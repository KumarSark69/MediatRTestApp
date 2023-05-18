using DataStore;
using MediatR;

namespace MyQuries
{
    public record GetProductsQuery() : IRequest<IEnumerable<Product>>;
}