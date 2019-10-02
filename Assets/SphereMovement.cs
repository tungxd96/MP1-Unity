using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{

    public float speed = 1f;
    public Transform target;
    readonly float minX = 0;
    readonly float maxX = 5;
    private bool moveX = true;

    // Update is called once per frame
    void Update()
    {

        if (moveX)
        {

            transform.Translate(speed * Time.deltaTime, 0.0f, target.position.z);
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);

        } else
        {
            transform.Translate(-speed * Time.deltaTime, 0.0f, target.position.z);
            gameObject.GetComponent<Renderer>().material.color = new Color(0, 1, 1);
        }

        if (transform.position.x >= maxX)
        {
            moveX = false;
        }

        if (transform.position.x <= minX)
        {
            moveX = true;
        }

    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }

}
