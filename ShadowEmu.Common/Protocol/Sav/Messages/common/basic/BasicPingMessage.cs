


















// Generated on 07/24/2016 18:35:43
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class BasicPingMessage : NetworkMessage
{

public const uint Id = 182;
public uint MessageId
{
    get { return Id; }
}

public bool quiet;
        

public BasicPingMessage()
{
}

public BasicPingMessage(bool quiet)
        {
            this.quiet = quiet;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(quiet);
            

}

public void Deserialize(IDataReader reader)
{

quiet = reader.ReadBoolean();
            

}


}


}