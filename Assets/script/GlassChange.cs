using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

public class BodyTrackingManager : MonoBehaviour
{
    public Text t;
    public ARHumanBodyManager humanBodyManager;
    public GameObject humanBodyPrefab;

    private void OnEnable()
    {
        humanBodyManager.humanBodiesChanged += OnHumanBodiesChanged;
        t.text="detected";
    }

    private void OnDisable()
    {
        humanBodyManager.humanBodiesChanged -= OnHumanBodiesChanged;
           t.text=" not detected";
    }

    private void OnHumanBodiesChanged(ARHumanBodiesChangedEventArgs args)
    {
        // Handle added bodies
        foreach (var body in args.added)
        {
            if (body.trackingState == TrackingState.Tracking)
            {
                var instance = Instantiate(humanBodyPrefab, body.transform.position, body.transform.rotation);
                instance.transform.parent = body.transform; // Attach to body
            }
        }

        // Handle updated bodies (update positions if necessary)
        foreach (var body in args.updated)
        {
            if (body.trackingState == TrackingState.Tracking)
            {
                // Update the position of the existing prefab
            }
        }

        // Handle removed bodies (clean up)
        foreach (var body in args.removed)
        {
            // Destroy or hide the associated prefab
        }
    }
}