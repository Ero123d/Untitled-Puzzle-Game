using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox_Coin : MonoBehaviour
{
    Fox_Logic fox_Logic;
      public string objName;
    public bool isTaken;
    // Start is called before the first frame update
    void Start()
    {
        fox_Logic = FindObjectOfType<Fox_Logic>();

        if (PlayerPrefs.HasKey(objName))
        {
            isTaken = PlayerPrefs.GetInt(objName) == 1;
            gameObject.SetActive(!isTaken);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isTaken = true;
            PlayerPrefs.SetInt(objName, 1);
            gameObject.SetActive(false);
            int value = PlayerPrefs.GetInt("Coins", 0);
            PlayerPrefs.SetInt("Coins", value + 1);
            fox_Logic.GetCoin();
        }
    }
}
