using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Utilities
{
    public static class SerialsMaker
    {
        public static string SingleProductSerial() {
            return DateTime.Now.ToString();
        }
    }
}
