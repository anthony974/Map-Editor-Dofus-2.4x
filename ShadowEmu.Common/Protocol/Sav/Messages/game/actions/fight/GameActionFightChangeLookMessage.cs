


















// Generated on 07/24/2016 18:35:44
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameActionFightChangeLookMessage : AbstractGameActionMessage
{

public const uint Id = 5532;
public uint MessageId
{
    get { return Id; }
}

public double targetId;
        public Types.EntityLook entityLook;
        

public GameActionFightChangeLookMessage()
{
}

public GameActionFightChangeLookMessage(uint actionId, double sourceId, double targetId, Types.EntityLook entityLook)
         : base(actionId, sourceId)
        {
            this.targetId = targetId;
            this.entityLook = entityLook;
        }
        

public void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteDouble(targetId);
            entityLook.Serialize(writer);
            

}

public void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            targetId = reader.ReadDouble();
            if (targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on targetId = " + targetId + ", it doesn't respect the following condition : targetId < -9.007199254740992E15 || targetId > 9.007199254740992E15");
            entityLook = new Types.EntityLook();
            entityLook.Deserialize(reader);
            

}


}


}