using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefSpawn : MonoBehaviour {


    public Camera myCamera;
    private GameObject parent;

    private Hachimitsu hachimitsu;

    void Start()
    {
        parent = GameObject.Find("Defenders");
        hachimitsu = GameObject.FindObjectOfType<Hachimitsu>();

     
    }

    void OnMouseDown()
    {
        Vector2 rawPos = CalculateWorldPointOfMouseClick();
        Vector2 roundedPos = SnapToGrid(rawPos);
        GameObject defender = Objects.selectedDefender;

        int defenderCost = defender.GetComponent<Defender>().HMCost;
       /// print("       !!!!!!        "+defenderCost);
        if (hachimitsu.UseHM(defenderCost) == Hachimitsu.Status.SUCCESS)
        {
            SEManager.Instance.Play(SEManager.SE.STAND);
            SpawnDefender(roundedPos, defender);
        }
        else
        {
            Debug.Log("Insufficient stars to spawn");
        }
    }

    void SpawnDefender(Vector2 roundedPos, GameObject defender)
    {
        Quaternion zeroRot = Quaternion.identity;
        GameObject newDef = Instantiate(defender, roundedPos, zeroRot) as GameObject;
        newDef.transform.parent = parent.transform;
    }

    Vector2 SnapToGrid(Vector2 rawWorldPos)
    {
        float newX = Mathf.RoundToInt(rawWorldPos.x);
        float newY = Mathf.RoundToInt(rawWorldPos.y);
        return new Vector2(newX, newY);
    }

    Vector2 CalculateWorldPointOfMouseClick()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;
        float distanceFromCamera = 10f;

        Vector3 weirdTriplet = new Vector3(mouseX, mouseY, distanceFromCamera);
        Vector2 worldPos = myCamera.ScreenToWorldPoint(weirdTriplet);

        return worldPos;
    }
}
