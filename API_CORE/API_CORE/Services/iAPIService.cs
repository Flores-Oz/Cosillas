using API_CORE.Models;

namespace API_CORE.Services
{
    public interface IAPIService
    {
        Task<List<modelProduct>> List();
        Task<modelProduct> Get(int productID);
        Task<bool> Save(modelProduct product);
        Task<bool> Delete(int productID); 
        Task<bool> Edit(modelProduct product);
    }
}
