using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destructionSound;
    private Camera camera;

    // Cached References
    private Level level;

    GameStatus playStatus;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {       
        Init();
    }

    void Update() 
    {
    }

    private void Init() 
    {
        level = FindObjectOfType<Level>();
        level.CountBreakableBlock();
        playStatus = FindObjectOfType<GameStatus>();
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

    public void DestroyBlock() 
    {
        PlayDestructionSound(); 
        level.BlockDestroyed();
        Destroy(this.gameObject);
        playStatus.incrementScore();
    }
}
