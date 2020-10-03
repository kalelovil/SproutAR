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

    public void GrowScale(float destinationFactor)
    {
        var trans = GameObject.FindGameObjectWithTag("MoneyTree").transform;
        Vector3 destinationScale = new Vector3(trans.localScale.x * destinationFactor, 
                                                trans.localScale.y * destinationFactor, 
                                                trans.localScale.z * destinationFactor);
        StartCoroutine(AnimateGrowth(trans, destinationScale, _speed));
    }

    [SerializeField] float _speed;
    private IEnumerator AnimateGrowth(Transform trans, Vector3 destinationScale, float speed)
    {
        while (trans.localScale.x < destinationScale.x || trans.localScale.y < destinationScale.y || trans.localScale.z < destinationScale.z)
        {
            yield return null;
            trans.localScale = Vector3.MoveTowards(trans.localScale, destinationScale, speed * Time.deltaTime);
        }
    }

    private void ChangeScale(float scaleFactor)
    {
        var trans = GameObject.FindGameObjectWithTag("MoneyTree").transform;
        trans.localScale = new Vector3(trans.localScale.x * scaleFactor, trans.localScale.y * scaleFactor, trans.localScale.z * scaleFactor);
    }
}
