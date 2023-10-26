using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetButton : MonoBehaviour
{
    public GameObject gameObject;
    private int afaf;

    public void SetState() 
    {
        gameObject.SetActive(!gameObject.activeInHierarchy);
    }

}
