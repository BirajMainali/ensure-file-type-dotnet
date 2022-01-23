using FileTypeValidator.Infrastructure.Interfaces;
using Microsoft.AspNetCore.StaticFiles;

namespace FileTypeValidator.Infrastructure;

public class FileContentProvider : IFileContentProvider
{
    public string GetContentType(string fileName)
    {
        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(fileName, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        return contentType;
    }
}