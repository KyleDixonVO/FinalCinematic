using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Trigger : MonoBehaviour
{
    public PlayableDirector Timeline;
    public CharacterController player;
    public Camera playerCam;
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Timeline.Play();
            Destroy(player);
            Destroy(playerCam);
        }
    }
}
