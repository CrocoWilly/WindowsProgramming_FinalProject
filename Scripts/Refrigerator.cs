using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Refrigerator : MonoBehaviour
{
    public GameObject RefrigeratorCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            RefrigeratorCanvas.SetActive(false);
        }
    }
}
