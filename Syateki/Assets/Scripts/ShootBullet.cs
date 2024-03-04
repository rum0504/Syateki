using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBullet : MonoBehaviour
{
    public GameObject bulletPrefab; // Inspectorから弾のプレハブを指定
    public float initialSpeed = 10f; // Inspectorから弾の初速を指定
    public Transform spawnPoint; // Inspectorから発射位置を指定

    // Update is called once per frame
    void Update()
    {
        // Spaceボタンを押したら弾を発射
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // 弾オブジェクトを生成して速度を設定
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody bulletRigidbody = bullet.GetComponent<Rigidbody>();
        bulletRigidbody.velocity = spawnPoint.forward * initialSpeed;
    }
}
