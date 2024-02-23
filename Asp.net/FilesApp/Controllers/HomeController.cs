namespace FilesApp.Controllers;

using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> UploadAvatar(IFormFile file) {
        var newUserId = Guid.NewGuid();
        var fileExtension = new FileInfo(file.FileName).Extension;

        var filename = $"{newUserId}{fileExtension}";

        var destinationAvatarPath = $"Avatars/{filename}";

        using var fileStream = System.IO.File.Create(destinationAvatarPath);
        await file.CopyToAsync(fileStream);

        return base.RedirectToAction("Index");
    }

    public IActionResult Avatar(string filepath) {
        var fileExtension = new FileInfo(filepath).Extension;
        var stream = System.IO.File.Open($"Avatars/{filepath}", FileMode.Open);

        return base.File(stream, $"image/{fileExtension[1..]}", $"downloadfile{fileExtension}");
    }
}
