

















// Generated on 07/24/2016 18:36:12
using System;
using System.Collections.Generic;
using ShadowEmu.Common.GameData.D2O;

namespace ShadowEmu.Common.Protocol.Data
{

[D2oClass("Monsters")]
    
public class Monster : IDataObject
{

public const String MODULE = "Monsters";
        public int id;
        public uint nameId;
        public uint gfxId;
        public int race;
        public List<MonsterGrade> grades;
        public String look;
        public Boolean useSummonSlot;
        public Boolean useBombSlot;
        public Boolean canPlay;
        public Boolean canTackle;
        public List<AnimFunMonsterData> animFunList;
        public Boolean isBoss;
        public List<MonsterDrop> drops;
        public List<uint> subareas;
        public List<uint> spells;
        public int favoriteSubareaId;
        public Boolean isMiniBoss;
        public Boolean isQuestMonster;
        public uint correspondingMiniBossId;
        public double speedAdjust = 0.0;
        public int creatureBoneId;
        public Boolean canBePushed;
        public Boolean fastAnimsFun;
        public Boolean canSwitchPos;
        public List<uint> incompatibleIdols;
        public Boolean allIdolsDisabled;
        public Boolean dareAvailable;
        public List<uint> incompatibleChallenges;
        

}

}