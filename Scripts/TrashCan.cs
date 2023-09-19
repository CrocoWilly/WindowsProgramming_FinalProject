using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCan : MonoBehaviour
{
    private bool trashCanIsBroken = false;
    public GameObject TrashCanCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (trashCanIsBroken == false)
            {
                trashCanIsBroken = true;

                MyBag.iHaveCoin2FromTrashCan = true;

                TrashCanCanvas.SetActive(false);

            }
        }

    }
}
