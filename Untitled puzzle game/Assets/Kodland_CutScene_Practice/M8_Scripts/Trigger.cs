using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Trigger : MonoBehaviour
{
    [SerializeField] PlayableDirector cutScene;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key"))
        {
            cutScene.Play();
            
        }
    }
}