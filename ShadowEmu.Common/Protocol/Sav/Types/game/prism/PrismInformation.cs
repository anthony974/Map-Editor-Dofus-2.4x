


















// Generated on 07/24/2016 18:36:09
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class PrismInformation : NetworkType
{

public const short Id = 428;
public virtual short TypeId
{
    get { return Id; }
}

public sbyte typeId;
        public sbyte state;
        public int nextVulnerabilityDate;
        public int placementDate;
        public uint rewardTokenCount;
        

public PrismInformation()
{
}

public PrismInformation(sbyte typeId, sbyte state, int nextVulnerabilityDate, int placementDate, uint rewardTokenCount)
        {
            this.typeId = typeId;
            this.state = state;
            this.nextVulnerabilityDate = nextVulnerabilityDate;
            this.placementDate = placementDate;
            this.rewardTokenCount = rewardTokenCount;
        }
        

public virtual void Serialize(IDataWriter writer)
{

writer.WriteSByte(typeId);
            writer.WriteSByte(state);
            writer.WriteInt(nextVulnerabilityDate);
            writer.WriteInt(placementDate);
            writer.WriteVarInt((int)rewardTokenCount);
            

}

public virtual void Deserialize(IDataReader reader)
{

typeId = reader.ReadSByte();
            if (typeId < 0)
                throw new System.Exception("Forbidden value on typeId = " + typeId + ", it doesn't respect the following condition : typeId < 0");
            state = reader.ReadSByte();
            if (state < 0)
                throw new System.Exception("Forbidden value on state = " + state + ", it doesn't respect the following condition : state < 0");
            nextVulnerabilityDate = reader.ReadInt();
            if (nextVulnerabilityDate < 0)
                throw new System.Exception("Forbidden value on nextVulnerabilityDate = " + nextVulnerabilityDate + ", it doesn't respect the following condition : nextVulnerabilityDate < 0");
            placementDate = reader.ReadInt();
            if (placementDate < 0)
                throw new System.Exception("Forbidden value on placementDate = " + placementDate + ", it doesn't respect the following condition : placementDate < 0");
            rewardTokenCount = reader.ReadVarUhInt();
            if (rewardTokenCount < 0)
                throw new System.Exception("Forbidden value on rewardTokenCount = " + rewardTokenCount + ", it doesn't respect the following condition : rewardTokenCount < 0");
            

}


}


}