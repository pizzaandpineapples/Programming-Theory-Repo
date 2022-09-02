using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseBehavior : AnimalBehavior // INHERITANCE
{
    // Update is called once per frame
    void Update()
    {
        Move(); // ABSTRACTION
    }

    protected override void Move() // POLYMORPHISM
    {
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.W) && Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.S) && Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.A) && Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.E))
        {
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.D) && Input.GetKey(KeyCode.Q))
        {
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        }
    }
}
