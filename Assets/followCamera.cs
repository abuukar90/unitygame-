using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followCamera : MonoBehaviour
{
[SerializeField] GameObject  thingToFollow;
    //this thing postion (camera) should be the same as postion 
    // Start is called before the first frame update
    
   
    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + new Vector3 (0,0,-10);
    }
}
