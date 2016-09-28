using UnityEngine;
using NatCamU;

public class VRCam : UnitygramBase {
	
	[Header("VR Demo")]
	public Transform cube;
	
	// Update is called once per frame
	void Update () {
		//Spin the cube
		cube.Rotate(0f, 2f, 0f);
	}
}
