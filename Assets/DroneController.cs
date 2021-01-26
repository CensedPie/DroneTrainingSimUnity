using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DroneController : MonoBehaviour
{
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float forward = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float side = Input.GetAxis("Horizontal") * speed * Time.deltaTime;

        transform.position = new Vector3(transform.position.x + side, transform.position.y, transform.position.z + forward);
    }
}
