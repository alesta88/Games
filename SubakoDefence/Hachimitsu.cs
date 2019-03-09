using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


[RequireComponent(typeof(Text))]
public class Hachimitsu : MonoBehaviour {

    private Text HMText;
    public int HM = 200;
    public enum Status { SUCCESS, FAILURE };



    // Use this for initialization
    void Start () {
        HMText = GetComponent<Text>();
        UpdateDisplay();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void AddHachimitsu(int amount)
    {
        SEManager.Instance.Play(SEManager.SE.HACHIMITSU);
        print(amount);

        HM += amount;
        UpdateDisplay();
    }

    public Status UseHM(int amount)
    {
        if (HM >= amount)
        {
            HM -= amount;
            UpdateDisplay();
            return Status.SUCCESS;
        }
        return Status.FAILURE;
    }

    private void UpdateDisplay()
    {
        HMText.text = HM.ToString();
    }
}
