using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;

    public CameraMovement()
    {
        this.cameraSpeed = 5.0f;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(this.cameraSpeed * Time.deltaTime, 0, 0);
    }
}
