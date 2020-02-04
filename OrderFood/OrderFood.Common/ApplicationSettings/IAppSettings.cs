using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderFood.Common.ApplicationSettings
{
    public interface IAppSettings
    {
        int DefaultPageSize { get; }
    }
}
