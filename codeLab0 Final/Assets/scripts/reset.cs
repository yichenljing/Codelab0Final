using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reset : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //if something hits this trigger
    private void OnTriggerExit2D(Collider2D other)
    {
        GameObject otherObj = other.gameObject; //get the other gameObject

        Rigidbody2D otherRb = otherObj.GetComponent<Rigidbody2D>(); //get it's rigidBody

        print("111");

        otherRb.MovePosition(new Vector2(-10.32f, 8.1f)); //use MovePosition to move it to the start position

        otherRb.velocity = Vector2.zero; //resent it's velocity to 0,0,0
    }
  
}