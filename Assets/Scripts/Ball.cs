using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Conf
    [SerializeField] Paddle paddle1;
    [SerializeField] Vector2 velocity;
    [SerializeField] AudioClip[] ballCollisionSounds;

    // State
    private bool hasStarted = false;
    private Vector2 paddleToBallVector;
    [SerializeField] float randomFactor = 1f;

    // Cached References
    private AudioSource audioSource;

    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        if(!hasStarted) 
        {
            StickToPaddle();
            LaunchOnMouseClick();
        }

    }

    private void Init() 
    {
        CalculatePaddleBallOffsetVector();
        audioSource = GetComponent<AudioSource>();
        rigidBody2D = GetComponent<Rigidbody2D>();
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
            rigidBody2D.velocity = new Vector2(velocity.x, velocity.y);
        }
    }
    
    private void CalculatePaddleBallOffsetVector() 
    {
        paddleToBallVector = transform.position - paddle1.transform.position;
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        Vector2 velocityTweak = CalculateRandomVelocity();
        if(hasStarted)
        {
            audioSource.PlayOneShot(GetRandomBallCollisionSound());
            rigidBody2D.velocity += velocityTweak;
        }
    }
    

    private Vector2 CalculateRandomVelocity() 
    {
        float x = Random.Range(0,randomFactor);
        float y = Random.Range(0,randomFactor);
        return new Vector2(x, y);
    }

    private AudioClip GetRandomBallCollisionSound() {
        return ballCollisionSounds[UnityEngine.Random.Range(0, ballCollisionSounds.Length)];
    }
}
