using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetController : MonoBehaviour
{
    private bool hasFallen = false; // 的が倒れたかを示すフラグ

    // Update is called once per frame
    void Update()
    {
        // 的がまだ倒れていない場合
        if (!hasFallen)
        {
            // 的の傾き角度を計算
            float tiltAngle = Vector3.Angle(transform.up, Vector3.up);

            // 傾き角度が45度以上なら的が倒れたと判定
            if (tiltAngle >= 45f)
            {
                hasFallen = true;
                Debug.Log("的が倒れました");
            }
        }
    }
}
