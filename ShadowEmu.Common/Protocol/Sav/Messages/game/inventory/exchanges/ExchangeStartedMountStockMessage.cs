


















// Generated on 07/24/2016 18:36:00
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeStartedMountStockMessage : NetworkMessage
{

public const uint Id = 5984;
public uint MessageId
{
    get { return Id; }
}

public Types.ObjectItem[] objectsInfos;
        

public ExchangeStartedMountStockMessage()
{
}

public ExchangeStartedMountStockMessage(Types.ObjectItem[] objectsInfos)
        {
            this.objectsInfos = objectsInfos;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUShort((ushort)objectsInfos.Length);
            foreach (var entry in objectsInfos)
            {
                 entry.Serialize(writer);
            }
            

}

public void Deserialize(IDataReader reader)
{

var limit = reader.ReadUShort();
            objectsInfos = new Types.ObjectItem[limit];
            for (int i = 0; i < limit; i++)
            {
                 objectsInfos[i] = new Types.ObjectItem();
                 objectsInfos[i].Deserialize(reader);
            }
            

}


}


}