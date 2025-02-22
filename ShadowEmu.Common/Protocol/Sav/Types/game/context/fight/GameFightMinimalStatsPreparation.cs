


















// Generated on 07/24/2016 18:36:06
using System;
using System.Collections.Generic;
using System.Linq;
using ShadowEmu.Common.Network;
using ShadowEmu.Common.IO;

namespace ShadowEmu.Common.Protocol.Types
{

public class GameFightMinimalStatsPreparation : GameFightMinimalStats
{

public const short Id = 360;
public override short TypeId
{
    get { return Id; }
}

public uint initiative;
        

public GameFightMinimalStatsPreparation()
{
}

public GameFightMinimalStatsPreparation(uint lifePoints, uint maxLifePoints, uint baseMaxLifePoints, uint permanentDamagePercent, uint shieldPoints, int actionPoints, int maxActionPoints, int movementPoints, int maxMovementPoints, double summoner, bool summoned, int neutralElementResistPercent, int earthElementResistPercent, int waterElementResistPercent, int airElementResistPercent, int fireElementResistPercent, int neutralElementReduction, int earthElementReduction, int waterElementReduction, int airElementReduction, int fireElementReduction, int criticalDamageFixedResist, int pushDamageFixedResist, int pvpNeutralElementResistPercent, int pvpEarthElementResistPercent, int pvpWaterElementResistPercent, int pvpAirElementResistPercent, int pvpFireElementResistPercent, int pvpNeutralElementReduction, int pvpEarthElementReduction, int pvpWaterElementReduction, int pvpAirElementReduction, int pvpFireElementReduction, uint dodgePALostProbability, uint dodgePMLostProbability, int tackleBlock, int tackleEvade, int fixedDamageReflection, sbyte invisibilityState, uint initiative)
         : base(lifePoints, maxLifePoints, baseMaxLifePoints, permanentDamagePercent, shieldPoints, actionPoints, maxActionPoints, movementPoints, maxMovementPoints, summoner, summoned, neutralElementResistPercent, earthElementResistPercent, waterElementResistPercent, airElementResistPercent, fireElementResistPercent, neutralElementReduction, earthElementReduction, waterElementReduction, airElementReduction, fireElementReduction, criticalDamageFixedResist, pushDamageFixedResist, pvpNeutralElementResistPercent, pvpEarthElementResistPercent, pvpWaterElementResistPercent, pvpAirElementResistPercent, pvpFireElementResistPercent, pvpNeutralElementReduction, pvpEarthElementReduction, pvpWaterElementReduction, pvpAirElementReduction, pvpFireElementReduction, dodgePALostProbability, dodgePMLostProbability, tackleBlock, tackleEvade, fixedDamageReflection, invisibilityState)
        {
            this.initiative = initiative;
        }
        

public override void Serialize(IDataWriter writer)
{

base.Serialize(writer);
            writer.WriteVarInt((int)initiative);
            

}

public override void Deserialize(IDataReader reader)
{

base.Deserialize(reader);
            initiative = reader.ReadVarUhInt();
            if (initiative < 0)
                throw new System.Exception("Forbidden value on initiative = " + initiative + ", it doesn't respect the following condition : initiative < 0");
            

}


}


}