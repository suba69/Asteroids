using UnityEngine;

public class Asteroid : MonoBehaviour
{
    public Sprite[] sprites;
    public float size;
    public float speed = 50.0f;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D rb;
    public float minSize = 0.5f;
    public float maxSize = 1.5f;
    private float maxLifeTime = 30.0f;

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

    public void SetTrajectory(Vector2 direction)
    {
        rb.AddForce(direction * this.speed);

        Destroy(this.gameObject, this.maxLifeTime);
    } 
}
