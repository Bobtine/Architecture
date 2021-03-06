using Microsoft.Extensions.Logging;
using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cds.BusinessCustomer.Api.CustomerFeature
{
    public class CustomerHandler
    {
        private readonly ILogger<CustomerHandler> _logger;

        public CustomerHandler(ILogger<CustomerHandler> logger)
        {
            _logger = logger;
        }

        public bool Validate(string siret)
        {
            if (siret.Length != 14)
            {
                _logger.LogError($"Failed to retreive customer with siret = {siret}, Siret string should be of length 14");
            //    throw new InvalidArgumentException(nameof(siret));
            //    return BadRequest(new { code = "400", message = "Invalid Siret - should be of length 14" });
                return false;
            }
            return true;
        }
    }
}
