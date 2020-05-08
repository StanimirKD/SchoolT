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
        Debug.Log(PlayerPrefs.GetString("Text", ""));
        Screen.lockCursor = true;
        input.GetComponent<TMP_InputField>().text = PlayerPrefs.GetString("Text", "");
    }

    // Update is called once per frame
    void Update()
    {
      whiteboard.GetComponent<TextMeshPro>().text=input.GetComponent<TMP_InputField>().text;
    }
    void OnApplicationQuit()
    {
      
        PlayerPrefs.SetString("Text", whiteboard.GetComponent<TextMeshPro>().text);
       // Debug.Log(PlayerPrefs.GetString("Text", ""));
    }

}
