using UnityEngine;

public class MoveSaw : MonoBehaviour {
    [SerializeField] public float positionStartX;
    [SerializeField] public float positionEndX;
    [SerializeField] public float positionStartY;
    [SerializeField] public float positionEndY;


	[SerializeField] public float speed;
    

	void Update() {
		transform.position = Vector3.Lerp (new Vector3(positionStartX,positionStartY,0), new Vector3(positionEndX,positionEndY,0), Mathf.PingPong(Time.time*speed, 1.0f));
	}
}   
