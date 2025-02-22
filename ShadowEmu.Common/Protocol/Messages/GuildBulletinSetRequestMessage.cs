


















// Generated on 01/12/2017 03:53:00
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GuildBulletinSetRequestMessage : SocialNoticeSetRequestMessage
{

public const uint Id = 6694;
public uint MessageId
{
    get { return Id; }
}

public string content;
        public bool notifyMembers;
        

public GuildBulletinSetRequestMessage()
{
}

public GuildBulletinSetRequestMessage(string content, bool notifyMembers)
        {
            this.content = content;
            this.notifyMembers = notifyMembers;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(content);
            writer.WriteBoolean(notifyMembers);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            content = reader.ReadUTF();
            notifyMembers = reader.ReadBoolean();
            

}


}


}