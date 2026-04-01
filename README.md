# Breathe — Multimodal EEG-VR Powered Focused Attention Meditation Sophrologist

Breathe is an EEG + VR powered focused-attention meditation system that dynamically and multimodally adapts its immersive environments based on real-time brain activity of the user.

The system acts as a virtual sophrologist, guiding users through calming environments while monitoring EEG signals to adjust environmental feedback in real time.

This project explores neuroadaptive interface interaction in immersive virtual environments using Meta Quest 2 and EEG-based brain computer interface (BCI) from EigenSensor.

This work was conducted as part of the **Dean's Office Undergraduate Student Research Project** at NUS, under:

- **Professor:** Li-Shiuan Peh
- **PhD Advisor:** Goh Teck Lun

The system is designed as **part of a larger research effort at the LSP research group at NUS to develop wearable, on-the-move EEG sensor**:

---

# Overview

Breathe includes two neuroadaptive VR environments:

- Fireplace Relaxation Environment  
- Beach Relaxation Environment  

Each environment dynamically adapts its unique visual and audio cues based on user relaxation and focus levels derived from their EEG signals.

---

# System Requirements

## Hardware

Required Hardware:

- Meta Quest 2 or Meta Quest 3 Headset
- Nuance EEG Headset (provided by EigenSensor)
- Nuance EEG USB Dongle (provided by EigenSensor)
- Alcohol wipes (for cleaning the part of the user's skin for refernce EEG electrode placement)
- Cap / hat (to secure EEG sensors)

---

## Software

Required Software:

- Unity Editor 2022.3.39f1 (minimum)
- OpenBCI GUI
- Meta Horizon app on smartphone
- Android Build Support (Unity)

Supported Platforms:

- Windows  
- macOS  

---

# Installation

## Step 1 — Download Project

Clone repository:
git clone https://github.com/JangusRoundstone/Breathe.git

Or download ZIP directly from GitHub.

---

## Step 2 — Open in Unity

Open the project using Unity Hub

Minimum Unity Version:
Unity 2022.3.39f1


---

## Step 3 — Switch Build Platform

In Unity:

1. Go to **File → Build Settings**
2. Select **Android**
3. Click **Switch Platform**

---

## Step 4 — Add Scenes to Build

Ensure the following scenes are added in the same order under scenes in build:

- Start Page  
- Week 2 Fireplace  
- Week 3 Beach  

---

## Step 5 — Build to Meta Quest

1. Connect Meta Quest headset to the development laptop
2. Enable Developer Mode  
3. Build the Unity project to the VR headset. Dont run it yet

---

# EEG Hardware Setup

## Step 1 — Connect Nuance EEG Dongle

Plug the **Nuance EEG USB dongle** into your computer.

Supported Platforms:

- Windows
- macOS

---

## Step 2 — Wear EEG Headset

1. Use alcohol wipes to clean mastoid region behind ears  
2. Attach reference electrodes to mastoid bones  
3. Place EEG sensors at back of head  
4. Use cap / hat to secure sensors  
5. Turn on EEG headset  

---

## Step 3 — Launch OpenBCI GUI

Launch OpenBCI GUI and verify:

- EEG signal detected  
- Sensors connected properly  

---

## Step 4 — Set up the MQTT Broker on Laptop

- Install a MQTT broker on your development laptop running OpenBCI GUI
- Start a MQTT session subscribed to the output of OpenBCI GUI, and publish user's real time alpha value to the VR headset

---

# Run the VR Application
Now, run the newly installed Unity app in the Meta Quest headset to experience the neuroadaptive VR sophrologist

---

# Technologies Used

- Unity
- Meta Quest 2 / Quest 3
- OpenBCI
- EigenSensor Nuance EEG
- C#
- XR Interaction Toolkit

---

# Research Motivation

This project enables me to explore:

- Brain-computer interaction in VR  
- Focused attention meditation in immersive environments  
- Neuroadaptive VR systems
- Wearable, on-the-go EEG-BCI

---

# Contributors

**Wang Silang**  
Computer Engineering  
National University of Singapore  

**Advisor**  
Professor Pei Lixuan  

**PhD Advisor**  
Go Tech Lin  

---

# Future Work

- More adaptive meditation environments  
- Personalized meditation guidance  
- Multimodal biofeedback integration, such as haptics 

---

# License

MIT License

---

# Contact

GitHub:  
https://github.com/JangusRoundstone

