using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float bulletSpeed = 500.0f;
    private float maxLifeTime = 5.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Project(Vector2 direction)
    {
        rb.AddForce(direction * this.bulletSpeed);

        Destroy(this.gameObject, this.maxLifeTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);
    }
}
