using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiowhencollsion : MonoBehaviour
{
    AudioSource audio; //create a field for the AudioSource "audio"

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>(); //get the AudioSource component from this gameObject
    }

    // Update is called once per frame
    void Update()
    {

    }

    //if this game object collides with something
    private void OnCollisionEnter2D(Collision2D collision)
    {
        audio.Play(); //play the audio
    }
}
