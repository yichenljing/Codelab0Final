using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Door : MonoBehaviour
{
    public Text youwin;
    public KeyPickUp keypickup;
    // Start is called before the first frame update
    void Start()
    {
        youwin.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (keypickup.KeyisPicked = true)
            {
                print("YOU WIN");
                youwin.gameObject.SetActive(true);
            }
        }
    }
}
