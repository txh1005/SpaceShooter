using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    public static int LivingEnemyCount;
    private void Awake() => LivingEnemyCount++;
    [SerializeField] private GameObject explosionPrefab;
    //private void OnTriggerEnter2D(Collider2D collision) => Die();
    protected override void Die()
    {
        LivingEnemyCount--;
        base.Die();
    }
}
