


















// Generated on 07/24/2016 18:36:08
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class ObjectItem : Item
{

public const short Id = 37;
public override short TypeId
{
    get { return Id; }
}

public byte position;
        public uint objectGID;
        public Types.ObjectEffect[] effects;
        public uint objectUID;
        public uint quantity;
        

public ObjectItem()
{
}

public ObjectItem(byte position, uint objectGID, Types.ObjectEffect[] effects, uint objectUID, uint quantity)
        {
            this.position = position;
            this.objectGID = objectGID;
            this.effects = effects;
            this.objectUID = objectUID;
            this.quantity = quantity;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteByte(position);
            writer.WriteVarShort((int)objectGID);
            writer.WriteUShort((ushort)effects.Length);
            foreach (var entry in effects)
            {
                 writer.WriteShort(entry.TypeId);
                 entry.Serialize(writer);
            }
            writer.WriteVarInt((int)objectUID);
            writer.WriteVarInt((int)quantity);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            position = reader.ReadByte();
            if (position < 0 || position > 255)
                throw new System.Exception("Forbidden value on position = " + position + ", it doesn't respect the following condition : position < 0 || position > 255");
            objectGID = reader.ReadVarUhShort();
            if (objectGID < 0)
                throw new System.Exception("Forbidden value on objectGID = " + objectGID + ", it doesn't respect the following condition : objectGID < 0");
            var limit = reader.ReadUShort();
            effects = new Types.ObjectEffect[limit];
            for (int i = 0; i < limit; i++)
            {
                 effects[i] = ProtocolTypeManager.GetInstance<Types.ObjectEffect>(reader.ReadShort());
                 effects[i].Deserialize(reader);
            }
            objectUID = reader.ReadVarUhInt();
            if (objectUID < 0)
                throw new System.Exception("Forbidden value on objectUID = " + objectUID + ", it doesn't respect the following condition : objectUID < 0");
            quantity = reader.ReadVarUhInt();
            if (quantity < 0)
                throw new System.Exception("Forbidden value on quantity = " + quantity + ", it doesn't respect the following condition : quantity < 0");
            

}


}


}