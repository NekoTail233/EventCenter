using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BtnOnClick : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Button>().onClick.AddListener (() => {
            EventCenter.Broadcast(eEventType.ShowText,"你好","你好呀",1.7f,1.8f,2);
        });
    }
}
