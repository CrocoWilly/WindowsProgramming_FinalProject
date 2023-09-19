using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IcedCoin : MonoBehaviour
{
    public Dialogue dialogueObject;

    private bool icedCoinIsGet = false;
    public GameObject IcedCoinCanvas;

    void Update()
    {
        Dialogue.textIndex = 3;
        dialogueObject.DisplayDialogue();
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (icedCoinIsGet == false)
            {
                icedCoinIsGet = true;

                //MyBag.iHaveIcedCoin = true;

                IcedCoinCanvas.SetActive(false);
            }
        }
    }

    
}
