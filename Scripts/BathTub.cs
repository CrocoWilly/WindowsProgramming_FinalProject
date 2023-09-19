using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BathTub : MonoBehaviour
{
    public Dialogue dialogueObject;

    private bool coin3IsGet = false;
    public GameObject BathTubCanvas;

    private bool coinIsNormal = false;

    // Update is called once per frame
    void Update()
    {
        Dialogue.textIndex = 4;
        dialogueObject.DisplayDialogue();

        if (Input.GetKeyDown(KeyCode.P))
        {
            if (coin3IsGet == false)
            {
                BathTubCanvas.SetActive(false);
            }
        }

        if (MyBag.useIcedCoin == true)
        {
            coinIsNormal = true;   
        }

        if(coinIsNormal == true)
        {
            if (coin3IsGet == false)
            {
                coin3IsGet = true;

                MyBag.iHaveCoin3FromBathTub = true;

                BathTubCanvas.SetActive(false);
            }
        }
        
    }

    public void UnfreezeIcedCoin()
    {
        if (MyBag.iHaveIcedCoin == true)
        {
            MyBag.iHaveCoin3FromBathTub = true;
        }
    }
}
