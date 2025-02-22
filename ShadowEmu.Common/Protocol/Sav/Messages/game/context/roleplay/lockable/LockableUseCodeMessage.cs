


















// Generated on 07/24/2016 18:35:52
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Protocol.Types;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Messages
{

public class LockableUseCodeMessage : NetworkMessage
{

public const uint Id = 5667;
public uint MessageId
{
    get { return Id; }
}

public string code;
        

public LockableUseCodeMessage()
{
}

public LockableUseCodeMessage(string code)
        {
            this.code = code;
        }
        

public void Serialize(IDataWriter writer)
{

writer.WriteUTF(code);
            

}

public void Deserialize(IDataReader reader)
{

code = reader.ReadUTF();
            

}


}


}