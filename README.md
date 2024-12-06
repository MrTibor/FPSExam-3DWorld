# FPSExam-3DWorld
 FPSExam-3DWorld


Programmering af interaktive 3D verdener (MED3)
Project name: FPSExam
Name: Tibor Stanisavic
Student number: 20233919
Link to Github project: https://github.com/MrTibor/FPSExam-3DWorld
Overview of the idea and project parts
My concept was to create an FPS game based on my childhood nostalgia for classic PC games such as Counter-Strike: Source, Call of Duty: Modern Warfare 1 and 2, Halo, and Battlefield. I wanted to recreate the feeling of playing those games, but I also wanted to learn how to make an FPS game and implement the elements of guns, bullets and an enemy. I wanted to understand how these implementations are made together to ultimately make an FPS game. This idea led me to make a simple FPS game with shooting mechanics.

Main elements of the game are: 
•	GameManager: The GameManager code handles some of the game events like when the player dies and then he can respawn again. This helps with the flow of the gameplay, because then the player can get right into the gameplay again. It also handles the cursor locking, so the player does not see the mouse cursor when playing the game.

•	Player: The PlayerMove script controls the player character. The player can walk, sprint, jump, with proper gravity to give them a “realistic” feeling when playing. The Unity CharacterController allows the player to move easily to avoid any collisions. The player’s camera follows the mouse of the player to enable them to aim and to experience first-person view by having the camera attached to the player character. The UI will inform the player about their health, so they are always updated on their health.

•	Shooting: Shooting is one of the crucial mechanics in an FPS game and in this game the bullets are controlled by the Bullet script. These bullets fly a fixed distance and if they hit something, then they are destroyed afterwards. The player and enemies both shoots, but the player shoots with mouse click, while the enemies shoot by position and angle of the player. Raycasting is used and it is a mechanism that allows the game to detect if it hits something. This shooting mechanic help create a good FPS environment.


•	Enemies: Enemies in the game follow the player with Unity’s NavMeshAgent, where they navigate around objects and to the player. Once they are in a certain distance, the enemies stop to avoid them being too close to the player. This AI navigation allows the enemy to seem more “realistic” and will keep the player focused throughout the game. 

•	Health: Health is also a crucial aspect of an FPS game. PlayerHealth script is responsible for handling health of the player and if the player gets shot, then the player health UI will indicate to the player what their health is at. EnemyHealth script handles the health of the enemies and if their health gets below zero, then they will get destroyed.


Project part:
Scripts and short description:
•	Camera: Makes the camera follow in time with the player and rotate accordingly to the player’s position.
•	Bullet: Handles the behavior of the bullets like speed, duration and collision with enemies or the player.
•	EnemyMove: Handles the enemies’ movement by using Unity’s NavMeshAgent to follow the player and when to stop, depending on the player’s position.
•	EnemyHealth: Tracks enemy health and applying damage when hit and destroys the enemy object when health reaches zero.
•	GameManager: Manages overall game events like player death, restarting, and locking the cursor.
•	PlayerMove: Controls player movement, which includes movement like sprinting, jumping and shooting. It uses Unity's CharacterController for navigation and for the camera.
•	PlayerHealth: Manages the health of the player, handles the damage taken, refreshes the UI and handles player death through the GameManager.
•	UI: Handles player health with UI, by dragging the UI slider to show the current health text.

Time schedule and references of the project parts
Task	Hours estimated
Setting everything up/Grayboxing	2
Player	5
Enemy/AI Navigation	5
Health system	2
Starting over because of an unknown mistake	8

*The "starting over due to an unknown mistake" section refers to my first attempt at making this game. I was halfway through implementing, and during this attempt to improve some shooting mechanics, I encountered an unexpected problem. The enemy would perform the shooting animation, and I could see that I was taking damage, but no bullets were visible. Something I had changed had broken this functionality. Despite my troubleshooting efforts, I could not pinpoint the exact cause, so I ultimately decided that starting over was the best option.
References:
•	Enemy character sprites: https://assetstore.unity.com/packages/3d/characters/humanoids/sci-fi/free-test-character-asuna-205897
•	Crosshair: https://assetstore.unity.com/packages/2d/gui/icons/too-many-crosshairs-126069
•	Weapons: https://assetstore.unity.com/packages/3d/props/guns/low-poly-weapons-vol-1-151980
•	Bullets: https://assetstore.unity.com/packages/3d/props/guns/low-poly-fps-weapons-lite-245929
•	YouTube link 1: https://www.youtube.com/watch?v=FBaZzKo3WIo&list=PLNJa45y8I5bASU_L8ehoMghLdxzYvPY2H
•	YouTube link 2: https://www.youtube.com/watch?v=rJqP5EesxLk&list=PLGUw8UNswJEOv8c5ZcoHarbON6mIEUFBC
•	YouTube link 3: https://www.youtube.com/watch?v=THnivyG0Mvo&list=PLPV2KyIb3jR7dFbE2UQYu7QWMdUgDnlnk
•	Github link for inspiration: https://github.com/spatialos/gdk-for-unity-fps-starter-project


Link to the Unity project files
•	https://github.com/MrTibor/FPSExam-3DWorld
