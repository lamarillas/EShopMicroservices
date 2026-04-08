
namespace Catalog.API.Products.GetProductById;

public record GetProductByIdResponse(Product Product);


public class GetProductByIdEndpoint : ICarterModule
{
    public void AddRoutes(IEndpointRouteBuilder app)
    {
        app.Map("/products/{id}", async (Guid id, ISender sender) => {
            var result = await sender.Send(new GetProductByIdQuery(id));

            var response = result.Adapt<GetProductByIdResponse>();

            return Results.Ok(response);
        })
        .WithName("GetProductById")
        .Produces<GetProductByIdResponse>(StatusCodes.Status200OK)
        .WithSummary("Get Product By Id")
        .WithDescription("Get Product By Id");
    }
}
