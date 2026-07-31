[Back](../../../README.md)


Use the MubBlazor template to create ne project

Using Blazor PDF

https://blazorpdf.info/docs/mudblazor/quickstart


Minimal api to server the PDF

```
// --- MINIMAL API FOR FILE DOWNLOAD ---
app.MapGet("/download/{fileName}", (string fileName) =>
{
    // Define your secure file directory
    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "Files", fileName);

    if (!File.Exists(filePath))
    {
        return Results.NotFound("File not found.");
    }

    // Return the file with the correct content type
    return Results.File(filePath, "application/octet-stream", fileName);
});
```

[Back](../../../README.md)