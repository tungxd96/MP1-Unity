using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserDefinedTarget : MonoBehaviour
{

    Vector3 newPosition;
    public Transform target;

    private void Start()
    {
        newPosition = target.position;
    }

    private void OnMouseDown()
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit))
        {
            newPosition = new Vector3(hit.point.x, hit.point.y + 0.25f, hit.point.z);
            target.position = newPosition;
        }
    }

    private void Update()
    {
        
    }

}
