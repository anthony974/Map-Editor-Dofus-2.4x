


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class GameFightFighterInformations : GameContextActorInformations
{

public const short Id = 143;
public override short TypeId
{
    get { return Id; }
}

public sbyte teamId;
        public sbyte wave;
        public bool alive;
        public Types.GameFightMinimalStats stats;
        public uint[] previousPositions;
        

public GameFightFighterInformations()
{
}

public GameFightFighterInformations(double contextualId, Types.EntityLook look, Types.EntityDispositionInformations disposition, sbyte teamId, sbyte wave, bool alive, Types.GameFightMinimalStats stats, uint[] previousPositions)
         : base(contextualId, look, disposition)
        {
            this.teamId = teamId;
            this.wave = wave;
            this.alive = alive;
            this.stats = stats;
            this.previousPositions = previousPositions;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(teamId);
            writer.WriteSByte(wave);
            writer.WriteBoolean(alive);
            writer.WriteShort(stats.TypeId);
            stats.Serialize(writer);
            writer.WriteUShort((ushort)previousPositions.Length);
            foreach (var entry in previousPositions)
            {
                 writer.WriteVarShort((int)entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            teamId = reader.ReadSByte();
            if (teamId < 0)
                throw new System.Exception("Forbidden value on teamId = " + teamId + ", it doesn't respect the following condition : teamId < 0");
            wave = reader.ReadSByte();
            if (wave < 0)
                throw new System.Exception("Forbidden value on wave = " + wave + ", it doesn't respect the following condition : wave < 0");
            alive = reader.ReadBoolean();
            stats = ProtocolTypeManager.GetInstance<Types.GameFightMinimalStats>(reader.ReadShort());
            stats.Deserialize(reader);
            var limit = reader.ReadUShort();
            previousPositions = new uint[limit];
            for (int i = 0; i < limit; i++)
            {
                 previousPositions[i] = reader.ReadVarUhShort();
            }
            

}


}


}