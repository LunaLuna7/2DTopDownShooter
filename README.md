## 2DTopDownShooter

2D Top down shooter scaffold made by VGDC

## Files Included

_Note: Any file in a_ `ScaffoldDevelopment` _sub-folder is for the developers of scaffold.
They may contain experimental, outdated, or broken assets.
If you are making a game using the scaffold, you should not use anything in the folder._ 

### Scenes

* `SampleScene` -
  The most basic scene you can make using the scaffold files.
  Includes a character with all the relevant scripts, and a camera that follows the character.
  It's a good starting point if you are making a game.

### Scripts

_Additional documentation and remarks available in script files_

* `ConstantDamageSource` - 
  Deals a set amount of damage to anything with a `HealthPool` that comes into contact.
  Turn on `persistent` to keep the object after dealing damage.
* `ConstantHealSource` -
  Similar to `ConstantDamageSource`, except that it heals instead of damages and only affects the player.
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

## Files Not Included

Including a mechanic often makes developers use that predefined mechanic, instead of coming up with their own. Therefore, we do not and _will not_ provide:

* Enemy AI
* Weapon mechanics
