using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public float speed = 6f;

    Vector3 movement;

    private Transform target;
    public float smooth = 5f;
    Rigidbody rigid;

    Vector3 offset;

    private void Awake()
    {
        target = GetComponent<Transform>();
        target.position = new Vector3(3.5f, 3.5f, -10f);
    }


    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Move(h, v);
        //Turning();
        //Animating(h, v);
    }

    private void Move(float h, float v)
    {
        movement.Set(h, v, 0f);
        movement = movement.normalized * speed * Time.deltaTime;

        target.position = target.position + movement;

    }
}
