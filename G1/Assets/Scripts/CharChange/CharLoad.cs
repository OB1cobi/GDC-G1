using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharLoad : MonoBehaviour
{
    public GameObject[] characterPrefabs;
    public Transform SpawnPoint;

    private void Start()
    {
        int selectedChar = PlayerPrefs.GetInt("selectedChar");
        GameObject prefab = characterPrefabs[selectedChar];
        GameObject clone = Instantiate(prefab, SpawnPoint.position, Quaternion.identity);
    }


}
