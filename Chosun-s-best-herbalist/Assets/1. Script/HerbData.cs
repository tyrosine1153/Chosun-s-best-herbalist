using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class HerbData : MonoBehaviour
{
    public int herbId;

    private void Start()
    {
        herbId = Random.Range(1, 4);
        //Debug.Log(herbId);
    }
}
