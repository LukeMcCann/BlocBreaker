using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Config
    [SerializeField] float screenWidthInUnits = 16f;
    [SerializeField] float minXPos = 1f;
    [SerializeField] float maxXPos = 15f;

    private Vector2 paddlePos;
    
    // Start is called before the first frame update
    void Start()
    {
        paddlePos = new Vector2(transform.position.x, transform.position.y);  
    }

    // Update is called once per frame
    void Update()
    {
        paddlePos.x = getMousePosXInUnits(minXPos, maxXPos);
        transform.position = paddlePos;
    }

    // Input
    private float getMousePosXInUnits(float xMin, float xMax) {
        float mousePosX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        return Mathf.Clamp(mousePosX, xMin, xMax);
    }

    // Setters
    public void setPaddlePosX(float posX) {
        paddlePos.x = posX;
    }

    public void setPaddlePosY(float posY) {
        paddlePos.y = posY;
    }

    public void setPaddlePos(float posX, float posY) {
        paddlePos = new Vector2(posX, posY);
    }

    // Getters
    public float getPaddlePosY() {
        return paddlePos.y;
    }

    public float getPaddlePosX() {
        return paddlePos.x;
    }

    public Vector2 getPaddlePos() {
        return paddlePos;
    }
}
