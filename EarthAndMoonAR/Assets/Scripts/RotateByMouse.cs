using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateByMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    float rotSpeed = 10;

    void OnMouseDrag()
    {
        float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
        float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

        //transform.RotateAround(Vector3.up, -rotX);
        //transform.Rotate(Vector3.right, rotY);
        //transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y + rotY, transform.rotation.z));
        transform.RotateAround(Vector3.up, -rotX);
        //transform.RotateAround(Vector3.right, rotY);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
