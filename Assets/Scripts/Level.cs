using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int breakableBlocksCount;

    // Cached References
    SceneLoader sceneLoader;

    void Start() {
        sceneLoader = FindObjectOfType<SceneLoader>();
    }

    public void CountBreakableBlock() 
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

    public int GetBlockCount() 
    {
        return this.breakableBlocksCount;
    }
    
}
