using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeHand : MonoBehaviour
{

    public Transform GameObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(GameObject.eulerAngles.z);
        if(GameObject.eulerAngles.z < 15f && GameObject.eulerAngles.z > -15f) {
            gameObject.SetActive(true);
        } else {
            gameObject.SetActive(false);
        }
        
    }
}
