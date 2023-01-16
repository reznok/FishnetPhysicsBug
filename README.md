# FishnetPhysicsBug

Example project showing a bug on FishNet 3.1.3 affecting client physics when using CSP. Almost everything is default except for TimeManager setting the Physics Mode to Time Manager. The player (red box) has the "Rigidbody Prediction" script that comes with the examples. Green ball is Physics2D, grey ball is Physics3D.

Note that when the player is moving, all physics is processed twice as fast as it should be.

This only happens when running as purely a client.

The extra physics simulations are being run at:
https://github.com/FirstGearGames/FishNet/blob/3e71629e21308351ca568a682faa32cf93425ffb/Assets/FishNet/Runtime/Object/NetworkBehaviour.Prediction.cs#L694

https://user-images.githubusercontent.com/23696484/212630349-9a49e7d0-5808-427c-9f11-debc28be55e1.mp4

