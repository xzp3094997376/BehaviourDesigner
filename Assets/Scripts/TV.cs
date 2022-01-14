using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine;

public class TV : Conditional
{
    public SharedGameObject go;
    public override TaskStatus OnUpdate()
    {
        //Debug.Log(go ==null);
        //Debug.Log(go.Name);
        return go.Value== null?TaskStatus.Failure:TaskStatus.Success;//对Value 值判读
    }
}
