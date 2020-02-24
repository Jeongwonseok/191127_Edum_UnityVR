using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Sound3 : MonoBehaviour
{
    [SerializeField] AudioSource Sound_1;
    [SerializeField] AudioSource Sound_2;
    [SerializeField] AudioSource Sound_3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn_sound3()
    {
        Sound_3.Play();
        Sound_1.Stop();
        Sound_2.Stop();
    }

}
