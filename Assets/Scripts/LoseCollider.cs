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
    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(GetGameOverSceneIndex());
        // SceneManager.LoadScene("Game Over");
    }

    /// <summary>
    /// Gets the scene index for GameOver scene
    /// </summary>
    /// <returns>int index - the index of the GameOver scene</returns>
    private int GetGameOverSceneIndex() 
    {
        return SceneManager.sceneCountInBuildSettings-1;
    }
}
