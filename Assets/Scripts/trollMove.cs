using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollMove : MonoBehaviour
{

    private Animator thisAnim;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        thisAnim = GetComponent<Animator>();
        thisAnim.SetTrigger("run");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed*Time.deltaTime*Vector3.forward);
    }

    private void OnTriggerEnter(Collider other)
    {
        thisAnim.SetTrigger("attack1");
    }
}
