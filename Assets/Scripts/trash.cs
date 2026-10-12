using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class trash : MonoBehaviour
{
   
  
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
    void Update()
    {

        
    }
}
