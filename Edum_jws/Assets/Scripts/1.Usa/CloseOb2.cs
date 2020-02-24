using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseOb2 : MonoBehaviour
{
    [SerializeField] GameObject go_object; // Bass 오브젝트
    [SerializeField] GameObject Player; // 플레이어
    [SerializeField] GameObject Btn_UI_Desc; // canvas 오브젝트


    // 거리 지정 범위
    [SerializeField] float closeDistance;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 offset = go_object.transform.position - Player.transform.position;
        float currentDistance = offset.sqrMagnitude;

        if (currentDistance < closeDistance * closeDistance)
        {
            Btn_UI_Desc.SetActive(true);
        }
        else
        {
            Btn_UI_Desc.SetActive(false);
        }
    }
}