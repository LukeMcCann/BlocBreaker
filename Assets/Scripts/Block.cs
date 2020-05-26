using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destructionSound;
    [SerializeField] int DebugToolBlocksToDestroy;
    private Camera camera;

    // Cached References
    private Level level;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {       
        level = FindObjectOfType<Level>();
        level.CountBreakableBlock();
        Init();
    }

    void Update() 
    {
    }

    private void Init() 
    {
        camera = Camera.main;

    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        DestroyBlock();
    }

    private void PlayDestructionSound() 
    {
        AudioSource.PlayClipAtPoint(destructionSound, 
        new Vector2(camera.transform.position.x, camera.transform.position.y));
    }

    private void DestroyBlock() 
    {
        PlayDestructionSound(); 
        level.BlockDestroyed();
        Destroy(this.gameObject);  
    }
}
