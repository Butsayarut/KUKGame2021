using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController : MonoBehaviour
{
    public Light Light1;
    private void OnMouseDown()
    {
        print("Mouse Down");
        if(Light1.enabled == true)
        {
            Light1.enabled = false;

        }
        else
        {
            Light1.enabled = true;
        }
    }

}