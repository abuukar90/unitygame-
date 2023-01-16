using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver : MonoBehaviour
{
    [SerializeField] float steerSpeed = 20f;
    [SerializeField] float moveSpeed = 15f;
    [SerializeField] float slowspeed = 10f;

    [SerializeField] float boostspeed = 30f;
void OnTriggerEnter2D(Collider2D other)
    {
         if (other.tag == "speedup" )
        {
            Debug.Log("your car is going faster now ");

        moveSpeed = boostspeed;

        }
    }
    
       void OnCollisionEnter2D(Collision2D other)
       {
            Debug.Log("you have bumbed into this item your are going slower ");
        
         moveSpeed = slowspeed;
    }
    

    // Update is called once per frame
    void Update()
    {
        // transform.rotation = Quaternion.Euler(0,0,0);
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed *Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);

   
    }
}
