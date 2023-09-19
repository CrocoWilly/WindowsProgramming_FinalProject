using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plant : MonoBehaviour
{
    private bool plantIsBroken = false;
    public GameObject PlantCanvas;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            if (plantIsBroken == false)
            {
                plantIsBroken = true;

                MyBag.iHaveCoin1FromPlant = true;

                PlantCanvas.SetActive(false);

            }
        }
        
    }
}
