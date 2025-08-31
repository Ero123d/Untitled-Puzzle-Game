using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
public class Trigger2 : MonoBehaviour
{
    [SerializeField] PlayableDirector cutScene;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Key2"))
        {
            cutScene.Play();
            
        }
    }
}