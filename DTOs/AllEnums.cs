using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOs
{
    public enum Role { 
        Admin=0 , Seller=1 , Visitor=2
    }

    public enum SaveState { 
       Failed = 0, Success = 1
    }
}
