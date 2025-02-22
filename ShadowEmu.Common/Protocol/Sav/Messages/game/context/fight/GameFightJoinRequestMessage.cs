


















// Generated on 07/24/2016 18:35:49
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameFightJoinRequestMessage : NetworkMessage
{

public const uint Id = 701;
public uint MessageId
{
    get { return Id; }
}

public double fighterId;
        public int fightId;
        

public GameFightJoinRequestMessage()
{
}

public GameFightJoinRequestMessage(double fighterId, int fightId)
        {
            this.fighterId = fighterId;
            this.fightId = fightId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteDouble(fighterId);
            writer.WriteInt(fightId);
            

}

public void Deserialize(IDataReader reader)
{

fighterId = reader.ReadDouble();
            if (fighterId < -9.007199254740992E15 || fighterId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on fighterId = " + fighterId + ", it doesn't respect the following condition : fighterId < -9.007199254740992E15 || fighterId > 9.007199254740992E15");
            fightId = reader.ReadInt();
            

}


}


}