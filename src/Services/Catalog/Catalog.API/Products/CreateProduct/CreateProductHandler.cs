namespace Catalog.API.Products.CreateProduct;

public record CreateProductCommand(
    string Name, 
    List<string> Category, 
    string Description, 
    string ImageFile, 
    decimal Price
) : ICommand<CreateProductResult>;

public record CreateProductResult(Guid Id);

internal class CreateProductCommandHandler(IDocumentSession session)
    : ICommandHandler<CreateProductCommand, CreateProductResult>
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
        session.Store(product);
        await session.SaveChangesAsync(cancellationToken);

        // RETURN RESULT
        return new CreateProductResult(product.Id);
    }
}
