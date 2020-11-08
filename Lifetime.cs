using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lifetime : MonoBehaviour
{
    public float TimeToLive = 2f;
    private void Start()
     {
         Destroy(gameObject, TimeToLive);
     }
}
