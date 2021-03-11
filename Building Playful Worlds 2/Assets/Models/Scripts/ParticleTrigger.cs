using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    public GameObject ThePlayer;
    public GameObject Particle;

    void OnTriggerEnter(Collider other)
    {
        Particle.SetActive(true);
        ThePlayer.SetActive(false);
    }
}
