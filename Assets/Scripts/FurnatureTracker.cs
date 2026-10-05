using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class FurnatureTracker : MonoBehaviour
{
    public Collider ItemCounterTrigger;
    private Collider ItemCollider;
    public List<GameObject> ItemTracker = new List<GameObject>();
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if(!ItemTracker.Contains(other.gameObject))
        {
            ItemTracker.Add(other.gameObject);
            Debug.Log(other.gameObject.name + "ItemAdded");
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(ItemTracker.Contains(other.gameObject))
        { 
            ItemTracker.Remove(other.gameObject);
            Debug.Log(other.gameObject.name + "ItemRemoved");
        }
    }
    void Update()
    {
        if (ItemTracker.Count > 3)
        {
            Debug.Log("TOOMUCH");
        }
       
    }
}
