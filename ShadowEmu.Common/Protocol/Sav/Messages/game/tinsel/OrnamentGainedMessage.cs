


















// Generated on 07/24/2016 18:36:04
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class OrnamentGainedMessage : NetworkMessage
{

public const uint Id = 6368;
public uint MessageId
{
    get { return Id; }
}

public short ornamentId;
        

public OrnamentGainedMessage()
{
}

public OrnamentGainedMessage(short ornamentId)
        {
            this.ornamentId = ornamentId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteShort(ornamentId);
            

}

public void Deserialize(IDataReader reader)
{

ornamentId = reader.ReadShort();
            if (ornamentId < 0)
                throw new System.Exception("Forbidden value on ornamentId = " + ornamentId + ", it doesn't respect the following condition : ornamentId < 0");
            

}


}


}