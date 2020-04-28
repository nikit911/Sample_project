using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColorBehavior : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            UtilityColorChanger.ChangeColors(this.gameObject);
        }
    }
}
