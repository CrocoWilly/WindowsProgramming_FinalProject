using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brain : MonoBehaviour
{
    SceneSwitcher switcher;
    Dialogue dialogueObject;
    void Start()
    {
        switcher = new SceneSwitcher();
        dialogueObject = new Dialogue();
    }

    // Update is called once per frame
    void Update()
    {
        /*
        �����ainput password
        dialogueObject.password = ;
        */

        //if(����input)
        Dialogue.textIndex = 6;
        dialogueObject.DisplayDialogue();
    }
}
