using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float fuerza = 1f;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) 
        {
            rb.AddForce(Vector2.up * fuerza, ForceMode2D.Force); // AddForce nos deja mover algo pero dentro de la escena
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Vector2.down * fuerza, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * fuerza, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * fuerza, ForceMode2D.Force);
        }
    }
}
// utilizamos solo translate para mover la nave, y no utilizamos rigidbody ni addforce,
// ya que no queremos que la nave tenga física, solo queremos que se mueva en la escena.
