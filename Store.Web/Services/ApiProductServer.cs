using Store.Dto;
using Store.Service.Contract;
using System.Net.Http.Json;

namespace Store.Web.Services
{
    public class ApiProductServer : IProductService
    {
        protected readonly HttpClient _httpClient;

        public ApiProductServer(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<int> AddProduct(ProductDto product)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductDto>> GetAll()
        {
            var response = await _httpClient.GetFromJsonAsync<List<ProductDto>>($"Product");
            return response ?? throw new HttpRequestException("Couldn't get vessels");
        }

        public Task<ProductDto> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(ProductDto request)
        {
            throw new NotImplementedException();
        }
    }
}
