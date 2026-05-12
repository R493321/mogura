using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    private int score = 0;

    void Awake()
    {
        Instance = this;
    }
    public float gameTime = 10f;

    void Start()
    {
        Invoke("EndGame", gameTime);
    }

    void EndGame()
    {
        Debug.Log("Game Over");

    }
    public void AddScore(int value)
    {
        score += value;
        Debug.Log("Score: " + score);
    }
}
