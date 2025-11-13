# Unity & Vuforia: AR Image Target Viewer

This is an augmented reality application for Android built with Unity and the Vuforia SDK. The app uses the device's camera to recognize specific printed images (Image Targets) and spawns a corresponding 3D animal model on top of them in real-time.

---

## How It Works

The application is built around Vuforia's Image Tracking technology.

1.  A database of target images is included in the application's assets.
2.  The Vuforia Engine, running on the device, analyzes the live camera feed for features that match the images in its database.
3.  When it detects a high-confidence match, it begins tracking the image's position and rotation in the real world.
4.  A C# script then instantiates (spawns) a pre-assigned 3D animal prefab, anchoring it to the position of the detected image target.

---

## Technologies & Libraries

*   **Engine:** Unity
*   **AR SDK:** Vuforia Engine
*   **Language:** C#
*   **Platform:** Android
*   **Version Control:** Git & Git LFS (for handling large package files)

---

## How to Try It

For the AR magic to work, you need to print the images below. Once you have built and run the app on a device, point its camera at one of the printed pages to spawn the 3D animal.

### Scannable Image Targets

The application is designed to recognize the following images. For the best results, print them on paper or display them clearly on another screen.

| Animal      | Scannable Image                                    |
| :---------- | :------------------------------------------------- |
| **Dog**     | ![Dog Target](target-images/Dog.png)    |
| **Horse**   | ![Horse Target](target-images/Horse.png)      |
| **Kitty**   | ![Kitty Target](target-images/Kitty.png)  |
| **Tiger**   | ![Tiger Target](target-images/Tiger.png)  |

---

## How to Open in Unity

This repository contains only the necessary source files. The large, auto-generated `Library` folder is correctly ignored by the `.gitignore` file.

**Prerequisites:**
*   Unity Hub and a compatible version of the Unity Editor.
*   Git LFS installed on your machine (`git lfs install`).

1.  Clone the repository to your local machine:
    `git clone https://github.com/JTerZeus/unity-vuforia-ar-animals.git`
2.  Open Unity Hub and click "Open" -> "Add project from disk."
3.  Navigate to the cloned repository folder and select it.
4.  Unity will open the project and automatically regenerate the `Library` folder. This may take several minutes.

---

### Attribution and Academic Context

**Please Note:** This project was developed for the **"Augmented Reality"** course at the **University of Primorska** during my Erasmus exchange semester. The assignment was to create a basic AR application demonstrating an understanding of image tracking and 3D object instantiation.
