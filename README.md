[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## Devlog

1. Eric Wei, he/him

2. In the MG1 break down activity, I planned my game by separating it into three main parts, player, plants, and the UI. This planning document directly guided how I structured my Unity Scene and how I implemented my scripts. For the Player, my plan listed attributes such as movement, a seed count, and planting actions. In the Unity Scene, the Player GameObject uses the Player script. Player movement is implemented in the Update() method using Input.GetAxis("Horizontal") and Input.GetAxis("vertical"), which matches my original plan to handle WASD movement through continuous input. The movement is applied using _playerTransform.Translate(). Planting is triggered by pressing the space key. When this happens, the PlantSeed() method is called, which uses Instantiate() to create a plant prefab in front of the player. Send counts are tracked using _numSeedLeft and _nuSeedsPlanted. Plants are implemented as a prefab with a sprite and are instantiated when the player plans a seed, which matches the original plan for plant objects. The UI is used by the PlantCountUI script. The Player script calls UpdateSeeds() whenever a seed is planted, updating the text for seeds remaining and seeds planted. This follows my MG1 plan that UI updates should be trigggered by the player's planting action.


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
