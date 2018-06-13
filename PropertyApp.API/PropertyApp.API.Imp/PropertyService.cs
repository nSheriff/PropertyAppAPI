using PropertyApp.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PropertyApp.API.Imp
{
    public class PropertyService: IPropertyService
    {
        private readonly PropertyContext _context;
        private bool iSTestDataSet = false;
        public PropertyService(PropertyContext context)
        {
            _context = context;

            AddTestData();

        }

        private void AddTestData()
        {
            var property1= new Property()
            {
                PropertyId=1,
                Address = "Dummy Street 56",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",
                PictureName = "picture1",
                Postcode = "CV6 4PE",
                Price = 150000,
                PropertyIsDeleted = false
            };

            var property2 = new Property()
            {
                PropertyId = 2,
                Address = "Dummy RD 100",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",
                PictureName = "picture2",
                Postcode = "CV6 4PE",
                Price = 150000,
                PropertyIsDeleted = false
            };

            var property3 = new Property()
            {
                PropertyId = 3,
                Address = "Dummy Street 13",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",
                PictureName = "picture3",
                Postcode = "CV6 4PE",
                Price = 150000,
                PropertyIsDeleted = false
            };

            var property4 = new Property()
            {
                PropertyId = 4,
                Address = "Dummy Road 145",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",
                PictureName = "picture4",
                Postcode = "CV6 4PE",
                Price = 150000,
                PropertyIsDeleted = false
            };

            var property5 = new Property()
            {
                PropertyId = 5,
                Address = "Dummy Street 10",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",
                PictureName = "picture3",
                Postcode = "CV2 4EB",
                Price = 150000,
                PropertyIsDeleted = false
            };

            var property6 = new Property()
            {
                PropertyId = 6,
                Address = "Dummy Road 20",
                Description = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries.",
                PictureName = "picture4",
                Postcode = "CV2 4EB",
                Price = 150000,
                PropertyIsDeleted = false
            };

            if (!IsRecordExiist(property1.PropertyId))
            {
                _context.Properties.Add(property1);
            }

            if (!IsRecordExiist(property2.PropertyId))
            {
                _context.Properties.Add(property2);
            }

            if (!IsRecordExiist(property3.PropertyId))
            {
                _context.Properties.Add(property3);
            }

            if (!IsRecordExiist(property4.PropertyId))
            {
                _context.Properties.Add(property4);
            }

            if (!IsRecordExiist(property5.PropertyId))
            {
                _context.Properties.Add(property5);
            }

            if (!IsRecordExiist(property6.PropertyId))
            {
                _context.Properties.Add(property6);
            }

            _context.SaveChanges();
        }

        private bool IsRecordExiist(int id)
        {
            var property = _context.Properties.FirstOrDefault(p => p.PropertyId == id);
            return (property != null);
        }

        public IList<Property> GetProperties()
        {
            return _context.Properties.Where(p=> !p.PropertyIsDeleted).ToList();
        }

        public Property GetPropertById(int id)
        {
            return _context.Properties.FirstOrDefault(p => p.PropertyId == id);
        }

        public IEnumerable<Property> GetPropertByPostcode(string id)
        {
            return _context.Properties.Where(p => p.Postcode.Equals(id)).ToList();
        }

        public void DeleteProperty(int id)
        {
            var property = _context.Properties.FirstOrDefault(p => p.PropertyId == id);
            if(property != null)
            {
                property.PropertyIsDeleted = true;
                _context.SaveChanges();
            }
        }
    }
}
