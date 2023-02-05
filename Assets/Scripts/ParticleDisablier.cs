using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleDisablier : MonoBehaviour
{
    public ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        fire.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
