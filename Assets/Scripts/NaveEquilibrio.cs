using UnityEngine;

public class NaveEquilibrio : MonoBehaviour
{
    public float fuerza = 8f;

    private SpriteRenderer sr;

    private Rigidbody2D rb;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            sr.color = Color.red;
        }
                if (Input.GetKeyDown(KeyCode.S))
        {
            sr.color = Color.blue;
        }
                if (Input.GetKeyDown(KeyCode.A))
        {
            sr.color = Color.green;
        }
                if (Input.GetKeyDown(KeyCode.D))
        {
            sr.color = Color.yellow;
        }
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        Vector2 direccion = new Vector2(
            horizontal,
            vertical
        );

        rb.AddForce(direccion * fuerza);
    }
}

