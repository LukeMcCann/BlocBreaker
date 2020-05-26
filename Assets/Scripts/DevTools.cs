using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DevTools : MonoBehaviour
{
    [SerializeField] bool active = false;
    SceneLoader sceneLoader;

    

    void Start() 
    {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    // Update is called once per frame
    void Update()
    {
        if(active)
        {
            ListenForInput();
        }
    }


    void ListenForInput() 
    {
        if(Input.GetKeyDown(KeyCode.Alpha1)) 
        {
            sceneLoader.LoadScene(1);
        } else if(Input.GetKeyDown(KeyCode.Alpha2)) {
            sceneLoader.LoadScene(2);
        } else if(Input.GetKeyDown(KeyCode.Alpha3)) {
            sceneLoader.LoadScene(3);
        } else if(Input.GetKeyDown(KeyCode.Alpha4)) {
            sceneLoader.LoadScene(4);
        } else if(Input.GetKeyDown(KeyCode.Alpha5)) {
            sceneLoader.LoadScene(5);
        } else if(Input.GetKeyDown(KeyCode.Alpha6)) {
            sceneLoader.LoadScene(6);
        } else if(Input.GetKeyDown(KeyCode.Alpha7)) {
            sceneLoader.LoadScene(7);
        }
    }
}
