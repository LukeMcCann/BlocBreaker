using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float screenWidthInUnits = 16f;

    private Vector2 paddlePos;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setPaddlePos(getMousePosXInUnits(), transform.position.y);
        transform.position = paddlePos;
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

    // Input
    private float getMousePosXInUnits() {
        return Input.mousePosition.x / Screen.width * screenWidthInUnits;
    }

}
