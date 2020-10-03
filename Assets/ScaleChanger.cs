using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DecreaseScale()
    {
        float scaleFactor = 0.9f;
        ChangeScale(scaleFactor);
    }

    public void IncreaseScale()
    {
        float scaleFactor = 1.125f;
        ChangeScale(scaleFactor);
    }

    private void ChangeScale(float scaleFactor)
    {
        var trans = GameObject.FindGameObjectWithTag("MoneyTree").transform;
        trans.localScale = new Vector3(trans.localScale.x * scaleFactor, trans.localScale.y * scaleFactor, trans.localScale.z * scaleFactor);
    }
}
