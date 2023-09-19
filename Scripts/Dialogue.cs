using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public static int textIndex = 1;
    public Text text;
    public Text textPress;

    /*
    public int password;
    private int answer = 605;
    */
    private void Start()
    {
        textIndex = 1;
        DisplayDialogue();
        text.text = "";
        textPress.text = "";
    }

    private void Update()
    {
        //Press R can repeat the dialogue
        if (Input.GetKeyDown(KeyCode.R))
        {
            DisplayDialogue();
        }
        

        //close text
        if (Input.GetKeyDown(KeyCode.P))
        {
            text.text = "";
            textPress.text = "";
        }
        
    }

    public void DisplayDialogue()
    {
        textPress.text = "Press P to exit dialogue";

        if (textIndex == 1)
        {
            text.text = "\n \t : Where am I ? Lets take a look outside.";
        }
        else if (textIndex == 2)
        {
            text.text = "\n \t : I am stuck.\n \t   How can I get out of here?";                   
        }
        else if (textIndex == 3)
        {
            text.text = "\n \t : Why is a frozen dollar here ?";
        }
        else if (textIndex == 4)
        {
            text.text = "\n \t : Why can't I see my reflection? \n \t   Am I dreaming? \n \t   It seems that I can't wake up from this dream.";
        }
        else if (textIndex == 5)
        {
            text.text = "\n \t : Such a dirty cloth!";
        }
        
        /*
        else if(textIndex == 6)
        {
            if(password == answer)
            {
                text.text = "\n \t : Ah! ah! ah! ah! Again?";
            }
            else
            {
                text.text = "\n \t : Why is wrong?";
                enterPassword = false;
            }
        }
        */

    }
}
