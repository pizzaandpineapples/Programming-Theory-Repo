using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseBehavior : AnimalBehavior
{
    // Update is called once per frame
    void Update()
    {
        Move();
    }

    protected override void Move()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
        }
        //if (Input.GetKeyDown(KeyCode.W) && Input.GetKeyDown(KeyCode.A))
        //{
        //    transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        //    transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        //    transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        //}
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        }
        //if (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
        //{
        //    transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        //    transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        //    transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        //}
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        }
    }
}
