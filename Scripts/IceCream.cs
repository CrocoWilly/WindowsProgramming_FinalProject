using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IceCream : MonoBehaviour
{
    private SceneSwitcher switcher;

    private bool iceCreamFinished = false;


    public GameObject thisCanvas;
    public GameObject nextCanvas;

    // Start is called before the first frame update
    void Start()
    {
        iceCreamFinished = false;
    }

    public void IceCreamFinished()
    {
        if (iceCreamFinished == false)
        {
            iceCreamFinished = true;
            MyBag.iHaveIcedCoin = true;
            
            Destroy(this);      //remove ice-cream function
            nextCanvas.SetActive(true);
            thisCanvas.SetActive(false);
        }

    }
}
