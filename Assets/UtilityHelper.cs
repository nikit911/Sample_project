using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityHelper
{
    public static void CreateObject()
    {
    //create a new primitive cube
    GameObject.CreatePrimitive(PrimitiveType.Cube);
    Debug.Log("object created");
    }
    public static void setPositionToZero(GameObject obj)
    {
        obj.transform.position = Vector3.zero;
    }
}
