


















// Generated on 07/24/2016 18:36:02
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class InventoryPresetUseResultMessage : NetworkMessage
{

public const uint Id = 6163;
public uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        public byte[] unlinkedPosition;
        

public InventoryPresetUseResultMessage()
{
}

public InventoryPresetUseResultMessage(sbyte presetId, sbyte code, byte[] unlinkedPosition)
        {
            this.presetId = presetId;
            this.code = code;
            this.unlinkedPosition = unlinkedPosition;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            writer.WriteUShort((ushort)unlinkedPosition.Length);
            foreach (var entry in unlinkedPosition)
            {
                 writer.WriteByte(entry);
            }
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new System.Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new System.Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            var limit = reader.ReadUShort();
            unlinkedPosition = new byte[limit];
            for (int i = 0; i < limit; i++)
            {
                 unlinkedPosition[i] = reader.ReadByte();
            }
            

}


}


}