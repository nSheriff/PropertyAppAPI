using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PropertyApp.API.Data;
using PropertyApp.API.Imp;

namespace PropertyApp.API.Controllers
{
    [Produces("application/json")]
    [Route("api/properties")]
    public class ValuesController : Controller
    {
        IPropertyService _propertyService;
        public ValuesController(IPropertyService propertyService)
        {
            _propertyService = propertyService;
        }
       
        [HttpGet]
        public IEnumerable<Property> Get()
        {
           return _propertyService.GetProperties();
            
        }
        
        [HttpGet("{id:int}")]
        public Property Get(int id)
        {
            return _propertyService.GetPropertById(id);
        }

        
        [HttpGet("{postcode}")]
        public IEnumerable<Property> Get(string postcode)
        {
            return _propertyService.GetPropertByPostcode(postcode);
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _propertyService.DeleteProperty(id);
        }
    }
}
