using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RayController : MonoBehaviour
{
    //about ray
    NavMeshAgent agent;
    RaycastHit raycastHit;
    Vector3 rayDirection;
    Vector3 rayStartPosition;
    Ray ray;


    //about dialogue
    public Dialogue dialogueObject;


    //plant anamator
    public GameObject HousePlant;
    private Animator plantAnimator;

    /*
    //about shooting object
    public GameObject bigDoor;
    public Animator bigDoorAnimator;

    public GameObject bathroomDoor;
    public Animator bathroomDoorAnimator;
    */

    /********************************  Canvas  ************************************/

    private bool setLight = false;
    private bool setNotebook = false;
    private bool setPlant = false;
    private bool setTrashCan = false;


    public GameObject Light;
    public GameObject Notebook;
    public GameObject Plant;
    public GameObject TrashCan;
    public GameObject Refrigerator;
    public GameObject IcedCoin;
    public GameObject BathTub;
    public GameObject WashingMachine;
    public GameObject Brain;

    /********************************  Canvas  ************************************/

    
    void Start()
    {
        //about ray
        agent = GetComponent<NavMeshAgent>();

        //plant animator
        plantAnimator = HousePlant.GetComponent<Animator>();


        /*
        bigDoorAnimator = bigDoor.GetComponent<Animator>();
        bathroomDoorAnimator = bathroomDoor.GetComponent<Animator>();
        */
    }



    void Update()
    {
        //ray
        if (Input.GetMouseButton(0))        
        {
            rayStartPosition.x = transform.position.x;
            rayStartPosition.y = transform.position.y + 0.4f;
            rayStartPosition.z = transform.position.z;

            rayDirection = transform.forward;
            ray = new Ray(rayStartPosition, rayDirection);

            Debug.DrawRay(rayStartPosition, rayDirection * 1000);



            //about ray 
            if (Physics.Raycast(ray, out raycastHit, 5f))  
            {
                /************************************** canvas.dialogue ***************************************/
                if (raycastHit.collider.name == "LightSwitch")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenLight();
                }
                if (raycastHit.collider.name == "Notebook")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenNotebook();
                }
                if (raycastHit.collider.name == "House_Plant")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    plantAnimator.SetBool("straight", true);
                    StartCoroutine(OpenPlant());
                }
                if (raycastHit.collider.name == "TrashBag")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    StartCoroutine(OpenTrashCan(raycastHit.collider.gameObject));
                }
                if (raycastHit.collider.name == "Refrigerator")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenRefrigerator();
                }
                if (raycastHit.collider.name == "BathTub")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenBathTub();
                }
                if (raycastHit.collider.name == "WashingMachine")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenWashingMachine();
                }
                /*
                if (raycastHit.collider.name == "BigDoor")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenBigDoor();
                }
                */
                /*
                if (raycastHit.collider.name == "BathroomDoor")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenBathroomDoor();
                }
                */
                /*
                if (raycastHit.collider.name == "Brain")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenBrain();
                }
                */

                /****************************************** my bag ******************************************/
                if (raycastHit.collider.name == "Clothes")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    Destroy(raycastHit.collider.gameObject);
                    OpenClothes();
                }

                if (raycastHit.collider.name == "ClothesWasher")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    Destroy(raycastHit.collider.gameObject);
                    OpenClothesWasher();
                }
                if (raycastHit.collider.name == "phone")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    CloseJokerMusic();
                }
                /*
                if (raycastHit.collider.name == "Brick")
                {
                    Debug.DrawRay(rayStartPosition, rayDirection * 1000, Color.red);
                    OpenBrick();
                }
                */
            }

        }
    }

    /********************** canvas.dialogue ***********************/
    private void OpenLight()
    {
        if (setLight == false)
        {
            Light.SetActive(true);
            setLight = true;
        }
        else
        {
            Light.SetActive(false);
            setLight = false;
        }
    }
    private void OpenNotebook()
    {
        Notebook.SetActive(true);
    }
    IEnumerator OpenPlant()
    {
        yield return new WaitForSeconds(2f);//seconds
        if (setPlant == false)
        {
            Plant.SetActive(true);
            setPlant = true;
        }
        /*else if(setPlant == true) {cannot go to Plant canvas again}*/
    }
    IEnumerator OpenTrashCan(GameObject trash)
    {
        yield return new WaitForSeconds(1f);//seconds
        Destroy(trash.gameObject);
        if (setTrashCan == false)
        {
            TrashCan.SetActive(true);
            setTrashCan = true;
        }
        /*else if(setTrashCan == true) {cannot go to TrashCan canvas again}*/
    }
    private void OpenRefrigerator()
    {
        Refrigerator.SetActive(true);
    }
    private void OpenBathTub()
    {
        BathTub.SetActive(true);
    }
    private void OpenWashingMachine()
    {
        WashingMachine.SetActive(true);
    }
    /*
    private void OpenBrain()
    {
        Brain.SetActive(true);
    }
    */

    /****************** my bag *******************/

    private void OpenClothes()
    {
        Dialogue.textIndex = 5;
        dialogueObject.DisplayDialogue();

        MyBag.iHaveClothes = true;
    }
    private void OpenClothesWasher()
    {
        MyBag.iHaveClothesWasher = true;
    }
    private void CloseJokerMusic()
    {
        TimeManager.pickup = true;
    }
    /*
    private void OpenBrick()
    {
        MyBag.iHaveBrick = true;
    }
    */


}
