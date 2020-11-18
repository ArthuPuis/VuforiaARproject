using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Distance : MonoBehaviour, ITrackableEventHandler
{
    private TrackableBehaviour myTrackableBehaviour;
    public Vector3 delta;
    public bool goIn = false;

    // Use this for initialization
    void Start()
    {
        myTrackableBehaviour = GetComponent<TrackableBehaviour>();
        if (myTrackableBehaviour)
        {
            myTrackableBehaviour.RegisterTrackableEventHandler(this);
        }

    }
    // Update is called once per frame
    void Update()
    {
        if (goIn == true)
            delta = Camera.main.transform.position - myTrackableBehaviour.transform.position;
    }

    public void OnTrackableStateChanged(
        TrackableBehaviour.Status previousStatus,
        TrackableBehaviour.Status newStatus)
    {
        if (newStatus == TrackableBehaviour.Status.DETECTED ||
            newStatus == TrackableBehaviour.Status.TRACKED ||
            newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
        {
            // action to do
            goIn = true;
        }
        else
        {
            goIn = false;
        }
    }
}
