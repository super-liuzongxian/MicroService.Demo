﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManageMicroService.Core.ConfigCenter
{
    public interface IConfigCenter
    {
        void ConfigurationConfigCenter(HostBuilderContext cxt,IConfigurationBuilder config);
    }
}
