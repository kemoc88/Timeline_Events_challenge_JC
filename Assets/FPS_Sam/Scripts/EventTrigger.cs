using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class EventTrigger : MonoBehaviour
{
    public GameObject CutScene;

    private void OnTriggerEnter(Collider other)
    {
        PlayableDirector pd = CutScene.GetComponent<PlayableDirector>();
        if (pd != null)
        {
            pd.Play();
        }
    }

}
