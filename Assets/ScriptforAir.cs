using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptforAir : MonoBehaviour
{
    [SerializeField] private GameObject feather= null;
     
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        feather.transform.Rotate(0,0,0.3f);
    }
   
}
