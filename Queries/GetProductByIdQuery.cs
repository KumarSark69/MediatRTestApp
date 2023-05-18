using DataStore;
using MediatR;

namespace MyQuries
{
    public record GetProductByIdQuery(int Id) : IRequest<Product>;
}