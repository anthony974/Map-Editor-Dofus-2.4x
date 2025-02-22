


















// Generated on 01/12/2017 03:52:59
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class QuestObjectiveValidatedMessage : NetworkMessage
{

public const uint Id = 6098;
public uint MessageId
{
    get { return Id; }
}

public uint questId;
        public uint objectiveId;
        

public QuestObjectiveValidatedMessage()
{
}

public QuestObjectiveValidatedMessage(uint questId, uint objectiveId)
        {
            this.questId = questId;
            this.objectiveId = objectiveId;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteVarShort((int)questId);
            writer.WriteVarShort((int)objectiveId);
            

}

public void Deserialize(IDataReader reader)
{

questId = reader.ReadVarUhShort();
            if (questId < 0)
                throw new System.Exception("Forbidden value on questId = " + questId + ", it doesn't respect the following condition : questId < 0");
            objectiveId = reader.ReadVarUhShort();
            if (objectiveId < 0)
                throw new System.Exception("Forbidden value on objectiveId = " + objectiveId + ", it doesn't respect the following condition : objectiveId < 0");
            

}


}


}