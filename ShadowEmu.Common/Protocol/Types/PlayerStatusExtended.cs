


















// Generated on 01/12/2017 03:53:07
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class PlayerStatusExtended : PlayerStatus
{

public const short Id = 414;
public override short TypeId
{
    get { return Id; }
}

public string message;
        

public PlayerStatusExtended()
{
}

public PlayerStatusExtended(sbyte statusId, string message)
         : base(statusId)
        {
            this.message = message;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteUTF(message);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            message = reader.ReadUTF();
            

}


}


}