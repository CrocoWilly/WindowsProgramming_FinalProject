using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachine : MonoBehaviour
{

    public GameObject WashingMachineCanvas;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            WashingMachineCanvas.SetActive(false);
        }

    }

    public void WashClothes()
    {
        if ((MyBag.useCoin1 == true) && (MyBag.useCoin2 == true) && (MyBag.useCoin3 == true) && (MyBag.useClothes == true) && (MyBag.useClothesWasher == true))
        {
            MyBag.iHaveCleanClothes = true;
            MyBag.iHaveCoin1FromPlant = false;
            MyBag.iHaveCoin2FromTrashCan = false;
            MyBag.iHaveCoin3FromBathTub = false;
            MyBag.iHaveClothes = false;
            MyBag.iHaveClothesWasher = false;
        }
    }

}
