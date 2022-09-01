using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimalBehavior : MonoBehaviour
{
    [SerializeField] protected float power = 10.0f;
    [SerializeField] protected float speed = 3.0f;

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
        }
    }
}
