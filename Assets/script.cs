using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public ParticleSystem particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        particleEffect.enableEmission = false;
    }

    void OnCollisionEnter (Collision collision)
    {
        particleEffect.enableEmission = true;
        StartCoroutine(stopParticles());
        print("collided");
    }

    IEnumerator stopParticles()
    {
        yield return new WaitForSeconds(.5f);
        particleEffect.enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
