using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    public Text distanceLabel;

    public void SetValues(float distanceTraveled)
    {
        distanceLabel.text = ((int)(distanceTraveled * 10f)).ToString();
       // velocityLabel.text = ((int)(velocity * 10f)).ToString();
    }
}