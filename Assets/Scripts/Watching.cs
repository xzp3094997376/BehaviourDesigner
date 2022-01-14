using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using BehaviorDesigner.Runtime.Tasks;
//using UnityEngine;

[HelpURL("www.baidu.com")]
public class Watching : Action
{
    public SharedString watchTv;
    public override TaskStatus OnUpdate()
    {
        UnityEngine.Debug.Log("正在看电视: "+watchTv.GetValue().ToString());
        return TaskStatus.Running;
    }
}
