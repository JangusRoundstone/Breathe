# Breathe — Multimodal EEG-VR Focused Attention Meditation Sophrologist

**Breathe** is an **EEG + VR powered focused-attention meditation system** that dynamically and multimodally adapts its immersive environments based on **real-time brain activity** of the user.

The system acts as a **virtual sophrologist**, guiding users through calming environments while monitoring EEG signals to adjust environmental feedback in real time.

This project explores **Brain-Computer Interface (BCI)** interaction in immersive virtual environments using **Meta Quest** and **Nuance EEG hardware from EigenSensor**.

This work was conducted as part of the **Dean's Office Undergraduate Student Research Project**, under:

- **Professor:** Pei Lixuan  
- **PhD Advisor:** Go Tech Lin  

---

# Overview

Breathe includes two adaptive VR environments:

- Fireplace Relaxation Environment  
- Beach Relaxation Environment  

Each environment dynamically adapts its visual and audio based on **user relaxation and focus levels derived from EEG signals**.

The system is designed for:

- Focused attention meditation  
- Stress reduction  
- Neuroadaptive immersive environments  
- Passive brain-computer interface interaction  

---

# System Requirements

## Hardware

Required Hardware:

- Meta Quest 2 or Meta Quest 3
- Nuance EEG Headset (EigenSensor)
- Nuance EEG USB Dongle (EigenSensor)
- Alcohol wipes (for electrode placement)
- Cap / hat (to secure EEG sensors)

---

## Software

Required Software:

- Unity Editor **2022.3.39f1** (minimum)
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

1. Connect Meta Quest headset  
2. Enable Developer Mode  
3. Click **Build and Run**  

Application will be installed directly onto headset.

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

# Running the Experience

Once setup is complete:

1. Launch application on Quest headset  
2. Start EEG streaming  
3. Enter VR environment  

The system will:

- Monitor brain activity  
- Detect relaxation and focus levels  
- Adapt environment dynamically  

---

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

This project explores:

- Brain-computer interaction in VR  
- Focused attention meditation in immersive environments  
- Neuroadaptive VR systems  
- Passive input interfaces  
- AI-driven relaxation environments  

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
- Improved EEG signal processing  
- Personalized meditation guidance  
- Multimodal biofeedback integration  

---

# License

MIT License

---

# Contact

GitHub:  
https://github.com/JangusRoundstone

---

# Unity Version

