using UnityEngine; // todo lo que este dentro de unitu es un metodo 
using UnityEngine.InputSystem; // es un metodo porque pues es una clase que hereda de monobehaviour y no fucion cuando no depende de un objeto de la escena, es decir, no es un script que se pueda ejecutar por si solo, sino que necesita estar asociado a un objeto de la escena para poder funcionarUni
public class Movimiento1 : MonoBehaviour // es un metodo porque pues es una clase que hereda de monobehaviour y no fucion cuando no depende de un objeto de la escena, es decir, no es un script que se pueda ejecutar por si solo, sino que necesita estar asociado a un objeto de la escena para poder funcionar
{
    public float velocidad = 5f;
    private SpriteRenderer spriteRenderer;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // es una funcion pero al estar en una clase pues es un metodo
    void Start() // es lo que se inicializa una vez se le de play al juego, y ha de tener cuidado fuera de la camara 
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime); 
            spriteRenderer.color = Color.red;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.blue;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.green;
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * velocidad * Time.deltaTime);
            spriteRenderer.color = Color.yellow;
        }
    }
}
