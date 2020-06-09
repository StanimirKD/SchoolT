using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sit : MonoBehaviour
{
    public GameObject Character;
     Animator anim;
    public GameObject chair;




    // Start is called before the first frame update
    void Start()
    {

        anim = Character.GetComponent<Animator>();

    }
    void OnCollisionEnter(Collision collision)
    {
        if (PlayerPrefs.GetInt("Standing", 0) == 1)
        {
            if (collision.gameObject.tag == "Player")
            {
                Character.transform.position = chair.transform.position;
               Character.transform.position += Vector3.down * 0.5f;
               Character.transform.position += Vector3.back * 0.25f;
                Character.transform.position += Vector3.right * 0.2f;
                Character.GetComponent<Rigidbody>().isKinematic = true;
                PlayerPrefs.SetInt("Standing", 0);
                Debug.Log("Hey, hey");
                anim.SetBool("isSit", true);
                if (chair.name == "chair0")
                {
                   
                    Character.transform.position += Vector3.forward * 0.55f;
                    Character.transform.position += Vector3.left * 0.3f;
                    Debug.Log("yep");
                }
                {
                    //Start the coroutine we define below named ExampleCoroutine.
                    StartCoroutine(ExampleCoroutine());
                }

                IEnumerator ExampleCoroutine()
                {


                    //yield on a new YieldInstruction that waits for 5 seconds.
                    yield return new WaitForSeconds(0.7f);
                    Character.GetComponent<CapsuleCollider>().center = new Vector3(0, 1.42f, 0);

                }
            }
        }
            }

            void Update()
    {
        
           
         
            if (anim.GetBool("isSit") == true)
            {
                if (Input.GetMouseButtonDown(1) )
                {
                Debug.Log("hi");
                anim.SetBool("isSit", false);
                anim.SetBool("isHand", true);
              
                }
            }
        if (anim.GetBool("isHand") == true)
        {
            if (Input.GetMouseButtonDown(2))
            {
                anim.SetBool("isHand", false);
                anim.SetBool("isSit", true);
               

                Debug.Log("hi1");
            }
        }
        if (anim.GetBool("isSit") == true || anim.GetBool("isHand") == true)
          {
            if (Input.GetKeyDown("space"))
            {
                Character.transform.position = new Vector3(47, 1, 33);
                {
                    //Start the coroutine we define below named ExampleCoroutine.
                    StartCoroutine(ExampleCoroutine());
                }

                IEnumerator ExampleCoroutine()
                {


                    //yield on a new YieldInstruction that waits for 5 seconds.
                    yield return new WaitForSeconds(0.1f);
                   


                    anim.SetBool("isSit", false);
                    anim.SetBool("isHand", false);
                    Character.GetComponent<CapsuleCollider>().center = new Vector3(0, 0.95f, 0);
                    Character.GetComponent<Rigidbody>().isKinematic = false;
                    PlayerPrefs.SetInt("Standing", 1);
                }
            }

              
           }
        }
    void OnApplicationQuit() {
        PlayerPrefs.SetInt("Standing", 1);
        
    }
    }
