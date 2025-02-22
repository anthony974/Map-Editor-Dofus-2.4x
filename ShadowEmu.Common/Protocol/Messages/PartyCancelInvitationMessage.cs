


















// Generated on 01/12/2017 03:52:58
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class PartyCancelInvitationMessage : AbstractPartyMessage
{

public const uint Id = 6254;
public uint MessageId
{
    get { return Id; }
}

public double guestId;
        

public PartyCancelInvitationMessage()
{
}

public PartyCancelInvitationMessage(uint partyId, double guestId)
         : base(partyId)
        {
            this.guestId = guestId;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarLong(guestId);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guestId = reader.ReadVarUhLong();
            if (guestId < 0 || guestId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on guestId = " + guestId + ", it doesn't respect the following condition : guestId < 0 || guestId > 9.007199254740992E15");
            

}


}


}