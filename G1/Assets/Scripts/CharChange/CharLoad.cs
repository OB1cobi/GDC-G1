using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharLoad : MonoBehaviour
{
    public GameObject[] charPrefabs;
    public Transform spawnPoint;
    public TMP_Text label;

    private void Start()
    {
        int selectedchar = PlayerPrefs.GetInt("selectedchar");
        GameObject prefab = charPrefabs[selectedchar];
        GameObject clone = Instantiate(prefab, spawnPoint.position, Quaternion.identity);
        label.text = prefab.name;
    }
}
