using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete.Enum
{
    public enum ProcessType
    {
        OutboundWireTransfer, // Giden Havale
        IncomingWireTransfer,  // Gelen Havale
        IncomingEFT ,
        OutgoingEFT
    }
}
