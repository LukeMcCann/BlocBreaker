using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameStatus : MonoBehaviour
{
    [Range(0.1f, 10f)] [SerializeField] float playSpeed = 1f;
    [SerializeField] int score = 0;
    [SerializeField] TextMeshProUGUI scoreText;
    [Range(0, 100)] [SerializeField] int pointsPerBlock = 10;

    void Awake() 
    {
        int gameStatusCount = FindObjectsOfType<GameStatus>().Length;
        if(gameStatusCount > 1)
        {
            this.gameObject.SetActive(false);
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

    // Start is called before the first frame update
    void Start()
    {
        SetScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        Time.timeScale = playSpeed;
    }

    public void incrementScore() 
    {
        score += pointsPerBlock;
        SetScoreText();
    }

    public void Reset() 
    {
        Destroy(this.gameObject);
    }

    private void SetScoreText() {
        if(score < 10) {
            scoreText.text = "Score:\n0000" + score;
        } else if(score >= 10 && score < 100) {
            scoreText.text = "Score:\n000" + score;
        } else if(score >= 100 && score < 1000) {
            scoreText.text = "Score:\n00"+score;
        } else if(score >= 1000 && score < 10000) {
            scoreText.text = "Score:\n0"+score;
        } else if(score >= 10000) {
            scoreText.text = "Score:\n"+score;
        }

    }
}
