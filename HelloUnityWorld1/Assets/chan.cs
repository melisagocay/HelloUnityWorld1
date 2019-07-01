using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class chan : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TextMeshProUGUI myText = GetComponent<TextMeshProUGUI>();
        if (Input.GetKeyDown("space")) {
            myText.SetText("Hello World From Melisa!");
            Debug.Log ("Key Pressed");
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
}
