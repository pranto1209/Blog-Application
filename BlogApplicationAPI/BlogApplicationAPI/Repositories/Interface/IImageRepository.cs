using BlogApplicationAPI.Models.Domain;

namespace BlogApplicationAPI.Repositories.Interface
{
    public interface IImageRepository
    {
        Task<BlogImage> Upload(IFormFile file, BlogImage blogImage);

        Task<IEnumerable<BlogImage>> GetAll();
    }
}
