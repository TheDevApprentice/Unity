using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPerdreVie : MonoBehaviour
{
    Button button;
    PointDeVie pointDeVie;


    void Start()
    {
        button = FindObjectOfType<Button>();
        pointDeVie = FindObjectOfType<PointDeVie>();
        button.onClick.AddListener(GiveDamage); 
    }

    void Update()
    {

    }

    private void GiveDamage()
    {
        pointDeVie.PrendreDegat();
    }
}
