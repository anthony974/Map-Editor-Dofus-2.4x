


















// Generated on 07/24/2016 18:35:59
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeMountsStableBornAddMessage : ExchangeMountsStableAddMessage
{

public const uint Id = 6557;
public uint MessageId
{
    get { return Id; }
}



public ExchangeMountsStableBornAddMessage()
{
}

public ExchangeMountsStableBornAddMessage(Types.MountClientData[] mountDescription)
         : base(mountDescription)
        {
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            

}


}


}