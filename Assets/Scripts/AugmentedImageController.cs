using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleARCore;
using UnityEngine.UI;

public class AugmentedImageController : MonoBehaviour
{
    private List<AugmentedImage> images = new List<AugmentedImage>(); //List Having Augmented images detected.
    private Dictionary<string, GameObject> map = new Dictionary<string, GameObject>(); //Dictionary for mapping.
    public GameObject planet; //Planet to be instantiated.
    private GameObject go; //Spawnned planet for reference.

    void Update()
    {
        //If not tracking
        if(Session.Status!=SessionStatus.Tracking)
        {
            return;
        }
        //If tracking
        else
        {
            Session.GetTrackables<AugmentedImage>(images, TrackableQueryFilter.All);
            //Traversing the detected images.
            foreach (AugmentedImage img in images)
            {
                if (!map.ContainsKey(img.Name))
                {
                    Anchor anchor = img.CreateAnchor(img.CenterPose);
                    go = Instantiate(planet, anchor.transform.position, Quaternion.identity);
                    go.GetComponent<PlanetController>().planet = planet.GetComponent<PlanetController>().planet;
                    go.transform.parent = anchor.transform;
                    map.Add(img.Name, go);
                }
                else
                {
                    go.GetComponent<PlanetController>().planet = planet.GetComponent<PlanetController>().planet;
                }
            }
        }
    }
}
