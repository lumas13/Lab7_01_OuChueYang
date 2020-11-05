using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{
    public GameObject upCube;
    public GameObject downCube;
    public GameObject rightCube;
    public GameObject leftCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            //print("Up arrow pressed");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            //print("Up arrow released");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //print("Up arrow pressed");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            //print("Up arrow released");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            //print("Up arrow pressed");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            //print("Up arrow released");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            //print("Up arrow pressed");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            //print("Up arrow released");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
