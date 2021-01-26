using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneCamController : MonoBehaviour
{
    public float camSensitivity = 100f;
    float xRotation = 0f;
    float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float axisX = Input.GetAxis("DroneCamHorizontal") * camSensitivity * Time.deltaTime;
        float axisY = Input.GetAxis("DroneCamVertical") * camSensitivity * Time.deltaTime;

        xRotation -= axisY;
        xRotation = Mathf.Clamp(xRotation, -20f, 90f);
        yRotation += axisX;

        transform.localRotation = Quaternion.Euler(xRotation, yRotation, 0f);
    }
}
