using UnityEngine;
using NatCamU;

public class VRCam : UnitygramBase {
	
	[Header("Demo")]
	public Transform cube;
		
	// Use this for initialization
	public override void Start () {
		//Start Unitygram Base
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
		//Spin the cube
		cube.Rotate(0f, 2f, 0f);
	}
}
