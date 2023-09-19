using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    public float survivalTime = 600;//seconds
    public Text timeText;

    public static bool pickup = false;
    public bool startRing = false;
    public bool TYM_Play = true, TYM_ing = false;
    public AudioSource AudioToPlay;

    public AudioSource TYM;

    private void Start()
    {
        //AudioToPlay = GetComponent<AudioSource>();
        //AudioToPlay.Play();

        TYM = GameObject.FindGameObjectWithTag("Music_Tien_Yee_Ming").GetComponent<AudioSource>();

        AudioToPlay = GameObject.FindGameObjectWithTag("Music_clown").GetComponent<AudioSource>();

        

    }

    // Update is called once per frame
    void Update()
    {
        if (TYM_Play == true && TYM_ing == false)
        {
            TYM.Play();
            TYM_ing = true;
        }

        if (survivalTime > 0)
        {
            survivalTime -= Time.deltaTime;
        }
        else
        {
            survivalTime = 0;
            StartCoroutine(Die());

        }
        DisplayTime(survivalTime);

        if(survivalTime >= 420)
        {
            pickup = false;
        }

        if(survivalTime < 420 && pickup==false)
        {
            if (startRing == false)
            {
                startRing = true;
                TYM.Pause();
                AudioToPlay.Play();
            }
        }
        if (pickup == true)
        {
            AudioToPlay.Pause();
            TYM.UnPause();
        }

    }
    void DisplayTime(float time)
    {
        if (time < 0)
        {
            time = 0;
        }
        else if (time > 0)
        {
            time += 1;
        }
        float minutes = Mathf.FloorToInt(time / 60);
        float seconds = Mathf.FloorToInt(time % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
    IEnumerator Die()
    {
        //wait for seconds and then change secene
        yield return new WaitForSeconds(1.5f);//seconds
        SceneManager.LoadScene(2);
    }
}
