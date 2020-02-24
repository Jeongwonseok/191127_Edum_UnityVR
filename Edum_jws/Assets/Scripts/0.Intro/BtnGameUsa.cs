using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnGameUsa : MonoBehaviour
{
    [SerializeField] AudioSource sound_effect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Scene_Usa()
    {
        sound_effect.Play();
        SceneManager.LoadScene("1.Usa");
    }
}
