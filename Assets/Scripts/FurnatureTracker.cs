using NUnit.Framework;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FurnatureTracker : MonoBehaviour
{
    public Collider ItemCounterTrigger;
    private Collider ItemCollider;
    public TextMeshProUGUI ScoreText;
    public List<GameObject> ItemTracker = new List<GameObject>();
   


    public float score;
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if(!ItemTracker.Contains(other.gameObject))
        {
            ItemTracker.Add(other.gameObject);
            Debug.Log(other.gameObject.name + "ItemAdded");
            value valueNum = other.gameObject.GetComponent<value>();
           
            if (valueNum != null)
            {
                score = score + valueNum.Value;
            }
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if(ItemTracker.Contains(other.gameObject))
        { 
            ItemTracker.Remove(other.gameObject);
            Debug.Log(other.gameObject.name + "ItemRemoved");
            value valueNum = other.gameObject.GetComponent<value>();
            if (valueNum != null)
            {
                //object value = Score.I.AddScore(2);
                score = score - valueNum.Value;
            }
        }
    }
    void Update()
    {
        ScoreText.text = "Score:" + "\n" + score;
        //if (ItemTracker.Count > 40)
        //{
        //    Debug.Log("TOOMUCH");
        //}
        //if (ItemTracker.Count < 40)
        //{
        //    Debug.Log("NOT ENOUGH");
        //}
       

    }
}
