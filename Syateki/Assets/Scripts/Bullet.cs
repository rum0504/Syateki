using UnityEngine;
public class Bullet : MonoBehaviour
{
    public GameObject hitEffect; // �����������̃G�t�F�N�g
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            // �G�t�F�N�g�𐶐����Ď��g��j��
            Instantiate(hitEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
  
    }
}