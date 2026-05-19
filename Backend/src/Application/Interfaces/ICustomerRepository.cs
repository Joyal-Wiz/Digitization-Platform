using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ICustomerRepository
    {
        Task<Customer> AddAsync(Customer customer);

        Task<List<Customer>> GetAllAsync();

        Task<Customer?> GetByIdAsync(int id);
        Task DeleteAsync(Customer customer);
    }
}
