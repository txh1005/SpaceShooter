using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Timeline;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private RectTransform mask;
    [SerializeField] private Health health;
    private float originalWidth;

    private void Start()
    {
        originalWidth = mask.sizeDelta.x;
        UpdateHealthValue();
    }

    private void UpdateHealthValue()
    {
        float scale = (float)health.healthPoint / health.defaultHealthPoint;
        mask.sizeDelta = new Vector2(scale * originalWidth, mask.sizeDelta.y);
    }
}
