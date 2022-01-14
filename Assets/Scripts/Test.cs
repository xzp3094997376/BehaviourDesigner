using BehaviorDesigner.Runtime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    public ExternalBehaviorTree externalBehaviorTree;

    private BehaviorTree behaviourTree;
    // Start is called before the first frame update
    void Start()
    { 
        behaviourTree=this.GetComponent<BehaviorTree>();
        externalBehaviorTree= behaviourTree.ExternalBehavior as ExternalBehaviorTree;
        behaviourTree.StartWhenEnabled = false;
        behaviourTree.RestartWhenComplete = true;
        behaviourTree.EnableBehavior();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            // 吃红烧牛肉面
            behaviourTree.SetVariableValue("food", "红烧牛肉面");
            behaviourTree.SendEvent("Eat");
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            // 睡10000秒
            behaviourTree.SetVariableValue("sleepTime", 10000f);
            behaviourTree.SendEvent("Sleep");
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            // 地震啦
            behaviourTree.SendEvent("EarthQuake");
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            // 地震啦
            behaviourTree.SendEvent("walk");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            // 地震啦//
            behaviourTree.SendEvent("watch");
            Debug.Log("ee");
        }

    }
}
