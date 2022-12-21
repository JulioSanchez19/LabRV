using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trollKill : MonoBehaviour
{

    public AudioSource trollSound;
    public GameObject troll;
    public Animator thisAnim;
    private int counter=0;
    // Start is called before the first frame update
    void Start()
    {
        thisAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "axe"){
            trollSound.Play();

            thisAnim.SetTrigger("attack1");
            counter++;
        }
        if(counter ==5){
            thisAnim.SetTrigger("death");
            yield return new WaitUntil(() => thisAnim.GetCurrentAnimatorStateInfo(0).normalizedTime <= 1.0f );
            troll.SetActive(false);
        }
    }
}
