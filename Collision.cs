using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Collision : MonoBehaviour
{
    bool pick = false;
    [SerializeField] float destroyrate = 0.5f;

    SpriteRenderer car, package;
     void Start()
    {
        car = GetComponent<SpriteRenderer>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Hit!");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !pick)
        {
            
            Debug.Log("Package Picked Up");
            pick = true;
            package = other.GetComponent<SpriteRenderer>();
            car.color = package.color;
            Destroy(other.gameObject, destroyrate);
        }
        if (pick && other.tag == "Customer")
        {
            Debug.Log("Package Delivered");
            pick = false;
        }
    }
}
