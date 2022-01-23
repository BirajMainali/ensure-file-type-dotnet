namespace FileTypeValidator.Infrastructure.Interfaces;

public interface IFileTypeValidator
{
    bool IsImage(string fileName);
    bool IsVideo(string fileName);
    bool IsAudio(string fileName);
    bool IsDocument(string fileName);
}