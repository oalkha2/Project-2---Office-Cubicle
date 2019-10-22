

# Project 2 Summary
This project was created by Omar Al-Khatib and James Trinh for CS 428 (Augmented and Virtual Reality) at the University of Illinois in Chicago. This started as a blank office with VRTK incorporated in it, and then each group member were to pick a cubicle and decorate them.

<img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/Main%20Picture.jpg" width="600">

## Git Page
https://github.com/oalkha2/Project-2---Office-Cubicle

## Video Demo
[Youtube Link](https://www.youtube.com/watch?v=9Lofo5TFO-0)

## How to use
**Loading & running the project:**
1. Clone from git to an empty folder.  
  1a. git clone https://github.com/oalkha2/Project-2---Office-Cubicle
2. Clone VRTK in a seperate folder using the following commands  
  2a. git clone --recurse-submodules https://github.com/ExtendRealityLtd/VRTK.git  
  2b. cd VRTK/  
  2c. git checkout 29d098ce511e9c18a189327b74029b193d6011a9  
  2d. git submodule init && git submodule update  
3. Move VRTK folder into Assets folder of main project
4. Start up Unity Hub and add the project folder from the previous step to it.
5. Set the version to 2019.2.8f1
6. Launch the project
7. Decide whether you have your own VR or use a simulated one.
  a. **Simulated rig**: Skip to step 8
  b. **VR Device**: On the lefthand Hierarchy chart, click on *UnityXRCameraRig* and toggle the checkbox on the righthand side towards to top left of the textbox with *UnityXRCameraRig* in it.
8. Run the project with the play button.

**What you can do in the project**
* Most objects are grabbable to be picked up.
* Near the starting area, are Red and Blue rectangles.
  * Upon touching the red rectangle, The player will be shrunk to a smaller scale.
  * Upon touching the upper blue rectangle, the player will become englarged. This can be reversed by touching the red rectangle floating on the perimeter of the play area.
  * Upon touching the lower blue rectangle, the player will be reverted back to normal size.
* Within the cubible with the disco light:
  * The disco light can be toggled by touching the white button on the yellow wall.
  * Touching the red sculpture, the briefcase, or the keyboard will emit a noise.
  * Upon touching the white blob under the left table, it will jump up.
  * The boombox can cycle through 3 music and an off state by gently touching the red button.
* The cubicle with Kirby (pink plush) on the top:
  * Grabbing the box will emit a sound and moving it will reveal a hidden model under it
  * Touching the TV will turn it on
  * Grabbing the sword or piggy bank will play a sound
  * Touching kirby, the tablet or Snake will cause a sound to play
  * Grabbing the floor cheese will make a mouse appear *(spooky!)*

## Source Materials
Below is a table of all the sources we use for codes, models, and audios.

### Source Codes

| Description  | Link                                                                           |
| ------------ | ------------------------------------------------------------------------------ |
| Transform    | [Unity Documentation](https://docs.unity3d.com/ScriptReference/Transform.html) |
| Velocity for jumping object     | [Unity Documentation](https://docs.unity3d.com/ScriptReference/Rigidbody-velocity.html) |

### Model List
<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/J%20Cubible%201.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 1.      | Boombox - Made by James T. | |
| 2.      | Steam Controller - [Steam VR](https://store.steampowered.com/app/250820/SteamVR/) |
| 3.      | Pen - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 4.      | Phone - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 5.      | Monitor - Made by James |
| 6.      | Keyboard - [TurboSquid.com](https://www.turbosquid.com/3d-models/3d-keyboard-1383482) |
| 7.      | Laptop - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 8.      | Briefcase - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 9.      | Red Sculpture - made by James T.|

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/J%20Cubible%202.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 10.      | Basketballhoop - made by James T. |
| 11.      | Umbrella - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 12.      | Sculpted Ghost - made by James T. |
| 13.      | Portal Dice - [TurboSquid.com](https://www.turbosquid.com/3d-models/free-portal-2-cube-dice-3d-model/1116423) |
| 14.      | Jojo Arrows - [SketchFab](https://sketchfab.com/3d-models/stand-arrow-jojos-bizarre-adventure-b53212fb380d40678dd15475f9dd57f7  )|
| 15.      | Miniature Soldier - [Thingiverse](https://www.thingiverse.com/thing:1244599) |
| 16.      | Miniature Table - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453) |
| 17.      | d20 Dice - [SketchFab]https://sketchfab.com/3d-models/d20-dice-full-3d-free-2587a1630a3a4c0993032675a25d72b9) |
| 18.      | Miniature Dwarf - [Thingiverse](https://www.thingiverse.com/thing:1244599) |

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/J%20Cubible%203.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 19.      | Plant - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 20.      | Pot for Plant - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 21.      | Spot Light - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453) |
| 22.      | Spot Light - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453) |
| 23.      | Empty Shelf - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 24.      | Office Chair - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/J%20Cubible%204.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 25.      | Disco - made by James T. |

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/O%20Cubicle%201.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 26.      | Cage - Made by Omar A. |
| 27.      | Cardinal - [Unity Asset Store](https://assetstore.unity.com/packages/3d/characters/animals/living-birds-15649) |
| 28.      | Drawers - Made by Omar A. |
| 39.      | TV - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/electronics/wall-tvset-8468) |
| 30.      | White Chair - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/furniture/chair-fp-01-26466) |
| 31.      | Sword - Made by Omar A. |
| 32.      | Shield - Made by Omar A. |
| 34.      | One Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 35.      | Two Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 36.      | Three Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 37.      | Grandpa - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 37.     | Four Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 38.     | Five Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 39.     | Six Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 40.     | Seven Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 41.      | Kirby - [3D Warehouse](https://3dwarehouse.sketchup.com/model/90ad4aaab761cf36b05dd68c192eab4a/Kirby) |


<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/O%20Cubicle%202.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 42.      | Origami Crane - [3D Warehouse](https://3dwarehouse.sketchup.com/model/1f0ae3c915999f5fe09b64fbc3223102/Origami-crane) |
| 43.      | Gum Stick - [3D Warehouse](https://3dwarehouse.sketchup.com/model/a7d8fb085a8d91ce70b0ba4039b032ea/Gum) |
| 44.      | Rat - [3D Warehouse](https://3dwarehouse.sketchup.com/model/u1c56b8a7-e927-419f-83b2-7b10d5b27b00/Rat) |

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/O%20Cubicle%203.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 45.      | Piggy Bank - [3D Warehouse](https://3dwarehouse.sketchup.com/model/c3281ec2d23523e1c40386bdd72f9a0/Piggy-Bank) |
| 46.      | Box - [3D Warehouse](https://3dwarehouse.sketchup.com/model/8ae844c2d0ddbf3452366c3503f802d0/box-a) |
| 47.      | Solid Snake - [3D Warehouse](https://3dwarehouse.sketchup.com/model/df05df84e071c379f16675b77b860cd6/Solid-Snake) |

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/O%20Cubicle%204.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 48.      | Death Star - [3D Warehouse](https://3dwarehouse.sketchup.com/model/8f9066c4d0b98407ca292cf40513efe4/Death-Star) |

<p float="center">
  <img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/docs/O%20Cubicle%205.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 49.      | Lego Brick - [3D Warehouse](https://3dwarehouse.sketchup.com/model/89f94cd3ac5fb5104ed3368aee642973/BRIQUE-4-X-2) |
| 50.      | Pencil - Made by Omar A. |
| 51.      | Paperclip - Made by Omar A. |

<p float="center">
  <img src="https://github.com/oalkha2/Project-2---Office-Cubicle/blob/master/docs/Outside.jpg" width="80%">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 52.      | Giraffe - [SketchFab.com](https://sketchfab.com/3d-models/low-poly-giraffe-9043192c58994a9380d38b665790f8f5) |


### Audio Used

| Number  | File Name                          | Description & Link |
| --------| ---------------------------------- | ------------------ |
| 1.      | AC ambient loop.mp3 | Background ambient noise - [freesound.org](https://freesound.org/people/junkfood2121/sounds/242042/) |
| 2.      | Click2-Sebastian-759472264.mp3 | Keyboard Clack & Light Switch - [soundbible.com](http://soundbible.com/1705-Click2.html) |
| 3.      | barradeen-you-are-not-alone - trimmed.mp3 | [free-stock-music.com](https://www.free-stock-music.com/barradeen-you-are-not-alone.html)
| 4.      | cha_ching.mp3 | Piggybank sound - [Zedge](https://www.zedge.net/ringtone/a73e4b29-5a5f-3d3f-8050-3450b3e5d9b7) | 
| 5.      | kirby hiiii.mp3 | kirby sound - [Youtube](https://www.youtube.com/watch?v=zHfoGyaDuZE) |
| 6.      | Metal Gear Solid Alert.mp3 | ! - [Youtube](https://www.youtube.com/watch?v=2P5qbcRAXVkYoutube) | 
| 7.      | mouse_sms_chichi.mp3 | Mouse appear sound - [Zedge](https://www.zedge.net/ringtone/ca48529e-88a2-3376-8609-00b67bfd0020) |
| 8.      | phone sound.mp3 |  phone touch sound - My tablet |
| 9.      | RAINBOW SIX SIEGE - Menu SoundTrack.mp3 | TV sound - [Youtube](https://www.youtube.com/watch?v=TWBseNLqmec) | 
| 10.     | sword_slash.mp3 | Sword grab sound - [Zedge](https://www.zedge.net/ringtone/ab22fe02-3826-345a-80ad-dc22261a9127) | 
| 11.     | this_is_snake.mp3 | Snake touch sound - [Zedge](https://www.zedge.net/ringtone/800bff58-5190-3fd5-9acc-0d795d54eb0d) | 
| 12.     | Briefcase_Pickup.mp3 | Briefcase talking when picked up - made by James T. |
| 13.     | Briefcase_idle 1.mp3 | Briefcase talking when held - made by James T. |
| 14.     | Briefcase_Thanks.mp3 | Briefcase talking when let go - made by James T. |
| 15.     | Jojo_s_Bizarre_Adventure_OST_-_Awaken_Pillar_Men_Theme_.mp3 | Arrows Local Sound - [Youtube](https://www.youtube.com/watch?v=XUhVCoTsBaM)
| 16.     | modern-jazz-samba-by-kevin-macleod.mp3 | Boombox Music - [incompetech.com](https://incompetech.com/music/royalty-free/index.html?isrc=USUAN1100153) |
| 17.     | Who Likes to Party.mp3 | Boombox Music - [incompetech.com](https://incompetech.com/music/royalty-free/index.html?isrc=usuan1200075) |
| 18.     | Sculpture Sound.mp3 | Red Sculpture Sound - made by James T. |

## How effective this method is:
<p>Technology has gone very far, and so has virtual reality. One of the biggest applications of virtual reality is to be able to plan a space out ahead of time, whether it’s interior design, structural engineer, or architecture. By working on this project on Unity with the Virtual Reality Toolkit, we find that it is quite feasible from our experience to plan on a design using virtual reality.
From a large perspective, such as viewing the whole building or even a block on a city, the user can get an idea of how well the furniture and decorations would blend together. In our program, we were able to grow to a larger size, even past the roof, so that we were able to survey the whole office and see things in unimaginable perspective. 
  
At a normal perspective, the user can witness the scene as if it was set up. The user would be able to experience walking in and, in an ideal application, make adjustment such as moving furniture around to saving the layout in real time. Visually, virtual reality is almost perfect, emphasis on the almost. There are some downsides however with our current technology. As of now, emulating fabrics and texture is quite difficult. What if the tile looks great, but ended up being too slippery? What if the chair looks great but actually feels uncomfortable? This can easily be tested, however, as people can test furniture and flooring in person before buying them, or they can get a guaranteed comfortability from the manufacturer. 

What we didn’t end up doing in the project, however, is the idea that walls and panels can be turned off and on visually. This is a huge plus for anyone who is planning for plumbing, wiring, or air ducts, as running a utility through the wall is much easier when they know the layout and structure within it ahead of time through an x-ray perspective. 

Another interesting idea is being able to shrink further. One would be able to get perspective on people of various sizes, and this is especially important for those with disability such as dwarfism or are wheelchair bounded. Tables, counters, and sink may be too high to reach for some, so the smaller perspective helps to put the user in the shoes of those with different requirements.
We’re also not limited to just structures too! Automotive like cars, busses, airplanes, cruise ships, or even rocket ships benefit from technique like this as well! This offers one of the best way to test visibility from the driver’s seat, as well as provide a way to prototype wiring plans under the chassis without needing to create a physical prototype! 

But I feel one of the strongest applicating of this technique is that once we are able to work with this type of application in real time, having people cooperate or a “multiplayer” mode would be a huge boost to productivity. When we were working on this application, we couldn’t edit the same scene together, but if we were able to both work on it at the same time, a lot of time could have been saved.
Inconclusion, this technique to planning out space and structures is quite promising. Although there are some lack of senses one wouldn’t get from a real version, such as touch, the amount of money and time this could save is well worth it.</p>

