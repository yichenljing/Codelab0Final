using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPickUp : MonoBehaviour
{
    public Text youwin;
    public GameObject key;
    public bool KeyisPicked = false;
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
            print("PlayerHit");
            KeyisPicked = true;
            key.SetActive(false);
            youwin.gameObject.SetActive(true);


        }
    }
}
