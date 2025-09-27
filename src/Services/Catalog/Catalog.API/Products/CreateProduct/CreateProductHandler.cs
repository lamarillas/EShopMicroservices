using BuildingBlocks.CQRS;
using Catalog.API.Models;
using MediatR;

namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(
    string Name, 
    List<string> Category, 
    string Description, 
    string ImageFile, 
    decimal Price
) : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

public class CreateProductHandler : ICommandHandler<CreateProductCommand, CreateProductResult>
{
    public async Task<CreateProductResult> Handle(CreateProductCommand command, CancellationToken cancellationToken)
    {
        // CREATE Product ENTITY FROM COMMAND OBJECT
        var product = new Product
        {
            Name = command.Name,
            Category = command.Category,
            Descripcion = command.Description,
            ImageFile = command.ImageFile,
            Price = command.Price
        };


        // TODO: Save to DB


        // RETURN RESULT
        return new CreateProductResult(Guid.NewGuid());

    }
}
