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
        Init();
    }

    // Update is called once per frame
    void Update()
    {
        paddlePos.x = GetMousePosXInUnits(minXPos, maxXPos);
        transform.position = paddlePos;
    }

    private void Init() {
        paddlePos = new Vector2(transform.position.x, transform.position.y);  
    }

    // Input
    private float GetMousePosXInUnits(float xMin, float xMax) {
        float mousePosX = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        return Mathf.Clamp(mousePosX, xMin, xMax);
    }

    // Getters
    public float GetPosX() {
        return transform.position.x;
    }

    public float GetPosY() {
        return transform.position.y;
    }
}
