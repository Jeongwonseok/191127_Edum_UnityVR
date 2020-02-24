using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnJangSound2 : MonoBehaviour
{
    [SerializeField] AudioSource Sound_1;
    [SerializeField] AudioSource Sound_2;
    [SerializeField] AudioSource Sound_3;
    [SerializeField] AudioSource Sound_4;
    [SerializeField] AudioSource Sound_5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnjangsound2()
    {
        Sound_1.Stop();
        Sound_3.Stop();
        Sound_4.Stop();
        Sound_5.Stop();
        Sound_2.Play();
    }

}
