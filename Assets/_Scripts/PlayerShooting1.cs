using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting1 : MonoBehaviour
{
    [SerializeField] private GameObject bulletPref;
    [SerializeField] private float shootingInterval;
    [SerializeField] private Vector3 bulletOffset;
    private float _lastBulletTime;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            UpdateFiring();
        }
    }
    void UpdateFiring()
    {
        if (Time.time - _lastBulletTime > shootingInterval)
        {
            ShootBullet();
            _lastBulletTime = Time.time;
        }
    }
    private void ShootBullet()
    {
        var bullet = Instantiate(bulletPref, transform.position + bulletOffset, Quaternion.identity);
    }
}
