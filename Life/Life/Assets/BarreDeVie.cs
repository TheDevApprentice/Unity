using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarreDeVie : MonoBehaviour
{
    PointDeVie pointDeVie; 
    // Start is called before the first frame update
    void Start()
    {
        pointDeVie = FindObjectOfType<PointDeVie>();
        pointDeVie.OnLifeChange += OnLifeChangeLogic;
    }

    private void OnLifeChangeLogic(int newValueLife)
    {
        gameObject
            .transform
            .localScale = new Vector3(newValueLife/100.0f, 1,1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
