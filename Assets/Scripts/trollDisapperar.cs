using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollDisapperar : MonoBehaviour
{
    public GameObject troll;
    public AudioSource scream;
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
        if(troll.active == true) {
            troll.SetActive(false);
        } else {
            troll.SetActive(true);
            scream.Play();
        }
    }
}
