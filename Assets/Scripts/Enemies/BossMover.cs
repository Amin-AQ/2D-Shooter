using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMover : MonoBehaviour
{
    public float motionMagnitude = 0.10f;

    // Start is called before the first frame update
  /*  void Start()
    {
        
    }*/

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector2.up * Mathf.Cos(Time.timeSinceLevelLoad) * motionMagnitude);
    }
}
