using UnityEngine;
using UnityEngine.InputSystem;

public class Mov2 : MonoBehaviour
{

    public float speed = 5f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log("Script de movimiento corriendo");
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.isPressed)
        {
            Debug.Log("W key is pressed");
        }
        if (Keyboard.current.sKey.isPressed)
        {
            Debug.Log("S key is pressed");
        }
        if (Keyboard.current.aKey.isPressed)
        {
            Debug.Log("A key is pressed");
        }
        if (Keyboard.current.dKey.isPressed)
        {
            Debug.Log("D key is pressed");
        }
    }
}
