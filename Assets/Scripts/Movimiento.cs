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
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)) // si se presiona la tecla de flecha hacia arriba o la tecla W
        {
            transform.Translate(Vector3.up * velocidad * Time.deltaTime); // Time.deltaTime nos deja mover algo pero dentro de la escena
            spriteRenderer.color = Color.red;
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
            spriteRenderer.color = Color.red;
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

// using UnityEngine; // Permite usar las clases de Unity.
// using UnityEngine.InputSystem; // Permite usar el nuevo Input System.

// // Es una clase que hereda de MonoBehaviour.
// // Puedes agregar este script como componente a un GameObject.
// public class Movimiento1 : MonoBehaviour
// {
//     // Campo público: puedes ajustar su valor en el Inspector.
//     // Representa la velocidad en unidades por segundo.
//     public float velocidad = 5f;

//     // Unity llama a Start una vez, antes del primer Update,
//     // cuando el componente está habilitado y puede ejecutarse.
//     void Start()
//     {
//     }

//     // Unity llama a Update una vez por frame.
//     void Update()
//     {
//         // Obtiene el teclado actual.
//         Keyboard teclado = Keyboard.current;

//         // Si no hay un teclado disponible, termina este Update.
//         if (teclado == null)
//         {
//             return;
//         }

//         // isPressed indica si la tecla está mantenida.
//         // || significa "o": basta con presionar una de las dos.
//         if (teclado.upArrowKey.isPressed || teclado.wKey.isPressed)
//         {
//             transform.Translate(Vector3.up * velocidad * Time.deltaTime);
//         }

//         if (teclado.downArrowKey.isPressed || teclado.sKey.isPressed)
//         {
//             transform.Translate(Vector3.down * velocidad * Time.deltaTime);
//         }

//         if (teclado.leftArrowKey.isPressed || teclado.aKey.isPressed)
//         {
//             transform.Translate(Vector3.left * velocidad * Time.deltaTime);
//         }

//         if (teclado.rightArrowKey.isPressed || teclado.dKey.isPressed)
//         {
//             transform.Translate(Vector3.right * velocidad * Time.deltaTime);
//         }
//     }
// }