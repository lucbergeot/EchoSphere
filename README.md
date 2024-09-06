# EchoSphere

**EchoSphere** is an AI-driven social simulation that immerses characters in a persistent, autonomous environment. Built in Unity and powered by cutting-edge AI (Convai and NVIDIA), this project extends the foundational logic of the **Smallville** project, adding verbal communication, dynamic personalities, and deep emotional systems to create lifelike, interactive characters.

## Project Overview

EchoSphere aims to simulate a thriving social ecosystem, where every character is an autonomous agent with their own life, relationships, awareness of other characters, and understanding of current events in their environment. Characters can communicate verbally, express emotions, and participate in social interactions like parties or shared events, evolving based on the interactions around them.

## Features

- **Autonomous NPCs**: Characters live out their lives independently, forming and maintaining relationships, working, socializing, and participating in environmental events.
- **Dynamic Dialogue**: Powered by Convai, NPCs can engage in verbal conversations with players and other NPCs, using natural language processing (NLP) to respond intelligently.
- **Emotion & Personality System**: Each character has unique emotional states and personality traits that influence their behavior and dialogue choices.
- **Memory & Awareness**: NPCs remember interactions, build relationships over time, and stay aware of ongoing events in the environment (e.g., shared events like parties).
- **Event-Driven Environment**: The simulation updates in response to significant events (e.g., holiday celebrations, community activities), with NPCs reacting accordingly.

## Quick Start

### Prerequisites

To run EchoSphere, you'll need the following:
- **Unity**: Minimum version 2022.3.x.
- **Git**: Required for cloning the repository.
- **C# Programming**: Basic understanding of Unity scripts and C# is needed for custom integrations.
- **Convai SDK**: Used for dynamic conversational AI (see [Convai documentation](https://convai.com) for setup instructions).

### Setup

### Clone the repository
   git clone <repository_url>
   cd EchoSphere

### Install Dependencies
Open the Unity project and install the necessary packages:

- **Convai SDK** (available from the Unity Asset Store).
- Ensure you have the correct version of the **Newtonsoft.Json** library.

### Configure Convai API Key
After importing the Convai SDK, set up your Convai API Key by navigating to `Convai > API Key Setup`. You can get an API Key from your Convai dashboard at [Convai Dashboard](https://convai.com/dashboard).

### Open Sample Scene
Open the `Convai Demo` scene located at `Convai > Demo > Scenes > Full Features`. This scene provides a starting point for experimenting with EchoSphere’s NPC behaviors.

### Run the Scene
Press **Play** in the Unity editor. You can interact with the NPCs in the demo scene. They will respond to your dialogue, engage with other characters, and react to environmental events (like holidays).

## Project Structure

- **/Assets/EchoSphere**: Contains core assets for NPCs, interactions, and environment setups.
- **/Scripts**: Core scripts that define character behaviors, dialogues, emotions, and memory systems.
- **/Resources**: Config files for Convai, long-term memory settings, and event management systems.

## Key Systems

- **Social System**: NPCs autonomously manage relationships, keeping track of friends, enemies, and neutral acquaintances. These relationships evolve based on interaction patterns and shared events.
- **Event System**: The environment includes periodic events (e.g., Valentine's Day Party), with NPCs participating, discussing, and remembering these events.
- **Emotion & Personality System**: Each NPC has unique traits that influence their dialogue choices and actions. Characters can express joy, anger, sadness, etc., depending on their interactions and personal experiences.

## Planned Features

The initial phase of EchoSphere focuses on NPCs and social interactions. In the future, we aim to:

- Introduce more complex multi-character events and social dynamics.
- Implement deeper integration of AI-driven personalities and emotions with Convai and NVIDIA AI Workbench.
- Expand NPC verbal interaction capabilities to create richer conversational depth.

## Contribution Guidelines

If you're interested in contributing to EchoSphere, please refer to our [CONTRIBUTION.md](CONTRIBUTION.md) file for details on how to get started.
