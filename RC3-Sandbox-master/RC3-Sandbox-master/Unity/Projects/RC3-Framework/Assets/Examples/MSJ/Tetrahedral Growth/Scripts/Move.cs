using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour
{
    public Transform[] b = new Transform[1];
    // Use this for initialization
    void Start()
    {
        var ball = GameObject.CreatePrimitive(PrimitiveType.Cube);
        b[0] = ball.transform;
        ball.transform.localScale = new Vector3(1, 1, 1);
        ball.GetComponent<MeshRenderer>().material.color = Color.green;

    }
    private void FixedUpdate()
    {
        b[0].localPosition = transform.position;
    }
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.UpArrow))
        {
            up();
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            down();
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            right();
        }
        if (Input.GetKey(KeyCode.W))
        {
            forward();
        }
        if (Input.GetKey(KeyCode.S))
        {
            back();
        }
        if (Input.GetKey(KeyCode.R))
        {
            fly();
        }
        if (Input.GetKey(KeyCode.T))
        {
            fall();
        }

    }

    private void up()
    {
        gameObject.transform.Translate(gameObject.transform.up * 0.1f, transform);
    }
    private void down()
    {
        gameObject.transform.Translate(-gameObject.transform.up * 0.1f, transform);
    }
    private void left()
    {
        gameObject.transform.Translate(-gameObject.transform.right * 0.1f, transform);
    }
    private void right()
    {
        gameObject.transform.Translate(gameObject.transform.right * 0.1f, transform);
    }
    private void forward()
    {
        gameObject.transform.Translate(gameObject.transform.forward * 0.1f, transform);
    }
    private void back()
    {
        gameObject.transform.Translate(-gameObject.transform.forward * 0.1f, transform);
    }
    private void fly()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<ConstantForce>().force = new Vector3(0, 10, 0);
    }
    private void fall()
    {
        gameObject.AddComponent<Rigidbody>();
        gameObject.AddComponent<ConstantForce>().force = new Vector3(0, -10, 0);
    }

}
