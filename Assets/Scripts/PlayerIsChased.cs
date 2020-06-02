using UnityEngine;

using Pada1.BBCore;           // Code attributes
using Pada1.BBCore.Framework; // ConditionBase

[Condition("MyConditions/IsChased")]
[Help("Checks whether it is night. It searches for the first light labeled with " +
      "the 'MainLight' tag, and looks for its DayNightCycle script, returning the" +
      "informed state. If no light is found, false is returned.")]
public class PlayerIsChased : ConditionBase
{
    public override bool Check()
    {
        return GlobalBlackboard.playerChased;
    }
}
