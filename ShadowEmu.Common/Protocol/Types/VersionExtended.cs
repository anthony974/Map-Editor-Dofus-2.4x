


















// Generated on 01/12/2017 03:53:10
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class VersionExtended : Version
{

public const short Id = 393;
public override short TypeId
{
    get { return Id; }
}

public sbyte install;
        public sbyte technology;
        

public VersionExtended()
{
}

public VersionExtended(sbyte major, sbyte minor, sbyte release, int revision, sbyte patch, sbyte buildType, sbyte install, sbyte technology)
         : base(major, minor, release, revision, patch, buildType)
        {
            this.install = install;
            this.technology = technology;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteSByte(install);
            writer.WriteSByte(technology);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            install = reader.ReadSByte();
            if (install < 0)
                throw new System.Exception("Forbidden value on install = " + install + ", it doesn't respect the following condition : install < 0");
            technology = reader.ReadSByte();
            if (technology < 0)
                throw new System.Exception("Forbidden value on technology = " + technology + ", it doesn't respect the following condition : technology < 0");
            

}


}


}