


















// Generated on 01/12/2017 03:53:03
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeStoppedMessage : NetworkMessage
{

public const uint Id = 6589;
public uint MessageId
{
    get { return Id; }
}

public double id;
        

public ExchangeStoppedMessage()
{
}

public ExchangeStoppedMessage(double id)
        {
            this.id = id;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarLong(id);
            

}

public void Deserialize(IDataReader reader)
{

id = reader.ReadVarUhLong();
            if (id < 0 || id > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on id = " + id + ", it doesn't respect the following condition : id < 0 || id > 9.007199254740992E15");
            

}


}


}