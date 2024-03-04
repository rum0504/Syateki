using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; // 現在のスコア

    public void AddScore(int amount)
    {
        score += amount; // スコアを加算
        Debug.Log("Current Score: " + score); // 現在のスコアをログに出力
    }
}