using System.Collections;
using System.Collections.Generic;
//using System.Threading;
using UnityEngine;

public class trollKill : MonoBehaviour
{

    public AudioSource trollSound;
    public GameObject troll;
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
        trollSound.Play();
        //Thread.Sleep(1000);
        //troll.SetActive(false);
    }


}
