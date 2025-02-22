


















// Generated on 01/12/2017 03:52:57
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameRolePlayPlayerFightFriendlyAnswerMessage : NetworkMessage
{

public const uint Id = 5732;
public uint MessageId
{
    get { return Id; }
}

public int fightId;
        public bool accept;
        

public GameRolePlayPlayerFightFriendlyAnswerMessage()
{
}

public GameRolePlayPlayerFightFriendlyAnswerMessage(int fightId, bool accept)
        {
            this.fightId = fightId;
            this.accept = accept;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteInt(fightId);
            writer.WriteBoolean(accept);
            

}

public void Deserialize(IDataReader reader)
{

fightId = reader.ReadInt();
            accept = reader.ReadBoolean();
            

}


}


}