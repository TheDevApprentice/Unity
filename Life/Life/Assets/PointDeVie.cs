using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointDeVie : MonoBehaviour
{
    int life = 5;

    PointDeVie pointDeVie;

    public delegate void OnVariableChangeDelegate(int newValueLife);

    public event OnVariableChangeDelegate OnLifeChange;

    public int Life
    {
        get => life;
        set
        {
            life = value;
            if (OnLifeChange != null)
            {
                OnLifeChange(life);
            }
        }
    }

    void Start()
    {
        pointDeVie = FindObjectOfType<PointDeVie>();
    }

    void Update()
    {

    }

    public void PrendreDegat()
    {
        Life -= 10;
    }
}
