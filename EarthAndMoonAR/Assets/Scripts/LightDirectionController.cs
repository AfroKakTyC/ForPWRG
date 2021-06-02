using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightDirectionController : MonoBehaviour
{
    public Slider lightDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LightDirection()
	{
        float rotationSpeed = 45;
        Vector3 currentEulerAngles;
        Quaternion currentRotation = new Quaternion(0, 0, 0, 0);
        currentEulerAngles = new Vector3(0, lightDirection.value, 0) * 2;
        currentRotation.eulerAngles = currentEulerAngles;
        transform.rotation = currentRotation;
        //gameObject.transform.Rotate(0.0f, lightDirection.value, 0.0f, Space.Self);
        //transform.RotateAround(Vector3.up, -lightDirection.value);
        //gameObject.transform.rotation = new Quaternion(gameObject.transform.rotation.x, lightDirection.value, gameObject.transform.rotation.z, 0);
	}


}
