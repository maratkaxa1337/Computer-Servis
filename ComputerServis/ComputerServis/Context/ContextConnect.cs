using ComputerServis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerServis.Context
{
    public class ContextConnect
    {
        public static dbcompEntities db = new dbcompEntities();
    }
}
