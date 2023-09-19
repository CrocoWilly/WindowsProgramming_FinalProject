using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

//����main game��sceneSwitcher
public class SceneSwitcher : MonoBehaviour, IPointerClickHandler
{
    public int sceneIndexDestination;

    public void OnPointerClick(PointerEventData e)
    {
        ChangeScene();
    }


    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneIndexDestination);
    }
    
}
