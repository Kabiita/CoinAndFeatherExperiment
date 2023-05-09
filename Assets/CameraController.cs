using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private GameObject camera= null;
    float speed=12.0f;
    float rotationspeed=100.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
       float Translation=Input.GetAxis("Vertical")*speed;
       float Rotation=Input.GetAxis("Horizontal")*rotationspeed;

       Translation=Translation*Time.deltaTime;
       Rotation=Rotation*Time.deltaTime;

       camera.transform.Translate(0,0, Translation);

       camera.transform.Rotate(Rotation, 0, 0);

    }
}
