# Living in the City  
**CS426 Assignment 1 – Spring 2025**  
**Author:** Vedant Nandoskar  

## 🎮 Game Description  
*Living in the City  * is a physics-based fruit-throwing mini-game set in a pastel-styled, simplified urban environment. You control a spherical BB8-like character and toss fruit at various targets scattered throughout the city. The game combines playful mechanics with a touch of city-life flavor, inspired by the "Living in the City" theme.

## 🧠 How It Reflects the Theme  
- The playable character moves through a city-like space with streets, walls, bins, and obstacles — mirroring common urban design.
- Projectiles are stylized as fruits (e.g., apples, bananas, berries).
- The pastel color palette and stylized decor reflect an idealized version of the city: vibrant, whimsical, and interactive.

## ✅ Features  
- 💫 **Player Character (BB8)**: Always visible, physics-based movement.
- 🚶 **Smooth WASD controls** with no unwanted rolling or sliding.
- 🍎 **Throw 3 types of fruit** from a top-mounted throw point at a 45° arc.
- 🎯 **Physics-based projectile collisions** that bounce off obstacles and walls.
- 🎨 **Pastel-themed environment** (non-saturated colors across all assets).

## 🧪 Controls  
- **WASD / Arrow Keys**: Move BB8  
- **1 / 2 / 3**: Switch between Apple, Banana, and Blueberry  
- **Spacebar**: Throw the selected fruit  

## 🛠 Setup Notes  
- All fruit prefabs are under 100MB.  
- The throw point is a child GameObject of BB8, positioned above and in front for correct direction and height.  
- Projectiles use `AddForce` to launch upward-forward at 45 degrees.

## 🧾 Credits  
- BB8 sphere modeled using Unity primitives with custom pastel material  
- Fruits: Created using Unity sphere/capsule primitives and colored materials  
- Code is 100% original and written by me, following Unity’s in-class tutorials as reference

## 🎥 Video Demo  
[🔗 Watch the Demo Here](https://www.loom.com/share/5df2ea92b8ff402e84ba991ecf8e794f?t=41&sid=af060925-1d2c-4dd4-918d-83fb095d852d)

## 📦 Project Structure  
- Assets/  
  ├── Scripts/ (PlayerController.cs, ScoreManager.cs, Projectile.cs)  
  ├── Prefabs/ (Apple, Banana, Blueberry, Target)  
  ├── Materials/ (Pastel color materials)  
  └── Scenes/ (MainScene.unity)

## 🚀 Build Info  
- Platform: Windows  
- Output folder: `/Output/hw01` contains .exe and Data folder  
- Tested locally for functionality

---

🎉 Thanks for checking out *Living in the City  *! I'm excited to learn more and continue building city-inspired games this semester.
