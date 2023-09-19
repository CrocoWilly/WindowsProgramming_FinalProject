using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notebook : MonoBehaviour
{
    public GameObject notebookCanvas;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            notebookCanvas.SetActive(false);
        }
    }
}
