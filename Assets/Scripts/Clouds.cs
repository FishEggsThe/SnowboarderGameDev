using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clouds : MonoBehaviour
{
    ParticleSystem cloudEffect;
    // Start is called before the first frame update
    void Start()
    {
        cloudEffect = GetComponent<ParticleSystem>();
        cloudEffect.Simulate(70, true, true, true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
