using FileTypeValidator.Infrastructure.Interfaces;
using Microsoft.AspNetCore.StaticFiles;

namespace FileTypeValidator.Infrastructure;

public class FileTypeValidator : IFileTypeValidator
{
    public bool IsImage(string fileName)
    {
        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(fileName, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        return contentType.StartsWith("image");
    }

    public bool IsVideo(string fileName)
    {
        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(fileName, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        return contentType.StartsWith("video");
    }

    public bool IsAudio(string fileName)
    {
        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(fileName, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        return contentType.StartsWith("audio");
    }

    public bool IsDocument(string fileName)
    {
        var provider = new FileExtensionContentTypeProvider();
        if (!provider.TryGetContentType(fileName, out var contentType))
        {
            contentType = "application/octet-stream";
        }

        return (contentType.StartsWith("text") || contentType.Contains("document") || contentType.Contains("pdf"));
    }
}