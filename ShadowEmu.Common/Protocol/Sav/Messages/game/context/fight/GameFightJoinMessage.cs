


















// Generated on 07/24/2016 18:35:49
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class GameFightJoinMessage : NetworkMessage
{

public const uint Id = 702;
public uint MessageId
{
    get { return Id; }
}

public bool isTeamPhase;
        public bool canBeCancelled;
        public bool canSayReady;
        public bool isFightStarted;
        public short timeMaxBeforeFightStart;
        public sbyte fightType;
        

public GameFightJoinMessage()
{
}

public GameFightJoinMessage(bool isTeamPhase, bool canBeCancelled, bool canSayReady, bool isFightStarted, short timeMaxBeforeFightStart, sbyte fightType)
        {
            this.isTeamPhase = isTeamPhase;
            this.canBeCancelled = canBeCancelled;
            this.canSayReady = canSayReady;
            this.isFightStarted = isFightStarted;
            this.timeMaxBeforeFightStart = timeMaxBeforeFightStart;
            this.fightType = fightType;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, isTeamPhase);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, canBeCancelled);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 2, canSayReady);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 3, isFightStarted);
            writer.WriteByte(flag1);
            writer.WriteShort(timeMaxBeforeFightStart);
            writer.WriteSByte(fightType);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            isTeamPhase = BooleanByteWrapper.GetFlag(flag1, 0);
            canBeCancelled = BooleanByteWrapper.GetFlag(flag1, 1);
            canSayReady = BooleanByteWrapper.GetFlag(flag1, 2);
            isFightStarted = BooleanByteWrapper.GetFlag(flag1, 3);
            timeMaxBeforeFightStart = reader.ReadShort();
            if (timeMaxBeforeFightStart < 0)
                throw new System.Exception("Forbidden value on timeMaxBeforeFightStart = " + timeMaxBeforeFightStart + ", it doesn't respect the following condition : timeMaxBeforeFightStart < 0");
            fightType = reader.ReadSByte();
            if (fightType < 0)
                throw new System.Exception("Forbidden value on fightType = " + fightType + ", it doesn't respect the following condition : fightType < 0");
            

}


}


}