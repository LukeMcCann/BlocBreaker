using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destructionSound;
    private Camera camera;

    // Cached References
    private Level level;

    // Start is called before the first frame update
    void Start()
    {
        Init();
        level.CountBreakableBlock();
    }

    private void Init() 
    {
        camera = Camera.main;
        level = FindObjectOfType<Level>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        PlayDestructionSound();
        Destroy(this.gameObject);   
    }

    private void PlayDestructionSound() 
    {
        AudioSource.PlayClipAtPoint(destructionSound, 
        new Vector2(camera.transform.position.x, camera.transform.position.y));
    }
}
