


















// Generated on 01/12/2017 03:52:55
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameContextReadyMessage : NetworkMessage
{

public const uint Id = 6071;
public uint MessageId
{
    get { return Id; }
}

public int mapId;
        

public GameContextReadyMessage()
{
}

public GameContextReadyMessage(int mapId)
        {
            this.mapId = mapId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(mapId);
            

}

public void Deserialize(IDataReader reader)
{

mapId = reader.ReadInt();
            if (mapId < 0)
                throw new System.Exception("Forbidden value on mapId = " + mapId + ", it doesn't respect the following condition : mapId < 0");
            

}


}


}