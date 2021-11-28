using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
[SerializeField] float steerSpeed = 205f;
[SerializeField] float moveSpeed = 15f;
//[SerializeField] float slowSpeed = 20f;
[SerializeField] float fastSpeed = 40f;

    void Start()
    {
        //transform.Rotate(0, 0, 45);  // x, y, z

    }

    void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }
    
    void OnTriggerEnter2D(Collider2D other) {
            if (other.tag == "Boost") {
                moveSpeed = fastSpeed;
            }
        }
}
