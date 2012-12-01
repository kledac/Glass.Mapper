﻿using Sitecore.Data.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Glass.Mapper.Sc
{
    public class SitecoreDataContext : IDataContext
    {
        public bool InferType { get; set; }

        public bool IsLazy { get; set; }

        public Type RequestedType { get; set; }

        public object[] ConstructorParameters { get; set; }

        public Item Item { get; set; }
    }
    
}
