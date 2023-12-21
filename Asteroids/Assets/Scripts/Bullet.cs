using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField]
    private float bulletSpeed = 500.0f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    public void Project(Vector2 direction)
    {
        rb.AddForce(direction * this.bulletSpeed);
    }

    private void Update()
    {
        if (transform.position.y > 5.15f)
        {
            Destroy(gameObject);
        }
        else if (transform.position.y < -5.15f)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x > 9.05f)
        {
            Destroy(gameObject);
        }
        else if (transform.position.x < -9.05f)
        {
            Destroy(gameObject);
        }
    }
}
