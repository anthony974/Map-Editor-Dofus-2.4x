


















// Generated on 07/24/2016 18:36:07
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class GuildInformations : BasicGuildInformations
{

public const short Id = 127;
public override short TypeId
{
    get { return Id; }
}

public Types.GuildEmblem guildEmblem;
        

public GuildInformations()
{
}

public GuildInformations(uint guildId, string guildName, byte guildLevel, Types.GuildEmblem guildEmblem)
         : base(guildId, guildName, guildLevel)
        {
            this.guildEmblem = guildEmblem;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            guildEmblem.Serialize(writer);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            guildEmblem = new Types.GuildEmblem();
            guildEmblem.Deserialize(reader);
            

}


}


}