using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollMove : MonoBehaviour
{

    private Animator thisAnim;
    // Start is called before the first frame update
    void Start()
    {
        thisAnim = GetComponent<Animator>();
        thisAnim.applyRootMotion = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
