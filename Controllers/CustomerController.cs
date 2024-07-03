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
        public async Task<Author> GetAuthors()
        {
            var service = new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await service.GetCustomersAsync();
        }

        [HttpGet]
        public async Task<Author> GetAuthors2()
        {
            var service = new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await service.GetCustomersAsync();
        }

        [HttpGet]
        public async Task<Author> GetAuthors3()
        {
            var service = new CustomerServiceClient(CustomerServiceClient.EndpointConfiguration.BasicHttpBinding_ICustomerService);
            return await service.GetCustomersAsync();
        }

    }
}
