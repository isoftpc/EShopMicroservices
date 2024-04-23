using BuildingBlocks.CQRS;
using MediatR;

namespace Catalog.API.Products.CreateProduct
{
    public record CreateProductCommand(
        string Name,
        List<string> Category,
        string Description,
        string ImageFile,
        decimal Price) : ICommand<CreateProductResult>;
    public record CreateProductResult(Guid id);

    internal class CreateProductCommandHandler : ICommandHandler<CreateProductCommand,CreateProductResult>
    {
        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            //Business logic to create product
            throw new NotImplementedException();
        }
    }
}
