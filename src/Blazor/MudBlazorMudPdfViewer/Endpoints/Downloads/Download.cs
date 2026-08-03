namespace MudBlazorMudPdfViewer.Endpoints.Downloads;

public class Download : IEndpoint
{
    public void MapEndpoint(IEndpointRouteBuilder app)
    {
        app.MapGet("/download/{fileName}", (string fileName) =>
        {
            // Define your secure file directory
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\filestore", fileName);

            if (!File.Exists(filePath))
            {
                return Results.NotFound("File not found.");
            }

            // Return the file with the correct content type
            return Results.File(filePath, "application/octet-stream", fileName);
        })
        .WithTags(Tags.Downloads)
        .AllowAnonymous();
    }
}