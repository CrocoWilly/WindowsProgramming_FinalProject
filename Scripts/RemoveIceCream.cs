using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoveIceCream : MonoBehaviour
{
    void Update()
    {
        if(MyBag.iHaveIcedCoin == true)
        {
            Destroy(this.gameObject);
        }
    }
}
