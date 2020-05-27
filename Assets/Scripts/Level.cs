using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] AudioClip levelCompleteSound;
    [SerializeField] private int breakableBlocksCount;
    [SerializeField] int sceneLoadTime = 3;

    // Cached References
    SceneLoader sceneLoader;

    void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks() 
    {
        breakableBlocksCount++;
    }

    public void BlockDestroyed() 
    {
        breakableBlocksCount--;
        if(breakableBlocksCount <= 0) 
        {
            sceneLoader.LoadNextScene();
        }
    }

     private IEnumerator WaitForSceneLoad(int seconds) 
     {
        yield return new WaitForSeconds(seconds);
        sceneLoader.LoadNextScene();
     }

    public int GetBlockCount() 
    {
        return this.breakableBlocksCount;
    }
    
}
