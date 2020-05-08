using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class CopyText : MonoBehaviour
{
    //text blahblah; 
    public GameObject whiteboard;
    public GameObject input;
    // Start is called before the first frame update
    void Start()
    {
        Screen.lockCursor = true;

    }

    // Update is called once per frame
    void Update()
    {
      whiteboard.GetComponent<TextMeshPro>().text=input.GetComponent<TMP_InputField>().text;
    }
}
