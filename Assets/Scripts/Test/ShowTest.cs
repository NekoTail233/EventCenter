using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShowTest : MonoBehaviour
{
    public void Awake()
    {    
        EventCenter.AddListener<string,string,float,float,int>(eEventType.ShowText, Show);
    
        gameObject.SetActive(false);
    }

    public void OnDestroy()
    {
        EventCenter.RemoveListener<string, string, float, float, int>(eEventType.ShowText, Show);     
    }
    public void Show(string str,string str1,float a,float b,int c)
    {
        gameObject.SetActive(true);
        GetComponent<Text>().text = str+str1+a+b+c;
    }
}
