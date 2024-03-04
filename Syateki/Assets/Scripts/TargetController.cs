using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    public ScoreManager scoreManager; // InspectorからScoreManagerを割り当てる
    private bool hasFallen = false; // 的が倒れたかを示すフラグ

    void Update()
    {
        if (!hasFallen)
        {
            float tiltAngle = Vector3.Angle(transform.up, Vector3.up);
            if (tiltAngle >= 45f)
            {
                hasFallen = true;
                Debug.Log("的が倒れました");
                // ScoreManagerのスコアを加算するメソッドを呼び出す
                scoreManager.AddScore(10); // 例えば的1つにつき10点を加算
            }
        }
    }
}