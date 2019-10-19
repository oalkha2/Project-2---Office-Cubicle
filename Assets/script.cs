using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{

    public Transform particleEffect;

    // Start is called before the first frame update
    void Start()
    {
        particleEffect.GetComponent<ParticleSystem>().enableEmission = false;
    }

    void OnTriggerEnter()
    {
        particleEffect.GetComponent<ParticleSystem>().enableEmission = true;
        StartCoroutine(stopParticles());
    }

    IEnumerator stopParticles()
    {
        yield return new WaitForSeconds(.5f);
        particleEffect.GetComponent<ParticleSystem>().enableEmission = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
