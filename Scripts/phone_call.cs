using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class phone_call : MonoBehaviour
{
    private AudioSource tien_yee_ming;
    public AudioSource Joker;

    public int timeleft = 10;
    public bool startRing = false;
    public bool isRinging = false;
    public bool pickUp = false;
    GameObject phone;
    // Start is called before the first frame update
    void Start()
    {
        Joker = GetComponent<AudioSource>();
        StartCoroutine(Countdown());
    }

    void Update()
    {
        
    }


    private IEnumerator Countdown()
    {

        while (timeleft >= 0)
        {
            yield return new WaitForSeconds(1);
            timeleft--;
            if (timeleft <= 0) startRing = true;
        }

        while (pickUp != true)
        {

            if (startRing == true && isRinging == false)
            {
                //Joker = GameObject.FindGameObjectWithTag("clown_music").GetComponent<AudioSource>();
                isRinging = true;
                //Joker.gameObject.SetActive(true);
                Joker.Play();
            }

            if (pickUp == true)
            {
                Joker.Pause();
                startRing = false;
            }
        }
        
    }
}
