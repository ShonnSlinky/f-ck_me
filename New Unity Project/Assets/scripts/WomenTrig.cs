using UnityEngine;
using System.Collections;

public class WomenTrig : MonoBehaviour {
    Animator anim;
    int to_oghasm = 0;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        to_oghasm++;
        Debug.Log("Triggered women! " + to_oghasm);
        anim.SetBool("go", true);
    }
    void OnTriggerExit2D(Collider2D collider)
    {
        anim.SetBool("go", false);
    }
}
