using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destructionSound;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        init();
    }

    private void init() 
    {
        camera = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        playDestructionSound();
        Destroy(this.gameObject);   
    }

    private void playDestructionSound() 
    {
        AudioSource.PlayClipAtPoint(destructionSound, 
        new Vector2(camera.transform.position.x, camera.transform.position.y));
    }
}
