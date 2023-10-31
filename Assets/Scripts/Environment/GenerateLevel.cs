using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public int zPos = 50; //1st place where u generate section
    public bool creatingSection = false;
    public int secNum;

   

    // Update is called once per frame
    void Update()
    {
        if(creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection()); //coroutine == special method 
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3); //between 0 aand 3 sections that weve created 
        Instantiate(section[secNum], new Vector3(0 , 0 , zPos), Quaternion.identity); //telling the script that we r putting a new obj 
        zPos += 50 ; 
        yield return new WaitForSeconds(2);
        creatingSection = false;
    
    }
}
