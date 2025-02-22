


















// Generated on 07/24/2016 18:36:00
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeRequestedMessage : NetworkMessage
{

public const uint Id = 5522;
public uint MessageId
{
    get { return Id; }
}

public sbyte exchangeType;
        

public ExchangeRequestedMessage()
{
}

public ExchangeRequestedMessage(sbyte exchangeType)
        {
            this.exchangeType = exchangeType;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(exchangeType);
            

}

public void Deserialize(IDataReader reader)
{

exchangeType = reader.ReadSByte();
            

}


}


}