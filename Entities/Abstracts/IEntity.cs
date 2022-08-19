using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Abstracts
{
    public interface IEntity
    {
        Guid Id { get; set; }
        DateTime? Created { get; set; }
        DateTime? Changed { get; set; }
        

    }
}
