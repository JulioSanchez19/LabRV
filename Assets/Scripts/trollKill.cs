using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollKill : MonoBehaviour
{

    public AudioSource trollSound;
    public GameObject troll;
    private int counter=0;
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
        if(other.gameObject.tag == "axe"){
            trollSound.Play();
            counter++;
        }
        if(counter ==5){
            troll.SetActive(false);
        }
    }
}
