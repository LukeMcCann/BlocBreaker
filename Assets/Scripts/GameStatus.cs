using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] float playSpeed = 1f;
    [SerializeField] int score = 0;
    [Range(0, 100)] [SerializeField] int pointsPerBlock = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = playSpeed;
    }

    public void incrementScore() 
    {
        score += pointsPerBlock;
    }
}
