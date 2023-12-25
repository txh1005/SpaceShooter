using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private float shootingInterval;
    private float _lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (Time.time - _lastBulletTime > shootingInterval)
            {
                ShootBullet();
                _lastBulletTime = Time.time;
            }
        }
    }

    private void ShootBullet()
    {
        Instantiate(bulletPref, transform.position, Quaternion.identity);
    }
}
