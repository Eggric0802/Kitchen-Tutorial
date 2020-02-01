using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleController : MonoBehaviour
{
    public ParticleSystem particleLauncger;
    public bool isTriggered;

    // Start is called before the first frame update
    void Start()
    {
        isTriggered = false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(isTriggered);
        if(isTriggered)
        {
            particleLauncger.Emit(1);
        }
    }
}
