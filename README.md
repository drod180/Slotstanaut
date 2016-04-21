# Slotstanaut

Slotstanaut is an avoider style mobile game developed in [Unity](https://unity3d.com/unity) with scripts built in C#. The controls were designed to be simple and intuitive for a mobile devices. By simply pressing anywhere on the screen your ship will propel away from the planet, however it will always start to fall back towards the planet so keep pressing the screen to "bounce" around the planet. Make sure to avoid the meteors as long as possible since each one that hits the planet gives you one more point!

Dodge some dogs at [Cat Chase](http://www.drodriguez.io/cat_chase/)

###Start Screen:

![instructions]

###Game View:

![gameplay]


###Technical Details:
* Slotstanaut relies heavily on Unity's [scripting API](http://docs.unity3d.com/ScriptReference/) for most of the game logic. One of the most crucial aspects of the game is a fluid and predictable ship movement. To achieve this the orbit is handled through some simple trig:

```
	float xPos = Mathf.Sin (timeValue * circleSpeed) * circleSize;
	float yPos = Mathf.Cos (timeValue * circleSpeed) * circleSize;
```
With the player having control over changing the distance from the planet:
```
void launch(){
	inputTimeDif = time - inputTime;

	//If recent enough since button press increase distance from planet
	if (thrustTime > inputTimeDif){
		playerShip.circleSize += thrusterPower * Time.deltaTime *(thrustTime - inputTimeDif);
	}
	//If long enough time since button press decrease distance at a faster rate
	else {
		playerShip.circleSize -= playerShip.circleShrinkSpeed * Time.deltaTime * (inputTimeDif * inputTimeDif);
	}
}
```

[instructions]: ./img/home-page.png
[gameplay]: ./img/game-play.png
