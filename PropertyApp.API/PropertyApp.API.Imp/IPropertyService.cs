using PropertyApp.API.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyApp.API.Imp
{
    public interface IPropertyService
    {
        IList<Property> GetProperties();
        Property GetPropertById(int id);
        IEnumerable<Property> GetPropertByPostcode(string id);
        void DeleteProperty(int id);
    }
}
