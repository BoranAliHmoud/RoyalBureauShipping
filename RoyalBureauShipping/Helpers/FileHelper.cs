using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Http;
using System.Runtime.InteropServices;
namespace Certificate.Helpers
{
    public class FileHelper
    {
        protected readonly IHostEnvironment _env;
 
        public FileHelper(IHostEnvironment env )
        {
            this._env = env;
        }
        public bool PhotoAdd(string ImagesPath, Byte[] imagebase64, string filename, string fileextension)
        {
            bool Result = false;
            Dictionary<string, object> result = new Dictionary<string, object>();
            string appDataPath = Path.Combine(_env.ContentRootPath, ImagesPath);
            try
            {
                if (!Directory.Exists(appDataPath))
                    Directory.CreateDirectory(appDataPath);
                string imagesServerPath = appDataPath;
                string filePath = imagesServerPath + filename + "." + fileextension;
                //Byte[] bytes = Convert.FromBase64String(imagebase64);
                //System.IO.File.WriteAllBytes(filePath, bytes);
                FileStream fswebp = new FileStream(filePath.ToLower().Replace(".jpg", ".webp").Replace(".png", ".webp").Replace(".jpeg", ".webp"), FileMode.OpenOrCreate, FileAccess.ReadWrite);
                MemoryStream myMemOutwebp = new MemoryStream(imagebase64);
                myMemOutwebp.WriteTo(fswebp);
                fswebp.Flush();
                fswebp.Close();
                fswebp.Dispose();
                myMemOutwebp.Flush();
                myMemOutwebp.Close();
                myMemOutwebp.Dispose();
                //SaveImageWithPostNumber(imagesServerPath, filename, filePath); 
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        //public void SaveImageWithPostNumber(string imagesServerPath, string fileName, string filePath)
        //{
        //    string postNumber = string.Empty;
        //    CMS.Config.CMSConfigurations config = CMS.Config.CMSConfigurations.GetSection();
        //    foreach (CMS.Config.CMSImageInfo imginfo in config.Images)
        //    {
        //        string namerest = (string.IsNullOrEmpty(imginfo.OverrideName) ? imginfo.Name : imginfo.OverrideName); 

        //        CMS.Helpers.ImageHelper.SaveImage(imagesServerPath + fileName + "_" + namerest, filePath, "", imginfo.Width, imginfo.Height, imginfo.Anchor, imginfo.ResizeMode,
        //            (imginfo.ImageFormat == "png" ? System.Drawing.Imaging.ImageFormat.Png : System.Drawing.Imaging.ImageFormat.Jpeg), imginfo.BaseImage, imginfo.Padding, null);
        //    } 
        //    CMS.Helpers.ImageHelper.SaveImage(imagesServerPath + fileName + "_thumb" + ".png", filePath, "", 192, 141, CMS.Helpers.ImageHelper.Anchor.Center, CMS.Helpers.ImageHelper.PicResizeMode.Transparent, System.Drawing.Imaging.ImageFormat.Png, null, 0, null);
        //}
    }
}
