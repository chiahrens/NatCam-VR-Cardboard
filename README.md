# NatCam-VR-Cardboard
A Google Cardboard VR project using the rear camera preview. Powered by NatCam v1.2.

Spot the spinning cube!

![NatCam VR Example](/NCVR.png?raw=true "")

# Setup Instructions
- Download the Google Cardboard SDK for Unity [here](https://developers.google.com/cardboard/unity/download)
- Import the Cardboard SDK into the project
- Download NatCam 1.2 [here](https://www.assetstore.unity3d.com/en/#!/content/52154) and import it to your project
- Import NatCam 1.2 into the project
- On the main camera, add a StereoController component and click 'Update Stereo Cameras'
- Drag the Canvas under the camera, making it a child of the camera gameObject
- Create an empty gameObject named VRCam
- Add the VRCam component to the VRCam gameObject
- Set the RawImage of the VRCam component to the Preview gameObject under Camera>Canvas
- Set the cube of the VRCam component to the cube in the scene
- Go to Player Settings and make sure Orientation is set to Landscape Left
- Build & Run!
