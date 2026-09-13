<div align="center">

# 🌙 Azkar Elmuslim (أذكار المسلم)
### High-Performance Cross-Platform Mobile Application

[![Flutter](https://img.shields.io/badge/Flutter-3.x-02569B?style=for-the-badge&logo=flutter&logoColor=white)](https://flutter.dev/)
[![Dart](https://img.shields.io/badge/Dart-3.x-0175C2?style=for-the-badge&logo=dart&logoColor=white)](https://dart.dev/)
[![Architecture](https://img.shields.io/badge/Architecture-Clean%20%2F%20Layered-blueviolet?style=for-the-badge)](https://flutter.dev)
[![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS-brightgreen?style=for-the-badge&logo=android)](https://flutter.dev)
[![Download APK](https://img.shields.io/badge/Download-APKPure-green?style=for-the-badge&logo=android&logoColor=white)](https://apkpure.com/azkar-elmuslim-%D8%A7%D8%B0%D9%83%D8%A7%D8%B1-%D8%A7%D9%84%D9%85%D8%B3%D9%84%D9%85/com.skytech.zadelmuslim)
[![License](https://img.shields.io/badge/License-MIT-blue.svg?style=for-the-badge)](LICENSE)

<br/>

[📥 **Try the Live Android App (APKPure)**](https://apkpure.com/azkar-elmuslim-%D8%A7%D8%B0%D9%83%D8%A7%D8%B1-%D8%A7%D9%84%D9%85%D8%B3%D9%84%D9%85/com.skytech.zadelmuslim)

<br/>

**Azkar Elmuslim** is a production-ready, offline-first mobile application designed with a focus on smooth UI/UX performance, clean code architecture, local resource management, and accessibility.

[Project Overview](#-project-overview) • [Key Technical Highlights](#-key-technical-highlights) • [Architecture](#-architecture--design-patterns) • [Tech Stack](#-tech-stack) • [Live Build](#-live-build--deployment) • [Installation](#-installation--setup)

---

</div>

<br/>

## 🎯 Project Overview

Building mobile apps requires more than UI layout—it requires fast startup times, efficient state isolation, smooth frame rates (60/120fps), and zero dependency on active network connections for core features.

**Azkar Elmuslim** serves as a showcase of modern Flutter engineering principles:
- **Offline-First Architecture:** Instant data retrieval using local persistence engines.
- **Responsive & Dynamic UI:** Pixel-perfect layout adaptation across various screen densities and device formats.
- **Resource Efficiency:** Low memory overhead and optimized state management cycles.

<br/>

## ✨ Key Technical Highlights & Features

- ⚡ **Offline Data Persistence:** Structured JSON/Local DB caching ensuring complete functionality without internet access.
- 📿 **Interactive Haptic Engine:** Digital Tasbeeh implementation utilizing native haptic engine feedback for physical tactile user experience.
- 🎨 **Adaptive Design & Theming:** Custom dark/light mode themes complying with Material 3 design systems and RTL (Right-to-Left) localization best practices.
- 🔔 **Scheduled Local Notifications:** Background task handling for time-sensitive notifications using platform channels.
- 🚀 **Performance Optimization:** Minimized widget rebuilds using target state management selectors and `const` constructor optimizations.

<br/>

## 📦 Live Build & Deployment

The application build is compiled, signed, and hosted for direct testing:

- **Package Name:** `com.skytech.zadelmuslim`
- **Distribution Store:** [Download on APKPure](https://apkpure.com/azkar-elmuslim-%D8%A7%D8%B0%D9%83%D8%A7%D8%B1-%D8%A7%D9%84%D9%85%D8%B3%D9%84%D9%85/com.skytech.zadelmuslim)

<br/>

## 🏗️ Architecture & Design Patterns

The project follows clean software engineering practices to ensure scalable, testable, and maintainable codebases:

```text
lib/
├── core/               # Shared utilities, app-wide constants, themes & base services
│   ├── theme/          # Material 3 dark/light design tokens & Arabic typography
│   └── utils/          # Extensions, helpers, and formatters
├── data/               # Data Layer: Models, local storage, and data providers
│   ├── models/         # Data Transfer Objects (DTOs) & JSON serializers
│   └── datasources/    # Local database & preferences handlers
├── presentation/       # UI Layer: Screens, atomic widgets, and state controllers
│   ├── viewmodels/     # State management & business logic delegation
│   └── screens/        # UI Views adhering to declarative design principles
└── main.dart           # Application entry point & service initialization

```

### Core Engineering Principles Applied:

* **Separation of Concerns (SoC):** Distinct boundaries between business logic, data persistence, and UI layers.
* **RTL & Localization First:** Native support for Arabic typography, dynamic text scaling, and proper directional alignment.
* **State Isolation:** Scoped state updates that prevent unnecessary widget subtree re-renders.

## 🛠️ Tech Stack

| Domain | Technology / Library |
| --- | --- |
| **Framework** | [Flutter](https://flutter.dev/) (Dart) |
| **Architecture Pattern** | Layered / Clean Architecture |
| **State Management** | Provider / BLoC / GetX *(Adapter pattern ready)* |
| **Local Storage** | Shared Preferences / Hive / SQLite |
| **Notifications** | Flutter Local Notifications |
| **Typography & Styling** | Custom Arabic Fonts & Material Design 3 |

## 📱 Interface Showcase

| Daily Reminders View | Interactive Digital Counter | Adaptive Dark Mode |
| --- | --- | --- |
|  |  |  |

## 💻 Installation & Local Setup

### Prerequisites

* **Flutter SDK:** `>= 3.0.0`
* **Dart SDK:** `>= 3.0.0`
* **IDE:** VS Code or Android Studio

### Getting Started

```bash
# 1. Clone repository
git clone [https://github.com/mo-abouelsaad/azkar-elmuslim.git](https://github.com/mo-abouelsaad/azkar-elmuslim.git)

# 2. Navigate into directory
cd azkar-elmuslim

# 3. Fetch dependencies
flutter pub get

# 4. Run application in debug mode
flutter run

```

## 👨‍💻 About the Developer

**Mohamed Abouelsaad** — Mobile Software Engineer

Passionate about building responsive, resilient, and user-centric cross-platform mobile applications.

* **GitHub:** [@mo-abouelsaad](https://www.google.com/search?q=https://github.com/mo-abouelsaad)
* **Live App:** [APKPure Download Link](https://apkpure.com/azkar-elmuslim-%D8%A7%D8%B0%D9%83%D8%A7%D8%B1-%D8%A7%D9%84%D9%85%D8%B3%D9%84%D9%85/com.skytech.zadelmuslim)

---
