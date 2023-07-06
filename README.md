# OculusIntegration_InteractionSDK_Template

VR Template with the Oculus Integration package on Unity.

https://matthieucoquelin.itch.io/oculusintegration-interactionsdk-template

Version: Unity: 2021.3.11f1 ; 
Oculus Integration (Interaction SDK) V46 (works with actual version: V51);

# How to use 
There is 2 scenes :
- One with hand tracking and controller (the controller is the controller) : MainScene_HandControler 
- The other hand tracking and controller (the controller is the hand) : MainScene_HandControlerAsHand

If you want to create your own project you have to copy pastle the prefab (OculusInteractionSampleRigHandController or OculusInteractionSampleRigHandControllerAsHand dependiing on the scene) AND the gameObject Poses(the poses are created under this gameObject)(the Prefab will works without it but you will not have pose detection).

# Functionalities
For both scenes it is possible 
- for hand and controller :
  - Grab with one hand without pose 
  - Distance Grab with one hand without pose 
  - Grab with one hand with pose 
  - Rotate Grab with one hand without pose 
  - Grab with two hands without pose 
  - Press Big button (buzzer one)
  - Interact with canvas (curved or flat) with ray(pinch detection) or poke(touch canvas)

- for hand only : pose detection 
- for controller only : (locomotion with joystick)
  - left controller : continuous movement 
  - right controller : 
    - up / back  aim teleport and teleport on release with joystick orientation 
    - right / left : rotate 
