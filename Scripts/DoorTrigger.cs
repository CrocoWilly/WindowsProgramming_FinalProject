using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTrigger : MonoBehaviour
{
    public string DoorName;
    Animator animator;
    public Dialogue dialogueObject;
    private bool theFirstTime = false;

    private void OnTriggerEnter(Collider other)
    {
        animator.SetBool(DoorName, true);

        if(DoorName == "OpeningMainDoor")
        {
            if (theFirstTime == false)
            {
                Dialogue.textIndex = 2;
                dialogueObject.DisplayDialogue();
                theFirstTime = true;
            }
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (DoorName != "OpeningBalconyDoor")
        {
            animator.Play("Open");

        }
    }

    private void OnTriggerExit(Collider other)
    {
        animator.SetBool(DoorName, false);
    }
    // Start is called before the first frame update
    void Start()
    {
        animator = this.transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
