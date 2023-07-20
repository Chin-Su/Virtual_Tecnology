using System.Collections;
using System.Collections.Generic;
using System.Xml.Schema;
using UnityEngine;

public class TurnLight : MonoBehaviour
{
    public bool check = true;

    public GameObject[] lightPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
            check = !check;
        foreach (var t in lightPos)
            t.SetActive(check);
    }
}
