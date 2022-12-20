using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class trollDisapperar : MonoBehaviour
{
    public GameObject troll;
    public AudioSource scream;
    public Animator thisAnim;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        scream.Play();
        thisAnim.applyRootMotion = true;

        Thread.Sleep(5000);
        troll.SetActive(false);

    }
}
