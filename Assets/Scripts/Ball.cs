using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Conf
    [SerializeField] Paddle paddle1;
    [SerializeField] Vector2 velocity;

    // State
    private bool hasStarted = false;
    private Vector2 paddleToBallVector;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted) {
            StickToPaddle();
            LaunchOnMouseClick();
        }
    }

    private void Init() 
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    private void StickToPaddle() 
    {
        Vector2 paddlePos = new Vector2(paddle1.GetPosX(), paddle1.GetPosY());
        transform.position = paddlePos + paddleToBallVector;
    }

    private void LaunchOnMouseClick() 
    {
        if(Input.GetMouseButtonDown(0)) 
        {
            hasStarted = true;
            setVelocity(velocity.x, velocity.y);
        }
    }

    private void setVelocity(float x, float y) {
        GetComponent<Rigidbody2D>().velocity = new Vector2(x, y);
    }
}
