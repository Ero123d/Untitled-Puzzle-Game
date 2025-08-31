using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Fox_Save : MonoBehaviour
{
        [SerializeField] TMP_Text saveWarning;
    // Start is called before the first frame update
    public void SavePosition(Vector3 playerPos)
    {
        PlayerPrefs.SetFloat("posX", playerPos.x);
        PlayerPrefs.SetFloat("posY", playerPos.y);
        PlayerPrefs.SetFloat("posZ", playerPos.z);
        PlayerPrefs.Save();

        saveWarning.text = "Kayıt Başarılı!";
        Invoke(nameof(DeleteText), 2f);
    }
    public void DeleteText()
    {
        saveWarning.text = "";
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 pos = other.transform.position;
            SavePosition(pos);
        }
    }
}