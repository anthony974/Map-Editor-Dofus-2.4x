


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class PartyLeaveMessage : AbstractPartyMessage
{

public const uint Id = 5594;
public uint MessageId
{
    get { return Id; }
}



public PartyLeaveMessage()
{
}

public PartyLeaveMessage(uint partyId)
         : base(partyId)
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