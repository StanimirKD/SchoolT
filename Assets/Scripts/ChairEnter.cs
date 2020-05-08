using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairEnter : MonoBehaviour
{
    bool mouseIn = false;
    public bool inview = false;

    void OnMouseOver()
    {
        mouseIn = true;
    }

    void OnMouseExit()
    {
        mouseIn = false;
    }

    void Update()
    {
        if (mouseIn == true) {
            if (Input.GetMouseButtonDown(1)){



            }
        }
    }
}