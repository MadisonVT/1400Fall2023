using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGMusic : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    void Awake()
    {
        music = GetComponent<AudioSource>();
        GetComponent<AudioSource>().Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
