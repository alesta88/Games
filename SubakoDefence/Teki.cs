using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class Teki : MonoBehaviour
{

    private Text HMText;
    private float HM=10, HMCount=10;



    // Use this for initialization
    void Start()
    {
        HM= Spawn.CountEnemy(HMCount) ;
        print(HM);
        HMText = GetComponent<Text>();
        UpdateDisplay();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddHachimitsu(int amount)
    {
        print(amount);

        HM += amount;
        UpdateDisplay();
    }


    private void UpdateDisplay()
    {
        HMText.text = HM.ToString();
    }
}
