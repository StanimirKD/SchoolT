using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Draw : MonoBehaviour
{
     public GameObject Camera1;
    public GameObject Canvas;
    public GameObject Character;
    public GameObject Brush;
    public float BrushSize = 0.0001f;
    bool mouseIn=false;
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
     
            if (inview)
        {
           
              
            
            if (mouseIn)
            {
                if (Input.GetMouseButton(0))
                {
                    //cast a ray to the plane
                    var Ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    RaycastHit hit;
                    if (Physics.Raycast(Ray, out hit))
                    {
                        //instanciate a brush
                        var go = Instantiate(Brush, hit.point + Vector3.right * 0.1f, Quaternion.identity, transform);
                        go.transform.localScale = Vector3.one * BrushSize;
                        go.transform.Rotate(-Vector3.forward * 90);
                    }
                }

            }
            if (Input.GetKeyDown("escape"))
            {
                Character.transform.position = new Vector3(40, 2, 40);
                Character.SetActive(true);
              
                Screen.lockCursor = false;
                inview = false;
                Screen.lockCursor = true;
                inview = false;
                Camera1.SetActive(true);
                Canvas.SetActive(false);
              
               
            }
        }
    }
    void OnCollisionEnter(Collision collision)
   {

        if (collision.gameObject.tag == "Player")
        {
            Screen.lockCursor = false;
            inview = true;
            Camera1.SetActive(false);
            Canvas.SetActive(true);
            Character.SetActive(false);
       }


    }
}
        

