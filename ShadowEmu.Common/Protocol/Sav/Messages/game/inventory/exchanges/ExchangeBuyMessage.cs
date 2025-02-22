


















// Generated on 07/24/2016 18:35:59
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeBuyMessage : NetworkMessage
{

public const uint Id = 5774;
public uint MessageId
{
    get { return Id; }
}

public uint objectToBuyId;
        public uint quantity;
        

public ExchangeBuyMessage()
{
}

public ExchangeBuyMessage(uint objectToBuyId, uint quantity)
        {
            this.objectToBuyId = objectToBuyId;
            this.quantity = quantity;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarInt((int)objectToBuyId);
            writer.WriteVarInt((int)quantity);
            

}

public void Deserialize(IDataReader reader)
{

objectToBuyId = reader.ReadVarUhInt();
            if (objectToBuyId < 0)
                throw new System.Exception("Forbidden value on objectToBuyId = " + objectToBuyId + ", it doesn't respect the following condition : objectToBuyId < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new System.Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}