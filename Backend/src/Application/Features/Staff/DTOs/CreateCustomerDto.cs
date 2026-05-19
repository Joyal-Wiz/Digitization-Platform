using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Features.Staff.DTOs
{
    public class CreateCustomerDto
    {
        public string FullName { get; set; }

        public string PhoneNumber { get; set; }

        public string Address { get; set; }
    }
}
