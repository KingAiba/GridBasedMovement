using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdTestScript : MonoBehaviour
{
    public Dictionary<int, string> birdDict;
    public GameObject birdNamePrefab;
    void Start()
    {
        InitializeBird();
    }

    
    void Update()
    {
        
    }

    public void InitializeBird()
    {
        birdDict = new Dictionary<int, string>();
        birdDict.Add(0, "Auks");
        birdDict.Add(1, "Blackbirds");
        birdDict.Add(2, "Crows");
        birdDict.Add(3, "Doves");
        birdDict.Add(4, "Ducks");
        birdDict.Add(5, "Falcons");
        birdDict.Add(6, "Geese");
        birdDict.Add(7, "Gulls");
        birdDict.Add(8, "Hawks");
        birdDict.Add(9, "Owls");
        birdDict.Add(10, "Ravens");
    }

    public void MakeNameText(GameObject target)
    {
        BirdNameUI bname = Instantiate(birdNamePrefab).GetComponent<BirdNameUI>();
        string nameText = "";
        birdDict.TryGetValue(Random.Range(0, birdDict.Count), out nameText);
        bname.SetTextAndTarget(nameText, target, gameObject);
    }
}
