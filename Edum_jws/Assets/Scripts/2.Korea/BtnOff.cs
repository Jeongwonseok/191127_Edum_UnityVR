using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOff : MonoBehaviour
{
    [SerializeField] AudioSource ad_Instrument;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_Off()
    {
        sound_effect.Play();

        ad_Instrument.volume = 0.0f;
    }
}
