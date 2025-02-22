


















// Generated on 01/12/2017 03:53:06
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class CharacterRemodelingInformation : AbstractCharacterInformation
{

public const short Id = 479;
public override short TypeId
{
    get { return Id; }
}

public string name;
        public sbyte breed;
        public bool sex;
        public uint cosmeticId;
        public int[] colors;
        

public CharacterRemodelingInformation()
{
}

public CharacterRemodelingInformation(double id, string name, sbyte breed, bool sex, uint cosmeticId, int[] colors)
         : base(id)
        {
            this.name = name;
            this.breed = breed;
            this.sex = sex;
            this.cosmeticId = cosmeticId;
            this.colors = colors;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(name);
            writer.WriteSByte(breed);
            writer.WriteBoolean(sex);
            writer.WriteVarShort((int)cosmeticId);
            writer.WriteUShort((ushort)colors.Length);
            foreach (var entry in colors)
            {
                 writer.WriteInt(entry);
            }
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            name = reader.ReadUTF();
            breed = reader.ReadSByte();
            sex = reader.ReadBoolean();
            cosmeticId = reader.ReadVarUhShort();
            if (cosmeticId < 0)
                throw new System.Exception("Forbidden value on cosmeticId = " + cosmeticId + ", it doesn't respect the following condition : cosmeticId < 0");
            var limit = reader.ReadUShort();
            colors = new int[limit];
            for (int i = 0; i < limit; i++)
            {
                 colors[i] = reader.ReadInt();
            }
            

}


}


}