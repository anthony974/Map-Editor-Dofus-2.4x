

















// Generated on 07/24/2016 18:36:12
using System;
using System.Collections.Generic;
using ShadowEmu.Common.GameData.D2O;

namespace ShadowEmu.Common.Protocol.Data
{

[D2oClass("Achievements")]
    
public class Achievement : IDataObject
{

public const String MODULE = "Achievements";
        public uint id;
        public uint nameId;
        public uint categoryId;
        public uint descriptionId;
        public int iconId;
        public uint points;
        public uint level;
        public uint order;
        public float kamasRatio;
        public float experienceRatio;
        public Boolean kamasScaleWithPlayerLevel;
        public List<int> objectiveIds;
        public List<int> rewardIds;
        

}

}