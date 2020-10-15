using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class mouse_control : MonoBehaviour
{
    // Start is called before the first frame update
    public float mousesensitivity = 100f;
        public Transform playerbody;
    float xrotation = 0f;
    void Start()
    {

        Cursor.lockState = CursorLockMode.Locked;
       

    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesensitivity * Time.deltaTime;
        xrotation -= mouseY;
            xrotation = Mathf.Clamp(xrotation, -90f, 90f);


            transform.localRotation = Quaternion.Euler(xrotation, 0f, 0f);
        playerbody.Rotate(Vector3.up * mouseX);

    }
}
