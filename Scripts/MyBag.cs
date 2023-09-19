using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBag : MonoBehaviour
{
    private SceneSwitcher switcher;

    public GameObject BagCanvas;

    /*************** stuff in my bag **************/
    public static bool iHaveCoin1FromPlant = false;
    public static bool iHaveCoin2FromTrashCan = false;
    public static bool iHaveIcedCoin = false;
    public static bool iHaveCoin3FromBathTub = false;
    public static bool iHaveClothes = false;
    public static bool iHaveClothesWasher = false;
    public static bool iHaveCleanClothes = false;
    //public static bool iHaveBrick = false;


    /************** use stuff in my bag ************/
    public static bool useCoin1 = false;
    public static bool useCoin2 = false;
    public static bool useIcedCoin = false;
    public static bool useCoin3 = false;
    public static bool useClothes = false;
    public static bool useClothesWasher = false;
    private bool useCleanClothes = false;
    //private bool useBrick = false;

    private GameObject Coin1FromPlant;
    private GameObject Coin2FromTrashCan;
    private GameObject IcedCoin;
    private GameObject Coin3FromBathTub;
    private GameObject Clothes;
    private GameObject ClothesWasher;
    private GameObject CleanClothes;
    //private GameObject Brick;

    private void Start()
    {
        switcher = new SceneSwitcher();

        Coin1FromPlant = BagCanvas.transform.GetChild(2).gameObject;
        Coin2FromTrashCan = BagCanvas.transform.GetChild(3).gameObject;
        IcedCoin = BagCanvas.transform.GetChild(4).gameObject;
        Coin3FromBathTub = BagCanvas.transform.GetChild(5).gameObject;
        Clothes = BagCanvas.transform.GetChild(6).gameObject;
        ClothesWasher = BagCanvas.transform.GetChild(7).gameObject;
        CleanClothes = BagCanvas.transform.GetChild(9).gameObject;
        //Brick = BagCanvas.transform.GetChild(8).gameObject;
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            GoBackToMainGame();
        }

        /********** while I have the stuff, my bag set the stuff*********/ 
        if (iHaveCoin1FromPlant == true)
        {
            Coin1FromPlant.SetActive(true);
        }
        else
        {
            Coin1FromPlant.SetActive(false);
        }

        if (iHaveCoin2FromTrashCan == true)
        {
            Coin2FromTrashCan.SetActive(true);
        }
        else
        {
            Coin2FromTrashCan.SetActive(false);
        }

        if (iHaveIcedCoin == true)
        {
            IcedCoin.SetActive(true);
        }
        else
        {
            IcedCoin.SetActive(false);
        }

        if (iHaveCoin3FromBathTub == true)
        {
            iHaveIcedCoin = false;
            Coin3FromBathTub.SetActive(true);
        }
        else
        {
            Coin3FromBathTub.SetActive(false);
        }

        if (iHaveClothes == true)
        {
            Clothes.SetActive(true);
        }
        else
        {
            Clothes.SetActive(false);
        }

        if (iHaveClothesWasher == true)
        {
            ClothesWasher.SetActive(true);
        }
        else
        {
            ClothesWasher.SetActive(false);
        }

        if (iHaveCleanClothes == true)
        {
            CleanClothes.SetActive(true);
        }
        else
        {
            CleanClothes.SetActive(false);
        }

        /*
        if (iHaveBrick == true)
        {
            Brick.SetActive(true);
            //if button clicked
                useBrick = true;
        }
        else
        {
            Brick.SetActive(false);
        }
        */
    }

    
    private void GoBackToMainGame()
    {
        BagCanvas.SetActive(false);
    }


    /********************* use the stuff function *******************/
    public void UseCoin1()
    {
        useCoin1 = true;
    }

    public void UseCoin2()
    {
        useCoin2 = true;
    }

    public void UseCoin3()
    {
        useCoin3 = true;
    }

    public void UseClothes()
    {
        useClothes = true;
    }

    public void UseClothesWasher()
    {
        useClothesWasher = true;
    }

    public void WinTheGame()
    {
        switcher.sceneIndexDestination = 3;
        switcher.ChangeScene();
    }

}
