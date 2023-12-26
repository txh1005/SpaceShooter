using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField] private GameObject explosionPrefab;
    private void OnTriggerEnter2D(Collider2D collision) => Die();

    private void Die()
    {
        var explosion = Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }
}
