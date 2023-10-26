using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IfCollide : MonoBehaviour
{
    public Text textPanel;

    int counter = 100;

    private void Start()
    {
        textPanel.text = "Столконвений: " + counter.ToString();
    }

    private void OnCollisionEnter(Collision collision)
    {

        counter--;

        textPanel.text = "Столконвений: " +  counter.ToString();
    }
}
