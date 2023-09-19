using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    Animator animator;
    public Character1Controller c;
    bool wake;

    // Start is called before the first frame update
    void Start()
    {
        //wake = false;
        animator = this.transform.parent.GetComponent<Animator>();
        animator.Play("StandUp");
        wake = false;
        //animator.SetBool("wakeUp", true);
        StartCoroutine(Wakeup());
        
    }

    // Update is called once per frame
    void Update()
    {
        wake = true;
        if (wake == true)
            animator.SetBool("wakeUp", wake);

    }

    IEnumerator Wakeup()
    {
        yield return new WaitForSeconds(5f);
        animator.SetBool("wakeUp", false);

    }
}
