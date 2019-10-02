using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovement : MonoBehaviour
{

    public float speed = 1f;
    public float rotateDegree = 90f;
    public Transform target;
    readonly float minY = 0;
    readonly float maxY = 5;
    private bool moveY = true;

    // Update is called once per frame
    void Update()
    {

        if (moveY)
        {

            transform.Translate(target.position.x, speed * Time.deltaTime, target.position.z);
            transform.Rotate(0.0f, rotateDegree * Time.deltaTime, 0.0f);
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);
        }
        else
        {

            transform.Translate(target.position.x, -speed * Time.deltaTime, target.position.z);
            transform.Rotate(0.0f, rotateDegree * Time.deltaTime, 0.0f);
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 0, 1);

        }

        if (transform.position.y >= maxY)
        {

            moveY = false;

        }
        if (transform.position.y <= minY)
        {

            moveY = true;

        }
        
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
