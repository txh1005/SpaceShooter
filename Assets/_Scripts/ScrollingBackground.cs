using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    [SerializeField] private Renderer bgRenderer;
    [SerializeField] private float speed;

    void Update() => bgRenderer.material.mainTextureOffset = new Vector2(0, Time.time * speed);

}
