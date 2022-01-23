# FileTypeValidator
 FileTypeValidator do not allow users to inject invalid file. It validate files by its content types which is more accurate. Also it is easy to use.
 After using `FileTypeValidator` we can validate file by contact types such as Image,Audio,Video and document/text.
 
 ### Configuration
 
 Di configuration for dotnet 6 project.
 ```cs
   var builder = WebApplication.CreateBuilder(args);
   builder.Services.UseFileTypeValidator();
```
Di configuration for dotnet 5 project C# 10.
```cs
  public void ConfigureServices(IServiceCollection services) 
  {
      services.UseFileTypeValidator();
   }
        
 ```
 
### Usage

Dependency injection
```cs

    private readonly IFileTypeValidator _fileTypeValidator;

    public HomeController(IFileTypeValidator fileTypeValidator)
    {
        _fileTypeValidator = fileTypeValidator;
    }
```

```cs
    if (!_fileTypeValidator.IsAudio(fileName))
        {
            throw new Exception("Invalid file for audio");
        }
```
Avliable methods to validate file content are `IsImage`,`IsVideo`,`IsAudio` and `IsDocument`. 
