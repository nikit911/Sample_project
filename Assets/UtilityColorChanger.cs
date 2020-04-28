using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class UtilityColorChanger
{
    public static void ChangeColors(GameObject obj){
       /*  int r = Random.Range(0,255);
        int g = Random.Range(0,255);
        int b = Random.Range(0,255); */
        obj.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
        //Debug.Log("the colors are "+ r +& " " + g + " "+b);
    }

}
