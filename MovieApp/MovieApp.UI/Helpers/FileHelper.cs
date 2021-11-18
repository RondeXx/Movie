using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace MovieApp.UI.Helpers
{
    public class FileHelper
    {
        public static string UploadFile(IFormFile file, string path)
        {

            if (file == null)
            {
                return "";
            }
            else {

                Guid guid = Guid.NewGuid();
                string ext = Path.GetExtension(file.FileName);
                string name = guid + ext;

                string SavePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/" + path, name);
                using (var stream = new FileStream(SavePath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return "/" + path + "/" + name;

            }
        }

        public static bool DeleteFile(string path)
        {
            if (File.Exists(path) == true)
            //Exists true yada false dönen bir metod true ise yani dosya var ise işlem yap dedik
            {
                File.Delete(path); //true imiş delete ile gelen url komple sil
                return true;
            }
            return false;
        }
    }
}
