using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    [SerializeField] Color32 hasPackagecolor = new Color32 (1, 1, 1, 1);
    [SerializeField] Color32 noPackagecolor = new Color32 (1, 1, 1, 1);
    [SerializeField] float destroyDelay = 0.5f;
    bool haspackage;

    SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("ouch!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag == "Package" && !haspackage)
        {
            Debug.Log("Package picked up");
            haspackage = true;
            spriteRenderer.color = hasPackagecolor;

            Destroy(other.gameObject, destroyDelay);
        }



        if (other.tag == "costumer" && haspackage)
        {
            Debug.Log("deliverd Package");
            haspackage = false;
            spriteRenderer.color = noPackagecolor;
        }
    }



}

