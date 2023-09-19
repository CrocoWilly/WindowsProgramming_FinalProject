using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using System;

public class Character1Controller : MonoBehaviour
{
    //switch scene
    SceneSwitcher switcher;


    //about bag
    private bool setBag = false;
    public GameObject Bag;


    //about character
    private bool startGame = true;
    private bool walk = false;
    public float movingSpeed = 2f;
    private Animator animator;


    //about dialogue
    public Dialogue dialogueObject;



    void Start()
    {
        switcher = new SceneSwitcher();

        //animation
        animator = GetComponent<Animator>();

    }

    void Update()
    {
        if (startGame)
        {
            WakeUpDialog();
            animator.Play("StandUp");
            startGame = false;
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Bag.SetActive(true);
        }



        walk = false;

        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("StandUp"))//在做StandUp的時候不能左右動
        {
            if (Input.GetKey(KeyCode.W))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * transform.forward;
                walk = true;
            }
            if (Input.GetKey(KeyCode.S))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * -(transform.forward);
                walk = true;
            }
            if (Input.GetKey(KeyCode.A))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * -(transform.right);
                walk = true;
            }
            if (Input.GetKey(KeyCode.D))
            {
                transform.localPosition += movingSpeed * Time.deltaTime * transform.right;
                walk = true;
            }
            if (Input.GetKeyDown(KeyCode.J))
            {
                transform.Rotate(new Vector3(0, -90f, 0));
            }
            if (Input.GetKeyDown(KeyCode.L))
            {
                transform.Rotate(new Vector3(0, 90f, 0));
            }
        }


        //animation
        animator.SetBool("isWalk", walk);

    }


    private void WakeUpDialog()
    {
        Dialogue.textIndex = 1;
        dialogueObject.DisplayDialogue();
    }
}
