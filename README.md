# KarioMartWork
 inlämning av kariomart

 ## description of the game and its intended functions.
 I wanted to make a game based on a childhood game of mine which i had in finland where you had a car with a constant force forward with only inputs for turning which made it very hard and super fun.
 So you should have a constant force forward and turn buttons on \[d\] for right turning and \[a\] for left turning, the main goal of this game is to finnish all the levels as fast as possible which means mastering the turning mechanic and not hitting the wall. there are no mesurements of score atm but you will achieve victory once you beat the third level. Each level will focus on certain aspects of driving such as drifting, turning and a normal level for control familiarity
 ## Instructions for a developer
 All the scenes are in use for this project which include, MainMenu which you will start from, Track1 which is the first level, wheel which is the second level centred around drifting, and quickturn which is the third level centred around quick turns. Packages include NewInputSystem, TextMeshPro, and unity librarys such as Unity.SceneManager
 ## Structure of the code
 I used a total of 8 scripts to handle my game The most used beeing the PlayerController which took up the role of a gameManager and playercontroller in 1 as i had lite knowlage of inheriting from other scripts. this script includes movement and speed values aswell as the physics in the form of add.force, and some connections to the checkpoint and lapmanager script to handle the scoring and progress.
 secondly was the scripts mainMenu and pausemenu to handle the UI asspects and to make the scripts more understandable
 later on i added the powerupp and powerupp effects scripts so i would be able to make scriptable objects and to separate the functions. Lastly i added the lapmanager and checkpoint scripts so i had a system of transitioning between levels and a distinct end to each level.
 ## KeyMappings and instructions 
 three button inputs are implemented D for turning right, A for turning left, and Esc for accesing the menu, aswell as use of the mouse for navigating the menu.
 ## insperations
 childhood game - made by my uncle when i was little sadly no name, never published
 [powerup](https://www.youtube.com/watch?v=PkNRPOrtyls&ab_channel=BMo)
 [pauseMenu](https://www.youtube.com/watch?v=JivuXdrIHK0)
 [startMenu](https://www.youtube.com/watch?v=zc8ac_qUXQY)
 [CheckPoint](https://www.youtube.com/watch?v=F1JRy8nFTb4)
 ## UnityVersion
 2022.3.8f1
 ## Project name
 (originaly) KarioMart (Personal name) Car Chaos (Creator) Jonathan Ebsen Mäensivu
