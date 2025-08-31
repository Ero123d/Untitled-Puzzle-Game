using UnityEngine;

public class KeyDoorInteraction : MonoBehaviour
{
    public GameObject key;   // assign in inspector
    public GameObject door;  // assign in inspector

    private void OnTriggerEnter(Collider other)
    {
        // If the key touches the door
        if (other.gameObject == key || other.gameObject == door)
        {
            key.SetActive(false);
            door.SetActive(false);
        }
    }
}
