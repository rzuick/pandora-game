# Pandora: A 2D Folktale RPG

![The word Pandora is on top of a background of a sunset over a grassy plain](/Pandora/Assets/Art/pandora.png)

## What It Is
Pandora is a narrative 2D RPG that allows you to walk through a popular folktale as the protagonist, ultimately deciding the protagnist's fate in this retelling. 

The first version of this game is based on Mufaro's Beautiful Daughters by John Steptoe. In that tale, a man named Mufaro has two beautiful daughters, Nyasha and Manyara. Where Nyasha is kind and considerate, Manyara is considered to be a bully and bad-tempered. When the king announces he is looking for the most beautiful woman in the kingdom to be his queen, Mufaro decides to send both of his daughters. Along the way, each daughter is presented with the same challenge, though they handle it in vastly different ways.

## Dependencies Used
1. Unity Game Engine
2. C# 
2. TextMeshPro and TextMeshProUGUI
3. Ink Unity Integration
4. Inkle Scripting Language

## Accessing the Game
Simply visit itch.io

## My Approach
I wanted this story to be easily played by one person. So, instead of creating two playable characters, I created one. The difference in how the story played out would come from the choices the player made. 

The first thing I knew was that I wanted this game to have a nostalgic feel to it, so I decided that 2D would be better than 3D for me. I decided on using the Unity game engine because it has plenty of tutorials for those new to game development and new to C#. Upon further research I also decided to use Inkle, the scripting language, to handle some of the logic of my branching narration. 

After creating a storyboard, I began working on my first scene, the Game. This involved me creating a game object for my Player character and the beginning of my C# learning by way of a basic movement script for this game object. From there it was a matter of branching out and building my game world around my character. This included creating a camera that followed the Player game object, a setting the Player would interact with, and eventually more NPCs that would trigger the dialogue and thus the story progression.

## Challenges
One challenge I faced early on was configuring my setting/the basic background layer that would be much of the visual the player saw when they played the game. Unity has a grid component and a tile palette that ties into this. However, I struggled for too many days trying to get the tile palette to display my tile assets the way I wanted it to. I realize now why I struggled, but to avoid wasting more time, I went about creating my background in a different way. I placed my assets directly into my game scene and edited them from there. 

Another challenge I faced was with collisions in my game and making sure that, not only did my collisions work, but that they also worked in two parts: to trigger the visual cue for my dialogue when Player was near a character with dialogue and to prevent Player from walking through everything. After many tutorials, troubleshooting with classmates, and documentation reading, Unity has great documentation by the way, I was able to correct the issue I had with both my 2D Rigidbody component and 2D Collision components.

The final challenge I had was tracking state, specifically to trigger the necessary scene changes in the game. I was able to do more research into C# and came upon a solution that, while it works for this game, is something I would refactor for any sort of expansion to the game. I'm currently using booleans that I track from multiple game objects and use those to determine when to trigger a scene change or transition. However, in the future I would like to use Unity's Event System to track and manage state variables and changes.

## Takeaways
Overall, this was a great learning experience for me. I accomplished much more in 3 weeks than I thought I could. Further, I discovered that learning a new language in the middle of a project is not impossible, but there are probably better ways to go about it than diving headfirst. 

In the future, pre-planning will be of the utmost importance. I also see myself diving more into the Inkle scripting language as there are many more amazing features of it, such as variables, state tracking, etc, that I can use to create a well-rounded story. 
