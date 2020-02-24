using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Btn_Sound2 : MonoBehaviour
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

    public void Btn_sound2()
    {
        Sound_1.Stop();
        Sound_2.Play();
    }

}
