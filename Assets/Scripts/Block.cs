using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destructionSound;
    // Start is called before the first frame update
    void Start()
    {
        
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

    private void playDestructionSound() {
        AudioSource.PlayClipAtPoint(destructionSound, 
        new Vector2(this.transform.position.x, this.transform.position.y));
    }
}
