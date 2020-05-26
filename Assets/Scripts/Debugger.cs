using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
public class Debugger : MonoBehaviour
{
    [SerializeField] int blocksToDestroy;
    // Start is called before the first frame update
    Level level;
    void Start()
    {
        level = FindObjectOfType<Level>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftAlt)) {
            // DestroyBlocks(blocksToDestroy);
            DestroyBlocks(level.GetBlockCount());

        }
    }

    public void DestroyBlocks(int numToDestroy) 
    {
        for(int i = 0; i <= numToDestroy; i++) 
        {
            try {
                FindObjectOfType<Block>().DestroyBlock();
            } catch(System.IndexOutOfRangeException ex) {
                Debug.Log(ex.Message);
            }
        }
    }
}
