using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject camera;
    bool turnoff = true;
    float speed = 10.0f;
    float vert;
    float horiz;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            if (turnoff)
            {
                turnoff = false;
                Debug.Log("1");
                camera.SetActive(false);
            }
            else
            {
                Debug.Log("2");
                turnoff = true;
                camera.SetActive(true);
            }


        }
        if (!turnoff)
        {
            if (Input.GetAxis("Mouse X") != 0)
            {
                vert += speed * Input.GetAxis("Mouse Y");
                horiz += speed * Input.GetAxis("Mouse X");
                transform.eulerAngles = new Vector3(-vert, horiz, 0.0f);
            }
            if (Input.GetMouseButton(0))
            {
                transform.position += transform.forward * Time.deltaTime * 5f;
                Debug.Log("hihi");
            }
        }
    }
}
