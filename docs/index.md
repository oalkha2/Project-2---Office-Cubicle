

# Project 2 Summary
This project was created by Omar Al-Khatib and James Trinh for CS 428 (Augmented and Virtual Reality) at the University of Illinois in Chicago. This started as a blank office with VRTK incorporated in it, and then each group member were to pick a cubicle and decorate them.

<img src="https://raw.githubusercontent.com/oalkha2/Project-2---Office-Cubicle/master/Main%20Picture.jpg" width="600">

## Git Page
https://github.com/oalkha2/Project-2---Office-Cubicle

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
<p float="left">
  <img src="https://fsmedia.imgix.net/dc/36/59/25/4614/4153/b16b/b5e5d0ec1385/yqxqvpuvago31png.png?auto=format%2Ccompress&dpr=2&w=650" width="500">
  <img src="https://fsmedia.imgix.net/dc/36/59/25/4614/4153/b16b/b5e5d0ec1385/yqxqvpuvago31png.png?auto=format%2Ccompress&dpr=2&w=650" width="250">
  <img src="https://fsmedia.imgix.net/dc/36/59/25/4614/4153/b16b/b5e5d0ec1385/yqxqvpuvago31png.png?auto=format%2Ccompress&dpr=2&w=650" width="100">
</p>

| Number  | Description & Link |
| ------- | ----------------------------------------------------- |
| 1.      | Spot Light - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453) |
| 2.      | Metal Beam - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/interior/spotlight-and-structure-141453) |
| 3.      | Boombox - Made by James T. |
| 4.      | Le Grande Red Moustachio Sculpture - Made by James Trinh |
| 5.      | Kirby - [3D Warehouse](https://3dwarehouse.sketchup.com/model/90ad4aaab761cf36b05dd68c192eab4a/Kirby) |
| 6.      | One Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 7.      | Two Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 8.      | Three Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 9.      | Grandpa - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 10.     | Four Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 11.     | Five Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 12.     | Six Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 13.     | Seven Star Ball - [3D Warehouse](https://3dwarehouse.sketchup.com/model/ucdb75f3f-3a3f-4fe2-b8c3-b44659688b44/DragonBalls) |
| 14.     | Box - [3D Warehouse](https://3dwarehouse.sketchup.com/model/8ae844c2d0ddbf3452366c3503f802d0/box-a) |
| 15.     | Solid Snake - [3D Warehouse](https://3dwarehouse.sketchup.com/model/df05df84e071c379f16675b77b860cd6/Solid-Snake) |
| 16.     | Death Star - [3D Warehouse](https://3dwarehouse.sketchup.com/model/8f9066c4d0b98407ca292cf40513efe4/Death-Star) |
| 17.     | Piggy Bank - [3D Warehouse](https://3dwarehouse.sketchup.com/model/c3281ec2d23523e1c40386bdd72f9a0/Piggy-Bank) |
| 18.     | Desk - Made by Omar A. |
| 19.     | Bird Cage - Made by Omar A. |
| 20.     | Paperclip - Made by Omar A. |
| 21.     | Pencil - Made by Omar A. |
| 22.     | Sword - Made by Omar A. |
| 23.     | Shield - Made by Omar A. |
| 24.     | Jojo Arrows - [SketchFab](https://sketchfab.com/3d-models/stand-arrow-jojos-bizarre-adventure-b53212fb380d40678dd15475f9dd57f7  )|
| 25.     | keyboard -  |
| 26.     | Laptop - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 27.     | Pen - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 28.     | Phone - [Unity Asset Store](https://assetstore.unity.com/packages/3d/environments/low-poly-office-props-lite-131438) |
| 29.     | Cardinal - [Unity Asset Store](https://assetstore.unity.com/packages/3d/characters/animals/living-birds-15649) |
| 30.     | Lego Brick - [3D Warehouse](https://3dwarehouse.sketchup.com/model/89f94cd3ac5fb5104ed3368aee642973/BRIQUE-4-X-2) |
| 31.     | Gum Stick - [3D Warehouse](https://3dwarehouse.sketchup.com/model/a7d8fb085a8d91ce70b0ba4039b032ea/Gum) |
| 32.     | Origami Crane - [3D Warehouse](https://3dwarehouse.sketchup.com/model/1f0ae3c915999f5fe09b64fbc3223102/Origami-crane) |
| 33.     | Rat - [3D Warehouse](https://3dwarehouse.sketchup.com/model/u1c56b8a7-e927-419f-83b2-7b10d5b27b00/Rat) |
| 34.     | Cheese - [3D Warehouse](https://3dwarehouse.sketchup.com/model/36a790c205b5affe591a9a5b6104ce0f/Cheese) |
| 34.     | TV - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/electronics/wall-tvset-8468) |
| 34.     | White Chair - [Unity Asset Store](https://assetstore.unity.com/packages/3d/props/furniture/chair-fp-01-26466) |

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
**TODO 500 words**
