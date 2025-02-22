


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class AlternativeMonstersInGroupLightInformations : NetworkType
{

public const short Id = 394;
public virtual short TypeId
{
    get { return Id; }
}

public int playerCount;
        public Types.MonsterInGroupLightInformations[] monsters;
        

public AlternativeMonstersInGroupLightInformations()
{
}

public AlternativeMonstersInGroupLightInformations(int playerCount, Types.MonsterInGroupLightInformations[] monsters)
        {
            this.playerCount = playerCount;
            this.monsters = monsters;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteInt(playerCount);
            writer.WriteShort((short)monsters.Length);
            foreach (var entry in monsters)
            {
                 entry.Serialize(writer);
            }
            

}

public virtual void Deserialize(IDataReader reader)
{

playerCount = reader.ReadInt();
            var limit = reader.ReadUShort();
            monsters = new Types.MonsterInGroupLightInformations[limit];
            for (int i = 0; i < limit; i++)
            {
                 monsters[i] = new Types.MonsterInGroupLightInformations();
                 monsters[i].Deserialize(reader);
            }
            

}


}


}