using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private GameObject explosionPref;
    [SerializeField] private int defaultHealthPoint;
    private int _healthPoint;
    // Start is called before the first frame update
    private void Start() => _healthPoint = defaultHealthPoint;
    public void OnTriggerEnter2D(Collider2D collision) => Die();

    protected virtual void Die()
    {
        var explosion = Instantiate(explosionPref, transform.position, Quaternion.identity);
        Destroy(explosion, 1);
        Destroy(gameObject);
    }

    public void TakeDamage(int damage)
    {
        if (_healthPoint <= 0) return;
        _healthPoint -= damage;
        if (_healthPoint <= 0) Die();

    }
    // Update is called once per frame
    void Update()
    {

    }
}
