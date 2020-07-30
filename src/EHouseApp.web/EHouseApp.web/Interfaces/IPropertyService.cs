using EHouseApp.web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EHouseApp.web.Interfaces
{
    public interface IPropertyService
    {
        Task AddProperty(PropertyModel model);
    }
}