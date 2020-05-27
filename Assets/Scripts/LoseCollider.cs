using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// LoseCollider
/// 
/// Class for handling actions of the LoseCollider.
/// </summary>
public class LoseCollider : MonoBehaviour
{
    [SerializeField] int gameOverSceneBuildNumber = 10;
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(gameOverSceneBuildNumber);
    }
}
