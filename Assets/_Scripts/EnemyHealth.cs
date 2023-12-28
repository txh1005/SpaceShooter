using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private GameObject explosionPrefab;
    //private void OnTriggerEnter2D(Collider2D collision) => Die();
    protected override void Die()
    {
        base.Die();
    }
}
