


















// Generated on 01/12/2017 03:52:52
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class IdentificationSuccessMessage : NetworkMessage
{

public const uint Id = 22;
public uint MessageId
{
    get { return Id; }
}

public bool hasRights;
        public bool wasAlreadyConnected;
        public string login;
        public string nickname;
        public int accountId;
        public sbyte communityId;
        public string secretQuestion;
        public double accountCreation;
        public double subscriptionElapsedDuration;
        public double subscriptionEndDate;
        public byte havenbagAvailableRoom;
        

public IdentificationSuccessMessage()
{
}

public IdentificationSuccessMessage(bool hasRights, bool wasAlreadyConnected, string login, string nickname, int accountId, sbyte communityId, string secretQuestion, double accountCreation, double subscriptionElapsedDuration, double subscriptionEndDate, byte havenbagAvailableRoom)
        {
            this.hasRights = hasRights;
            this.wasAlreadyConnected = wasAlreadyConnected;
            this.login = login;
            this.nickname = nickname;
            this.accountId = accountId;
            this.communityId = communityId;
            this.secretQuestion = secretQuestion;
            this.accountCreation = accountCreation;
            this.subscriptionElapsedDuration = subscriptionElapsedDuration;
            this.subscriptionEndDate = subscriptionEndDate;
            this.havenbagAvailableRoom = havenbagAvailableRoom;
        }
        

public void Serialize(IDataWriter writer)
{

byte flag1 = 0;
            flag1 = BooleanByteWrapper.SetFlag(flag1, 0, hasRights);
            flag1 = BooleanByteWrapper.SetFlag(flag1, 1, wasAlreadyConnected);
            writer.WriteByte(flag1);
            writer.WriteUTF(login);
            writer.WriteUTF(nickname);
            writer.WriteInt(accountId);
            writer.WriteSByte(communityId);
            writer.WriteUTF(secretQuestion);
            writer.WriteDouble(accountCreation);
            writer.WriteDouble(subscriptionElapsedDuration);
            writer.WriteDouble(subscriptionEndDate);
            writer.WriteByte(havenbagAvailableRoom);
            

}

public void Deserialize(IDataReader reader)
{

byte flag1 = reader.ReadByte();
            hasRights = BooleanByteWrapper.GetFlag(flag1, 0);
            wasAlreadyConnected = BooleanByteWrapper.GetFlag(flag1, 1);
            login = reader.ReadUTF();
            nickname = reader.ReadUTF();
            accountId = reader.ReadInt();
            if (accountId < 0)
                throw new System.Exception("Forbidden value on accountId = " + accountId + ", it doesn't respect the following condition : accountId < 0");
            communityId = reader.ReadSByte();
            if (communityId < 0)
                throw new System.Exception("Forbidden value on communityId = " + communityId + ", it doesn't respect the following condition : communityId < 0");
            secretQuestion = reader.ReadUTF();
            accountCreation = reader.ReadDouble();
            if (accountCreation < 0 || accountCreation > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on accountCreation = " + accountCreation + ", it doesn't respect the following condition : accountCreation < 0 || accountCreation > 9.007199254740992E15");
            subscriptionElapsedDuration = reader.ReadDouble();
            if (subscriptionElapsedDuration < 0 || subscriptionElapsedDuration > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on subscriptionElapsedDuration = " + subscriptionElapsedDuration + ", it doesn't respect the following condition : subscriptionElapsedDuration < 0 || subscriptionElapsedDuration > 9.007199254740992E15");
            subscriptionEndDate = reader.ReadDouble();
            if (subscriptionEndDate < 0 || subscriptionEndDate > 9.007199254740992E15)
                throw new System.Exception("Forbidden value on subscriptionEndDate = " + subscriptionEndDate + ", it doesn't respect the following condition : subscriptionEndDate < 0 || subscriptionEndDate > 9.007199254740992E15");
            havenbagAvailableRoom = reader.ReadByte();
            if (havenbagAvailableRoom < 0 || havenbagAvailableRoom > 255)
                throw new System.Exception("Forbidden value on havenbagAvailableRoom = " + havenbagAvailableRoom + ", it doesn't respect the following condition : havenbagAvailableRoom < 0 || havenbagAvailableRoom > 255");
            

}


}


}