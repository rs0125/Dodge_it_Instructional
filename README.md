# Dodge it


## Overview
**Game Title**: Dodge It  
**Description**: Dodge It is a beginner-friendly arcade-style game developed using Unity. Players navigate through obstacles while trying to maximise their score, offering a hands-on introduction to game development concepts. 

This game was showcased by ISTE-VIT during their event Augmentrix at graVITas'24 to teach attendees about game development using Unity.
An [Augmented Reality Version](https://github.com/rs0125/Dodge_it_AR) was also taught using the base game assets.


## Table of Contents
1. [Installation](#installation)
2. [Getting Started](#getting-started)
3. [Gameplay Mechanics](#gameplay-mechanics)
4. [Game Assets](#game-assets)
5. [Development Process](#development-process)
6. [License](#license)

## 1. Installation

### Prerequisites
- **Unity**: Make sure you have Unity Hub installed and the correct version of Unity (as specified in the project settings).

### Clone the Repository
To clone the Dodge It repository, use:
```bash
git clone https://github.com/rs0125/Dodge_it.git
cd Dodge_it
```

### Open the Project
1. Open Unity Hub.
2. Click on "Add" and select the cloned project folder.
3. Open the project in Unity.

## 2. Getting Started

### Running the Game
1. In Unity, go to `File > Build and Run` or click the Play button in the editor to test the game.

### Game Controls
- **A/D**: Move the player character left and right.
- **Button Interaction**: Perform movement actions on touch screen devices.

## 3. Gameplay Mechanics

### Objective
Avoid obstacles and travel a further distance to score points in an endless runner fashion.

### Scoring System
- Points are awarded for Z-Axis based displacement, displayed on the UI.

### Levels
- The game features multiple levels with increasing difficulty and different obstacle patterns.

## 4. Game Assets
- All GameObjects and Scenes are located in the `Assets/` folder.


## 5. Development Process

### Programming Language
- The game is developed using C#.

### Unity Features Used
- 3D physics for character movement and collision detection.
- Unity's UI system for score display and menus.

### Platform
- The game export is optimised and tested for PC/Android/IOS.
- In Unity go to `File > Build Settings` to change platform export.

## 6. License
This project is licensed under the MIT License. See the `LICENSE` file for more details.
