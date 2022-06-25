# Speedy_Plane
This is a game project inspired by flappy birds. Move through obstacles and increase your score and beat your previous score

## How the game was created
* Player(plane) was added to the game scene
* Background and ground(2D) was later added to the game scene
* Player script was created, attached to the player for player movement
* Obstacle script was created and attached to the obstacle for obstacle movement
* created a prefab(made the obstacle a prefab)
* Added tags to player,ground and prefab
* Spawner script was created,attached to spawner in the hierarchy and the prefab was dragged into it to control the spawn rate of the obstacle
* A score text,game over image, play_button image and finally a highscore text was added to the Game manager in the hierarchy
* Finally a game manager script was created to control most of what happens in the game scene.eg. increasing scores,paying and restarting game etc.
