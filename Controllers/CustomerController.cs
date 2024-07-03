using Microsoft.AspNetCore.Mvc;
using ServiceReference1;

namespace SoapApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        public CustomerController() { }

        [HttpGet]
        [Route("GetAuthors")]
        public async Task<Author> GetAuthors()
        {
            var service = new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await service.GetCustomersAsync();
        }
        [HttpGet]
        [Route("GetAuthorsForever")]
        public async Task<Author> GetAuthorsForever()
        {
            var service = new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await service.GetCustomersAsync();
        }
        [HttpGet]
        [Route("GetAuthorsEverywhere")]
        public async Task<Author> GetAuthorsEverywhere()
        {
            var service = new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await service.GetCustomersAsync();
        }


    }
}
