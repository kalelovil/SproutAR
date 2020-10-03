using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationHolder : MonoBehaviour
{
    [SerializeField] List<Transform> _decorationSlotList = new List<Transform>();
    [SerializeField] List<GameObject> _decorationList = new List<GameObject>();

    [SerializeField] Renderer StemRend;
    [SerializeField] Renderer LeavesRend;

    // Start is called before the first frame update
    void Start()
    {
        _decorationList = new List<GameObject>();
        foreach (var slot in _decorationSlotList)
        {
            _decorationList.Add(null);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void AddDecorations(List<GameObject> objs)
    {
        System.Random rand = new System.Random();
        for (int i = 0, timeOut = 0; i < objs.Count && timeOut < 1000; timeOut++)
        {
            int slotIndex = rand.Next(_decorationSlotList.Count);
            var obj = _decorationList[slotIndex];
            if (obj == null)
            {
                var slot = _decorationSlotList[slotIndex];
                var gObj = Instantiate(objs[i], slot);
                _decorationList[slotIndex] = gObj;

                i++;
            }
        }
    }
}
