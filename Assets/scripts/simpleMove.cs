using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;
    [SerializeField]
private float LimitTop = 4.5f;
[SerializeField]
private float LimitBottom = -4.5f;
[SerializeField]
private float Limitleft = -8.5f;
[SerializeField]
private float LimititRight = 8.5f;
        void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3 (horizontalInput, verticalInput, 0f) * SpeedFactor;

        transform.position = transform.position + velocity * Time.deltaTime;

        if (transform.position.y < LimitBottom) {
            transform.position = new Vector3 (transform.position.x, LimitBottom,transform.position.z);
        }
        if (transform.position.y > LimitTop){
            transform.position = new Vector3 (transform.position.x, LimitTop,transform.position.z);
        }
        if (transform.position.x < Limitleft){
             transform.position = new Vector3 (Limitleft, transform.position.y, transform.position.z);
        }
        if (transform.position.x > LimititRight) {
             transform.position = new Vector3 (LimititRight, transform.position.y, transform.position.z);
    
    }
 }
}

