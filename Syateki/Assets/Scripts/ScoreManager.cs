using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    private int score = 0; // ���݂̃X�R�A

    public void AddScore(int amount)
    {
        score += amount; // �X�R�A�����Z
        Debug.Log("Current Score: " + score); // ���݂̃X�R�A�����O�ɏo��
    }
}