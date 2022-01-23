using FileTypeValidator.Infrastructure.Interfaces;

namespace FileTypeValidator.Infrastructure;

public class FileTypeValidator : IFileTypeValidator
{
    private readonly IFileContentProvider _contentProvider;

    public FileTypeValidator(IFileContentProvider contentProvider)
    {
        _contentProvider = contentProvider;
    }
    public bool IsImage(string fileName)
    {
        var contentType = _contentProvider.GetContentType(fileName);
        return contentType.StartsWith(FileTypes.Image);
    }
    
    public bool IsVideo(string fileName)
    {
        var contentType =  _contentProvider.GetContentType(fileName);
        return contentType.StartsWith(FileTypes.Video);
    }

    public bool IsAudio(string fileName)
    {
        var contentType =  _contentProvider.GetContentType(fileName);
        return contentType.StartsWith(FileTypes.Audio);
    }

    public bool IsDocument(string fileName)
    {
        var contentType =  _contentProvider.GetContentType(fileName);
        return (contentType.StartsWith(FileTypes.Text) ||
                contentType.Contains(FileTypes.Document) ||
                contentType.Contains(FileTypes.Pdf));
    }

    public bool IsFile(string fileName)
    {
        var contentType =  _contentProvider.GetContentType(fileName);
        return (contentType.StartsWith(FileTypes.Text) ||
                contentType.StartsWith(FileTypes.Video) ||
                contentType.StartsWith(FileTypes.Image) ||
                contentType.StartsWith(FileTypes.Audio) ||
                contentType.Contains(FileTypes.Document) ||
                contentType.Contains(FileTypes.Pdf));
    }
}