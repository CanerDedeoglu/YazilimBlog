using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using YazılımBlog.Entities.Dtos;
using YazılımBlog.Shared.Utilities.Results.Abstract;

namespace YazılımBlog.Mvc.Helpers.Abstract
{
    public interface IImageHelper
    {
        Task<IDataResult<ImageUploadedDto>> UploadUserImage(string userName, IFormFile pictureFile, string folderName = "userImages");
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
