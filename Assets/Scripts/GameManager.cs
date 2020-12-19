using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class GameManager : MonoBehaviour
{
    private AugmentedImageController controller; //AMC Refernce
    public GameObject uiPanel; //UI Panel Reference
    public Button infoButton; //Info Button Reference
   
    void Start()
    {
        controller = GetComponent<AugmentedImageController>();
        SetActive(false);
    }

    //Sets the info of Planet.
    public void SetInfo(Planets planet)
    {
        FindObjectOfType<AudioManager>().Play("Tap");
        infoButton.onClick.RemoveAllListeners();
        controller.planet.GetComponent<PlanetController>().planet = planet;
        infoButton.onClick.AddListener(()=>InfoButtonClick(planet));
    }

    //Sers the UI and also make it active.
    public void InfoButtonClick(Planets planet)
    {
        FindObjectOfType<AudioManager>().Play("Tap");
        SetActive(true);

        #region Setting info
        uiPanel.transform.Find("PlanetName").GetComponent<TextMeshProUGUI>().text = planet.planetName;
        uiPanel.transform.Find("PlanetSize").GetComponent<TextMeshProUGUI>().text = planet.Size.ToString();
        uiPanel.transform.Find("PlanetPlace").GetComponent<TextMeshProUGUI>().text = planet.planetName+" is at "+planet.planetPlace.ToString()+" place in the solar system";
        uiPanel.transform.Find("PlanetMass").GetComponent<TextMeshProUGUI>().text = planet.Mass.ToString();
        uiPanel.transform.Find("Orbital Velocity").GetComponent<TextMeshProUGUI>().text =planet.OrbitalVelocity.ToString()+" km/s";
        uiPanel.transform.Find("NumberofMoons").GetComponent<TextMeshProUGUI>().text =planet.NumberofMoons.ToString();
        uiPanel.transform.Find("Conclusion").GetComponent<TextMeshProUGUI>().text =planet.Conclusion.ToString();
        #endregion

    }

    //Makes the UI active and inactive.
    public void SetActive(bool isactive)
    {
        isactive = uiPanel.activeSelf;
        uiPanel.SetActive(!isactive);
    }
}
