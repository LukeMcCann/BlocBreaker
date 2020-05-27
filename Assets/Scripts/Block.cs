using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    [SerializeField] AudioClip destructionSound;
    [SerializeField] GameObject blockSparkleVFX;
    [SerializeField] float particleLifeSpan = 2.0f;
    [SerializeField] int maxHits = 3;
    [SerializeField] private int timesHit; // only serialized for debug
    
    private Camera camera;

    // Cached References
    private Level level;

    GameStatus playStatus;

    int i = 0;

    // Start is called before the first frame update
    void Start()
    {       
        Init();
        CountBreakableBlocks();
    }

    void Update() 
    {
    }

    private void Init() 
    {
        camera = Camera.main;
        playStatus = FindObjectOfType<GameStatus>();
    }

    private void CountBreakableBlocks() 
    {
        level = FindObjectOfType<Level>();
        if(tag == "Breakable") 
        {
            level.CountBlocks();
        }
    }

    private void OnCollisionEnter2D(Collision2D collisionInfo)
    {
        if(tag == "Breakable") 
        {
            timesHit++;
            if(timesHit >= maxHits)
            {
                DestroyBlock();
            }
        }
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
        TriggerSparkleVFX();
        playStatus.incrementScore();
    }

    private void TriggerSparkleVFX() 
    {
        GameObject sparkleVFX = Instantiate(blockSparkleVFX, transform.position, transform.rotation);
        Destroy(sparkleVFX, particleLifeSpan);
    }
}
