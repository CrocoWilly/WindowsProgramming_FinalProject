using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBathroomDoor : MonoBehaviour
{
    private Animator animator;
    private bool opening = false;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            opening = true;
        }
        if (Input.GetKey(KeyCode.X))
        {
            opening = false;
        }
        animator.SetBool("OpeningBathroomDoor", opening);
    }
}
