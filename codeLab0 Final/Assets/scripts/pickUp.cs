using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class pickUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private int score = 0;
    public Text text;
    public GameObject winText;

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "key")
        {
            score++;

            text.text = "Score: " + score.ToString();
            if (score == 1)
            {
                winText.SetActive(true);
            }
            Destroy(collider.gameObject);
        }
    }
}
