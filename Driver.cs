using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 1f;
    [SerializeField] float movespeed = 0.01f;
    [SerializeField] float boost = 15f;
    [SerializeField] float bump = 7f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float steeramount = Input.GetAxis("Horizontal") * steerspeed * Time.deltaTime;
        float moveamount = Input.GetAxis("Vertical") * movespeed * Time.deltaTime;

        transform.Rotate(0, 0, -steeramount);
        transform.Translate(0, moveamount, 0);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            movespeed = boost;
        }
    }
     void OnCollisionEnter2D(Collision2D other)
    {
        movespeed = bump;
    }
}
