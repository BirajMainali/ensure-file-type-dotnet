namespace FileTypeValidator.Infrastructure.Interfaces;

public interface IFileContentProvider
{
    string GetContentType(string fileName);
}