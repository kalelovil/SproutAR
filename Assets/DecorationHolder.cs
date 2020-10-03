using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationHolder : MonoBehaviour
{
    [SerializeField] List<Transform> _decorationSlotList = new List<Transform>();
    [SerializeField] List<GameObject> _decorationList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void AddDecorations(List<GameObject> objs)
    {
        System.Random rand = new System.Random();
        for (int i = 0; i < objs.Count; )
        {
            int slotIndex = rand.Next(_decorationSlotList.Count);
            var obj = _decorationList[slotIndex];
            if (obj == null)
            {
                var slot = _decorationSlotList[slotIndex];
                var gObj = Instantiate(obj, slot);
                _decorationList[slotIndex] = gObj;

                i++;
            }
        }
    }
}
