


















// Generated on 07/24/2016 18:35:44
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class FriendGuildSetWarnOnAchievementCompleteMessage : NetworkMessage
{

public const uint Id = 6382;
public uint MessageId
{
    get { return Id; }
}

public bool enable;
        

public FriendGuildSetWarnOnAchievementCompleteMessage()
{
}

public FriendGuildSetWarnOnAchievementCompleteMessage(bool enable)
        {
            this.enable = enable;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteBoolean(enable);
            

}

public void Deserialize(IDataReader reader)
{

enable = reader.ReadBoolean();
            

}


}


}