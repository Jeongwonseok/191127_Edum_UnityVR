using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnBack_2 : MonoBehaviour
{
    [SerializeField] GameObject UI_Current;
    [SerializeField] GameObject UI_Next;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void btnBack_2()
    {
        UI_Current.SetActive(false);
    }
}
