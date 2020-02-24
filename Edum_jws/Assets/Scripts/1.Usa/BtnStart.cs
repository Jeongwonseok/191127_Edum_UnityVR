using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnStart : MonoBehaviour
{
    [SerializeField] GameObject UI_Start;
    [SerializeField] GameObject Go_Desk;

    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btn_Start()
    {
        sound_effect.Play();

        Destroy(UI_Start);
        Destroy(Go_Desk);
    }
}
