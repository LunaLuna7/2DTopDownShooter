## 2DTopDownShooter

2D Top down shooter scaffold made by VGDC

## Included Files

Any file in `ScaffoldDevelopment` sub-folder is for the developers of scaffold.
If you are making a game using the scaffold, you should not use anything in the folder. 

### Scenes

* `SampleScene` -
  The most basic scene you can make using the scaffold files.
  Includes a character with all the relevant scripts, and a camera that follows the character.
  It's a good starting point if you are making a game.

### Scripts

_Additional documentation and remarks available in script files_

* `FollowTarget` -
  Makes the game object maintain a constant offset with respect to another game object.
  Useful for making the camera follow the player.
* `HealthPool` - 
  Generic health script that can be used for both the player and enemies.
* `PlayerMovement` - 
  Controls player movement. Optional tank control can be enabled by the `relative` flag.
* `PlayerRotation` - 
  Controls player rotation so that the player always faces the cursor.
  
### Sprites

* `Ninja` - 
  The placeholder character image.
