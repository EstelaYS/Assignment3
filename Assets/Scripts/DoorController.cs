using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //Call animator
    private Animator doorAnimation;


    // Start is called before the first frame update
    void Start()
    {
        //Call component 
        doorAnimation = this.transform.parent.GetComponent<Animator>();

    }

    //Trigger

    void OnTriggerEnter(Collider other)
    {
        //When first person controller trigger the collider, animation runs open the door
        doorAnimation.SetBool("isOpening", true);
    }

    //Close the door
    void onTriggerExit(Collider other)
    {
        doorAnimation.SetBool("isOpening", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
