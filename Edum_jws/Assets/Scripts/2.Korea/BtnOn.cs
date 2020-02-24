using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnOn : MonoBehaviour
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

    public void btn_On()
    {
        sound_effect.Play();

        ad_Instrument.volume = 1.0f;
    }
}
