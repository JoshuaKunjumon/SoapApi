using System.Runtime.Serialization;
using System.ServiceModel;
using static SoapApi.Models.CustomerDataContract;
using static SoapApi.Models.CustomerServiceContract;

namespace SoapApi.Models
{
    public class CustomerDataContract
    {
        [DataContract]
        public class Author
        {
            [DataMember]
            public string Name { get; set; }
            [DataMember]
            public string Description { get; set; }
            [DataMember]
            public string Email { get; set; }

        }
    }

    public class CustomerServiceContract
    {
        [ServiceContract]
        public interface ICustomerService
        {
            [OperationContract]
            Author GetCustomers();
        }
    }

    public class CustomerService : ICustomerService
    {
        public Author GetCustomers()
        {
            return new Author
            {
                Name = "test",
                Description = "test",
                Email = "test",
            };

        }
    }
}
