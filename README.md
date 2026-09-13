<div align="center">

# 🌙 Azkar Elmuslim (أذكار المسلم)
### High-Performance Cross-Platform Mobile Application

[![Xamarin.Forms](https://img.shields.io/badge/Xamarin.Forms-5.0-512BD4?style=for-the-badge&logo=xamarin&logoColor=white)](https://dotnet.microsoft.com/apps/xamarin)
[![C#](https://img.shields.io/badge/C%23-10.0-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![Architecture](https://img.shields.io/badge/Architecture-MVVM%20%2F%20Clean-blueviolet?style=for-the-badge)](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/)
[![Platform](https://img.shields.io/badge/Platform-Android%20%7C%20iOS-brightgreen?style=for-the-badge&logo=android)](https://dotnet.microsoft.com/apps/xamarin)
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

**Azkar Elmuslim** serves as a showcase of modern Xamarin.Forms engineering principles:
- **Offline-First Architecture:** Instant data retrieval using local persistence engines.
- **Responsive & Dynamic UI:** Pixel-perfect layout adaptation across various screen densities and device formats using XAML layouts.
- **Resource Efficiency:** Low memory overhead and optimized data-binding state management cycles.

<br/>

## ✨ Key Technical Highlights & Features

- ⚡ **Offline Data Persistence:** Structured JSON/SQLite local caching ensuring complete functionality without internet access.
- 📿 **Interactive Haptic Engine:** Digital Tasbeeh implementation utilizing native haptic engine feedback via Xamarin.Essentials.
- 🎨 **Adaptive Design & Theming:** Custom dark/light mode themes complying with native design systems and RTL (Right-to-Left) localization best practices.
- 🔔 **Scheduled Local Notifications:** Background task handling for time-sensitive notifications using platform-specific background services.
- 🚀 **Performance Optimization:** Minimized UI re-renders using optimized XAML compiled bindings (`x:DataType`) and weak references.

<br/>

## 📦 Live Build & Deployment

The application build is compiled, signed, and hosted for direct testing:

- **Package Name:** `com.skytech.zadelmuslim`
- **Distribution Store:** [Download on APKPure](https://apkpure.com/azkar-elmuslim-%D8%A7%D8%B0%D9%83%D8%A7%D8%B1-%D8%A7%D9%84%D9%85%D8%B3%D9%84%D9%85/com.skytech.zadelmuslim)

<br/>

## 🏗️ Architecture & Design Patterns

The project follows clean software engineering and MVVM principles to ensure scalable, testable, and maintainable codebases:

```text
AzkarElmuslim/
├── Core/               # Shared logic, app-wide constants, dynamic resources & themes
│   ├── Themes/         # XAML ResourceDictionaries for dark/light modes & Arabic typography
│   └── Helpers/        # Value converters, extensions, and custom renderers
├── Models/             # Data Layer: Entities, DTOs & SQLite database mappings
├── Services/           # Data Services: Local storage handlers & notification managers
├── ViewModels/         # MVVM Layer: Command binding, state isolation & business logic
└── Views/              # UI Layer: XAML Pages and custom reusable UI components

```

### Core Engineering Principles Applied:

* **Model-View-ViewModel (MVVM):** Strict separation of concerns between visual rendering (XAML) and business logic (C# ViewModels).
* **RTL & Localization First:** Native support for Arabic typography, dynamic text scaling, and proper directional alignment.
* **Dependency Injection (DI):** Decoupled service abstraction for testability and platform-specific feature rendering.

## 🛠️ Tech Stack

| Domain | Technology / Library |
| --- | --- |
| **Framework** | [Xamarin.Forms](https://dotnet.microsoft.com/apps/xamarin) (C# / XAML) |
| **Architecture Pattern** | MVVM (Model-View-ViewModel) / Clean Architecture |
| **State Management** | INotifyPropertyChanged / ReactiveUI / Prism |
| **Local Storage** | SQLite.NET / Xamarin.Essentials Preferences |
| **Platform APIs** | Xamarin.Essentials (Haptics, Device Info, Permissions) |
| **Typography & Styling** | Embedded Custom Arabic Fonts & Dynamic ResourceDictionaries |

## 📱 Interface Showcase

| Daily Reminders View | Interactive Digital Counter | Adaptive Dark Mode |
| --- | --- | --- |
|  |  |  |

## 💻 Installation & Local Setup

### Prerequisites

* **Visual Studio 2022** with the **Mobile Development with .NET (Xamarin)** workload installed.
* **.NET SDK:** `>= 6.0`
* **Xamarin.Forms:** `>= 5.0`

### Getting Started

```bash
# 1. Clone repository
git clone [https://github.com/mo-abouelsaad/azkar-elmuslim.git](https://github.com/mo-abouelsaad/azkar-elmuslim.git)

# 2. Open solution in Visual Studio
# Open AzkarElmuslim.sln

# 3. Restore NuGet packages
dotnet restore

# 4. Set target project (Android or iOS) as Startup Project and Run (F5)

```

## 👨‍💻 About the Developer

**Mohamed Abouelsaad** — Mobile Software Engineer

Passionate about building responsive, resilient, and user-centric cross-platform mobile applications.

* **GitHub:** [@mo-abouelsaad](https://www.google.com/search?q=https://github.com/mo-abouelsaad)
* **Live App:** [APKPure Download Link](https://apkpure.com/azkar-elmuslim-%D8%A7%D8%B0%D9%83%D8%A7%D8%B1-%D8%A7%D9%84%D9%85%D8%B3%D9%84%D9%85/com.skytech.zadelmuslim)

---
