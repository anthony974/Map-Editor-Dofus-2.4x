


















// Generated on 01/12/2017 03:53:02
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class ExchangeMountFreeFromPaddockMessage : NetworkMessage
{

public const uint Id = 6055;
public uint MessageId
{
    get { return Id; }
}

public string name;
        public short worldX;
        public short worldY;
        public string liberator;
        

public ExchangeMountFreeFromPaddockMessage()
{
}

public ExchangeMountFreeFromPaddockMessage(string name, short worldX, short worldY, string liberator)
        {
            this.name = name;
            this.worldX = worldX;
            this.worldY = worldY;
            this.liberator = liberator;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(name);
            writer.WriteShort(worldX);
            writer.WriteShort(worldY);
            writer.WriteUTF(liberator);
            

}

public void Deserialize(IDataReader reader)
{

name = reader.ReadUTF();
            worldX = reader.ReadShort();
            if (worldX < -255 || worldX > 255)
                throw new System.Exception("Forbidden value on worldX = " + worldX + ", it doesn't respect the following condition : worldX < -255 || worldX > 255");
            worldY = reader.ReadShort();
            if (worldY < -255 || worldY > 255)
                throw new System.Exception("Forbidden value on worldY = " + worldY + ", it doesn't respect the following condition : worldY < -255 || worldY > 255");
            liberator = reader.ReadUTF();
            

}


}


}