using DataStore;
using MediatR;

namespace MyNotification
{
    public record ProductAddedNotification(Product Product) : INotification;
}