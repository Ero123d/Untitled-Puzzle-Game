using UnityEngine;

public class KeyPickupRaycast : MonoBehaviour
{
    [Header("References")]
    public Camera playerCamera;   // The player's camera
    public GameObject playerKey;
    
    public GameObject playerKey2;  // The key attached to the player
    public float pickupRange = 3f; // How far you can pick up the key
    public KeyCode pickupKey = KeyCode.E;

    private GameObject currentTarget;

    void Start()
    {
        if (playerKey != null)
            playerKey.SetActive(false); // Hide player's key at start

        if (playerKey2 != null)
            playerKey2.SetActive(false); // Hide player's key at start
    }

    void Update()
    {
        // Raycast from center of screen
        Ray ray = new Ray(playerCamera.transform.position, playerCamera.transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, pickupRange))
        {
            if (hit.collider.CompareTag("Key")) // Make sure your floor key has tag "Key"
            {
                currentTarget = hit.collider.gameObject;

                // Press E to pick up
                if (Input.GetKeyDown(pickupKey))
                {
                    currentTarget.SetActive(false); // Hide floor key
                    if (playerKey != null)
                        playerKey.SetActive(true);  // Show player's key
                }
            }

            if (hit.collider.CompareTag("Key2")) // Make sure your floor key has tag "Key"
                {
                    currentTarget = hit.collider.gameObject;

                    // Press E to pick up
                    if (Input.GetKeyDown(pickupKey))
                    {
                        currentTarget.SetActive(false); // Hide floor key
                        if (playerKey2 != null)
                            playerKey2.SetActive(true);  // Show player's key
                    }
                }
                else
                {
                    currentTarget = null;
                }
        }
        else
        {
            currentTarget = null;
        }
    }
}
