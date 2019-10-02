using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMovement : MonoBehaviour
{

    public float speed = 1f;
    public Transform target;
    readonly float minZ = 0;
    readonly float maxZ = 5;
    private bool moveZ = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (moveZ)
        {

            transform.Translate(target.position.x, 0.0f, speed * Time.deltaTime);
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 1);

        }
        else
        {
            transform.Translate(target.position.x, 0.0f, -speed * Time.deltaTime);
            gameObject.GetComponent<Renderer>().material.color = new Color(1, 1, 0);
        }

        if (transform.position.z >= maxZ)
        {
            moveZ = false;
        }

        if (transform.position.z <= minZ)
        {
            moveZ = true;
        }
    }
    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
