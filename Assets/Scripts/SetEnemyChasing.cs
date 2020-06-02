using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pada1.BBCore;
using Pada1.BBCore.Tasks;
using Pada1.BBCore.Framework;


[Action("MyActions/SetEnemyChasing")]
public class SetEnemyChasing : BasePrimitiveAction
{
    [InParam("value")]
    public bool value;

    public override TaskStatus OnUpdate()
    {
        GlobalBlackboard.playerChased = value;

        return TaskStatus.COMPLETED; 
    }
}
