using UnityEngine;
using UnityEngine.InputSystem;

public class CameraMove : MonoBehaviour
{
    public float CameraSpeed = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector3.forward * CameraSpeed * Time.deltaTime);
        }
        if(Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector3.back * CameraSpeed * Time.deltaTime);
        }
        if(Keyboard.current.aKey.isPressed)
        {
            transform.Translate(Vector3.left * CameraSpeed * Time.deltaTime);
        }
        if(Keyboard.current.dKey.isPressed)
        {
            transform.Translate(Vector3.right * CameraSpeed * Time.deltaTime);
        }
        if(Keyboard.current.qKey.isPressed)
        {
            transform.Translate(Vector3.down * CameraSpeed * Time.deltaTime);
        }
        if(Keyboard.current.eKey.isPressed)
        {
            transform.Translate(Vector3.up * CameraSpeed * Time.deltaTime);
        }
    }
}
