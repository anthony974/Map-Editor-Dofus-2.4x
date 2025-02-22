


















// Generated on 07/24/2016 18:36:02
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class IdolsPresetSaveResultMessage : NetworkMessage
{

public const uint Id = 6604;
public uint MessageId
{
    get { return Id; }
}

public sbyte presetId;
        public sbyte code;
        

public IdolsPresetSaveResultMessage()
{
}

public IdolsPresetSaveResultMessage(sbyte presetId, sbyte code)
        {
            this.presetId = presetId;
            this.code = code;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteSByte(presetId);
            writer.WriteSByte(code);
            

}

public void Deserialize(IDataReader reader)
{

presetId = reader.ReadSByte();
            if (presetId < 0)
                throw new System.Exception("Forbidden value on presetId = " + presetId + ", it doesn't respect the following condition : presetId < 0");
            code = reader.ReadSByte();
            if (code < 0)
                throw new System.Exception("Forbidden value on code = " + code + ", it doesn't respect the following condition : code < 0");
            

}


}


}