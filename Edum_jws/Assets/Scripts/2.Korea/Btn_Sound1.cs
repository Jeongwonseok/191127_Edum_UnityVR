using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Sound1 : MonoBehaviour
{
    [SerializeField] AudioSource Sound_1;
    [SerializeField] AudioSource Sound_2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Btn_sound1()
    {
        Sound_2.Stop();
        Sound_1.Play();
    }
}
