using UnityEngine;
public class Bullet : MonoBehaviour
{
    public GameObject hitEffect; // 当たった時のエフェクト
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            // エフェクトを生成して自身を破棄
            Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
  
    }
}