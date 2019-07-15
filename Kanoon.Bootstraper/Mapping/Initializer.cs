using AutoMapper;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Kanoon.Bootstraper.Mapping
{
    public static class Initializer
    {
        public static void Initial()
        {
            Mapper.Initialize(c =>
            {
                c.AddProfiles(typeof(HeiatProfileMapping).GetTypeInfo().Assembly);
            });

        }
    }
}
