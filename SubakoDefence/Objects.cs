using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Objects : MonoBehaviour
{
    SpriteRenderer m_SpriteRenderer;
    //The Color to be assigned to the Renderer’s Material
  //  Color myColor;
    

    private Objects[] ObjectsArray;
    public GameObject defenderPrefab;
    public static GameObject selectedDefender;
    // Use this for initialization
    void Start()
    {
        selectedDefender = null;
        ObjectsArray = GameObject.FindObjectsOfType<Objects>();
        GetComponent<SpriteRenderer>().color = Color.grey;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {

        SEManager.Instance.Play(SEManager.SE.CHOOSE);
        //myColor = new Color(0f, 0f, 0f, 0.427451f);
        foreach (Objects thisobject in ObjectsArray)
        {
            
            thisobject.GetComponent<SpriteRenderer>().color = Color.grey;
        }

        GetComponent<SpriteRenderer>().color = Color.white;
        selectedDefender = defenderPrefab;
    }
} 