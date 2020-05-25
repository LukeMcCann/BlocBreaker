using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] Paddle paddle1;
    Vector2 paddleToBallVector;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        stickToPaddle();
    }

    private void Init() 
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    private void stickToPaddle() 
    {
        Vector2 paddlePos = new Vector2(paddle1.GetPosX(), paddle1.GetPosY());
        transform.position = paddlePos + paddleToBallVector;
    }
}
