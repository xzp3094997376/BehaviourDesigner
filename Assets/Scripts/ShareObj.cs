using System.Collections;
using System.Collections.Generic;
using BehaviorDesigner.Runtime;
using UnityEngine;

[System.Serializable]
public class ShareObj : SharedVariable<CustomObj>
{
    public static implicit operator ShareObj(CustomObj value) { return new ShareObj() { Value = value }; }
}

[System.Serializable]
public class CustomObj
{
    public int id;
    public GameObject obj;
}
