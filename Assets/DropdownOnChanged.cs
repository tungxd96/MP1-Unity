using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropdownOnChanged : MonoBehaviour
{

    readonly List<string> dropdownList = new List<string>() { "Object To Create", "Sphere", "Cube", "Cylinder" };
    Vector3 pos;
    public Dropdown dropdownMenu;
    public Transform mainSpherePos;
    public GameObject sphereObj;
    public GameObject cubeObj;
    public GameObject cylinderObj;

    // Start is called before the first frame update
    void Start()
    {
        InitializeDropdownMenu();
    }

    void InitializeDropdownMenu()
    {
        dropdownMenu.AddOptions(dropdownList);
    }
    
    public void DropdownItemClicked(int index)
    {

        pos.Set(mainSpherePos.position.x, mainSpherePos.position.y * 2 , mainSpherePos.position.z);

        if (index == 1)
        {
            Instantiate(sphereObj, pos, mainSpherePos.rotation);
        }
        else if (index == 2)
        {
            Instantiate(cubeObj, pos, mainSpherePos.rotation);
        }
        else if (index == 3)
        {   
            Instantiate(cylinderObj, pos, mainSpherePos.rotation);
        }

    }

    // Update is called once per frame
    void Update()
    {
        dropdownMenu.ClearOptions();
        dropdownMenu.AddOptions(dropdownList);
    }
}
