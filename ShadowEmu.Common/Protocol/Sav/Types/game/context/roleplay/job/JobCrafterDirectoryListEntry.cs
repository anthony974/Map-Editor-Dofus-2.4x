


















// Generated on 07/24/2016 18:36:07
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class JobCrafterDirectoryListEntry : NetworkType
{

public const short Id = 196;
public virtual short TypeId
{
    get { return Id; }
}

public Types.JobCrafterDirectoryEntryPlayerInfo playerInfo;
        public Types.JobCrafterDirectoryEntryJobInfo jobInfo;
        

public JobCrafterDirectoryListEntry()
{
}

public JobCrafterDirectoryListEntry(Types.JobCrafterDirectoryEntryPlayerInfo playerInfo, Types.JobCrafterDirectoryEntryJobInfo jobInfo)
        {
            this.playerInfo = playerInfo;
            this.jobInfo = jobInfo;
        }
        

public virtual void Serialize(IDataWriter writer)
{

playerInfo.Serialize(writer);
            jobInfo.Serialize(writer);
            

}

public virtual void Deserialize(IDataReader reader)
{

playerInfo = new Types.JobCrafterDirectoryEntryPlayerInfo();
            playerInfo.Deserialize(reader);
            jobInfo = new Types.JobCrafterDirectoryEntryJobInfo();
            jobInfo.Deserialize(reader);
            

}


}


}