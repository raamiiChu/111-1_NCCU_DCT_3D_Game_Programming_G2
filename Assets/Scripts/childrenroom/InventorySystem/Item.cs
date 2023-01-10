using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "New Item",menuName = "Item/Create New Item")]

public class Item : ScriptableObject
{

    public int id;
    public string itemName;
    public int value;
    public Sprite icon;
    public GameObject model;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
