# GDC-G1
GDC-G1
Horror-Puzzle
MIT License
Jacobi Glenn
2023

 1 GDC-G1
1.1 name - quick explanation
 2 Overview
	2.1 Concept.
	2.2 Genre.
	2.3 Target audience.
	2.4 Objectives and goals (in game).
	2.5 Game flow - How the player moves through the game, interface, framing.
	2.6 Look and feel.
	
3 Gameplay and Mechanics
	3.1 Gameplay.
	3.2 Mechanics .
	3.3 Game options .
	3.4 overview (goals).

4 Story, Setting and Characters
	4.1 Story and narrative.
	4.2 Game world.
	4.3 Characters.

5 Environment 
5.1 Level design.
5.2 Environment overview.
5.3 Design Ideas.
5.4 pictures.

6 Interface
	6.1 Visual System. (Hud, menus, cameras, intractable Ui elements).
	6.2 Control system - How the player controls the game/ keybinds.
	6.3 Audio, music, sound effect.
	6.4 Help system.
	
 7 Cutscenes and Content, Replayability 
	7.1 Cutscenes.
	7.2 Cutscene order.
	7.3 Triggers.
	7.4 Unlockables (cutscene specific).
	7.5 Replayability.




~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~



1.
1.1 GDC-G1
This stands for “Game design class-game 1,” I do not have plans to change it and I prefer the simplicity of it.

1.2 Survival horror where an ai chases you as you try to do puzzles and escape.

2. 

	2.1 Game opens with a cutscene (See 7.1.1 for that) then after the cutscene plays you are dropped into a small outpost like half a kilometer away from the house, in this outpost you see a whiteboard or a wall or whatever I can fit in time with a bunch of color cards. Each card is selectable except white. There will also be a book not hung on the whiteboard that explains color meaning and the point of the game. Im hoping to (when we learn blender) model the whiteboard and add each colors goal. For example red is supposed to open this hatch near the back of the house to get into like the basement. So itll have written on the whiteboard that red is gonna open it. I have a picture attached (5.4.1).
	So once you understand what the games goal is you go break into the house and set each character up for success, you must play through each character to unlock the last character. The last character is white, this character must go somewhere to do something, I’m still unsure of how I want this to end. 
	Once the game ends the screen will go black with the time it took you to beat it, I do not think I will be adding the timer for the school final though. Think of it more like a tech demo, with most of the gameplay completed but not all of it. 
	
2.2 Puzzle-Horror with elements of stealth
2.3 The target audience is obviously the game design class, but Im going to try and make it easier to understand for most of them that way its user friendly. Furthermore, I will be uploading it to itch.io and all my code is on github. So there will be a decent amount of people who see the game, which is stressful but I’ll manage. And if that wasn’t enough, this document will also be attached with every version of the game. 

	2.4 Objectives and goals (in game).
2.4.1 Red: The brain, he is good at picking locks. His goal is to open the basement hatch
2.4.2 Blue: 
2.4.3 Green: creating traps, trapping the house for other players to evade enemies.
2.4.4 Black
2.4.5 White:

	2.5 the flow - I want the game to be like the jank hello neighbor esk movement, where you feel like you're walking through mud as you do everything. For a horror game It gives that extra bit of fight that I like. I also want to make everything had hard edges and surfaces (Ui included) to keep the game feeling rigid and off putting	
	
2.6 I like the creepy rain and muddy feel, bringing the game to its roots of castlevania look. The movement has been jumped down a lot to be slower and more sluggish than castlevania but I love the aesthetic and I want to hold that creepy atmosphere that inspired me in the first place.

3.

	3.1 The game is supposed to feel like a portal esk puzzle but spaced out in an entire house, like those escape room iphone games but in a 3d environment with an ai trying to get you. I also love the stealth element of dishonored so the movement is taken huge inspiration from that and I will try and keep the crouching around ai, and distracting with sounds into the game. 

	3.2 As just stated the distracting with sounds is a huge element I want to add, along with the ai not feeling too much like a robot but enough that its a fun twist when you learn the ai is a robot (in the story). I also want to add mounting mechanics so you can crawl through vents and the like, that would be pretty cool.
	      Since each character has different attributes I also want to have a cool way to show that, and to show different characters. I still dont know how though.

	3.3 This is really important to me, Fully customizable keybinds; I love when games have that. And a good amount of movement tek, make slipping on walls or surfing, similar to csgo. Furthermore, ways to mess around with the ai would be cool. In other games there are whistle mechanics so I want to add a button that makes you shout, luring the ai in. It would be useful in some cases and pretty cool. 

	3.4 for now the goal is to get to the attic, though to do that you need to go to the basement to get a key that's locked in a locker and then use the key on a thing that opens the attic stairs. Because trapped in the attic is “white” the final character. And I’m thinking of making some alternate version of the house that you have to run out of. There's a cool part in a roblox game that I want to make a similar version of, kinda like a hallucination for the character? ( https://youtu.be/NoayHjSX3X4?t=15 ). After you finish that I think it's only right if the game ends, though I think I might do the chase scene in the streets, like running away from the ai through a street of busy cars. I do not know how I want to implement this yet. 

4.
 
	4.1 This is going to be a extremely brief overview that I will add too later:
Game opens and you are under a tent outside of a house, automatically selected as white. The rest of the gang is lounging around and you (being the player) cannot switch characters and will eventually approach the house. When you get too close your view will switch to “red” and you will see the ai come out and grab “white,” which prompts the ai to run inside with “white.” This should set up the reasoning for going into the house, save “white.” And later, once you make it to the basement, youll see the ai’s body hung on a wall with robot parts all around, showing you that it's a robot and it can make multiple more of itself (and is trying to!). This will also let me add a second ai into the game later when you further progress the game to make it a little harder. Something ive found with hello neighbor is its really easy to cheese the ai and then just hang out upstairs, so I want to make it a little harder. Afterwards, when you make it to the attic, you’ll be able to save “white” and do the chase scene I talked about in 3.4.

	4.2 I was going to create fleshed out details of the game world but honestly I think i'm just going to (for this demo at least) have an empty void with a house, maybe add a background with houses in a far off distance. I don't really want to waste time on that. The only thing that matters as of now is the main house so I will be focusing on that.

	4.3 there are characters for each color: White, Black, Red, Blue, and Green. They will not be given names and I will leave the entire origin for interpretation, If I get around to adding dialogue while they are lounging I might hint at old memories they have but I like the mystery more.

5.
 
5.1 The entire level will be the 3 story (4 counting the basement) house. There will be a basement with a small underground bunker that is kept secret but I think that keeping it fairly small will be better. I do want to add multiple entrances and windows that you can get in through so the game feels fair and easy but getting to that will take a while.


5.2 I had originally planned to have a small town surrounding but I have decided to dumb down the project to just the single house.

5.3 A lot of stealth games have windows you can go through and lots of entrances so I will be adding that, along with my mantling object mechanic there could be interesting environments made. Since I am not building for looks the game will be a little ugly but I think this will help make the gameplay a lot more fluid and better. Furthermore, I want a lot of intractable objects that you can use to throw off the ai, to keep things interesting.

5.4 Pictures
5.4.1 whiteboard picture with red
5.4.2 base floor models, will add as paintings later.
 
6.

	6.1 Visual System. (Hud, menus, cameras, intractable Ui elements). The hud is going to be extremely basic, not only because it's easy but because I want it to feel like a real person. Even for the inventory I don’t want a menu I think it would be cool to look downward at a toolbelt and select the items from there. 
      I also want to add little versions of color (two cubes) where when you crouch your color cube (CC) will be cut in half, and when you uncrouch your CC will become two cubes again. To show that you are crouching and it also serves as a little reminder of what color you are.

	6.2 Jumping, sneaking, sprinting, shouting, and maybe a zoom feature.

	6.3 Lobby music and chase music are a given, but I'm thinking about footstep sounds for the player and the ai’s. Along with breathing from the player, there's a heartbeat puzzle you have to do in a game every time a monster is nearby to control your heartbeat so the monster cannot hear you. I want to do something similar with breathing too loud, like if you sprint you start breathing heavy and have to control your breathing, and same with hiding in a closet or under a bed. You have a ui element that pops up and you have to play a minigame to not breath too loud so the ai can hear you.
	      I also want to add a loudness meter, kinda like those car radio things and a noise when the ai spots you or hears you. This will make the game feel a lot more fair and I think it would be nice to know as a player. And since I am obsessed with settings elements I will make you be able to turn it off in settings. If I have time, a hard mode with all ui elements off would be cool, but I do not think I will for this project.
	

7.
 
	7.1 Cutscene list
7.1.1 
Opening scene overview: This is also only if I have time for it.
In this scene you get brought about our world. You see a small down and then a house on top of a hill, this house is different from the others. Like, weirdly different. You see our main group of characters, five of them. All color coded. The white character points at the map where there's the house and hill, then it pans to the house. Scene! It opens the story nicely and gives enough information that you understand getting into the house is the objective.

7.1.2
Blue death scene overview: once you reach the basement (only accessible by blue at first) I want to have the ai be down there and catch blue, removing him from playable characters. This will give you a sense of impermanence and will also show the player that every character can die and you won't be able to play as them anymore. Since “blue” doesn’t play a major role I think this will be a good character to remove at first.

	7.2, I do not think I need to add the order.

	7.3 I want to have a lot of invisible triggers hidden from the player in the basement scene and the attic scene, no intractable cutscenes.

	7.4 Unlockables (cutscene specific). There isn’t going to be any unlockables….

	7.5 Replaying the game would be cool, since it's a game design class I doubt people would, but if they do I think it would be cool to have a speedrun timer option, which should also be easy to implement. This will make you race to beat your time. And of course, you can cycle how you use each character, for example, you could theoretically keep “blue” alive the entire game if you just unlock the basement and then never go inside as “blue.” Things like that to spice up gameplay.
       If I have a lot of time, little achievements would be really cool. And a notebook that you can look through how to get them and what they are. 
	      I also would love to add a notepad system, in your notebook you’d be able to write notes on the ai and look back on them. Or even have a little drawing page, I think that would be neat.

	


