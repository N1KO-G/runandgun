using UnityEngine;
using DG.Tweening;

public class MoveCamera : MonoBehaviour {

    public Transform player;
    
    
    void Update() {
        transform.position = player.transform.position;

        }

  

}
