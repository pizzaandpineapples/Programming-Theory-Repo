using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class AnimalBehavior : MonoBehaviour
{
    [SerializeField] protected float power = 10.0f;
    private float m_speed = 3.0f;

    public float speed // ENCAPSULATION
    {
        get { return m_speed; }
        set { m_speed = value; }
    }

    void Update()
    {
        Move(); // ABSTRACTION
        SpeedMultiplier(); // ABSTRACTION
    }

    protected virtual void Move()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * power * speed);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * power * speed);
        }
    }

    protected virtual void SpeedMultiplier()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            speed = 3.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            speed = 5.0f;
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            speed = 7.0f;
        }
    }
}
