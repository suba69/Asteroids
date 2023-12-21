using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroids : MonoBehaviour
{
    private Sprite[] sprites;
    [SerializeField]
    private float size;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    [SerializeField]
    private float minSize = 0.5f;
    [SerializeField]
    private float maxSize = 1.5f;

    private void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        spriteRenderer.sprite = sprites[Random.Range(0, sprites.Length)];

        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        this.transform.localScale = Vector3.one * this.size;

        rb.mass = size;
    }
}
