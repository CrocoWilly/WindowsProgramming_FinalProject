using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video : MonoBehaviour
{
    private VideoPlayer video;
    public GameObject SkipButton;
    // Start is called before the first frame update
    void Start()
    {
        video = GetComponent<VideoPlayer>();

        //the video playing finished
        video.loopPointReached += EndReached;
    }
    void EndReached(VideoPlayer vp)
    {
        SkipButton.SetActive(true);
    }
}
