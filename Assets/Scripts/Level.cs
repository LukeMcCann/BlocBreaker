using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private int breakableBlocksCount;

    public void CountBreakableBlock() 
    {
        breakableBlocksCount++;
    }
}
