using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoService.EF;

namespace AutoService.Classes
{
    internal class ClassEntities
    {
        public static Entities context { get; set; } = new Entities();
    }
}
