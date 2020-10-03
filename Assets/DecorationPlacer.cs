using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecorationPlacer : MonoBehaviour
{
    [SerializeField] List<GameObject> _decorationList = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlaceDecorations(int num)
    {
        var decorationHolder = GameObject.FindGameObjectWithTag("MoneyTree").GetComponent<DecorationHolder>();
        System.Random rand = new System.Random();
        List<GameObject> objs = new List<GameObject>();
        for (int i = 0; i < num; i++)
        {
            var obj = _decorationList[rand.Next(_decorationList.Count)];
            objs.Add(obj);
        }
        decorationHolder.AddDecorations(objs);
    }
}
