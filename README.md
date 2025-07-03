# como.unity.package-template
Unity package template repository

## Overview
This repository serves as a template for creating Unity custom packages. It follows Unity's official package structure guidelines and includes all necessary directories and files to get started with package development.

## Package Structure
```
├── package.json                           # Package manifest
├── Runtime/
│   ├── COMO.PackageTemplate.asmdef       # Assembly definition
│   ├── Scripts/
│   │   └── SampleScript.cs               # Sample MonoBehaviour
│   ├── Prefabs/                          # Unity prefabs
│   ├── Assets/                           # Materials, textures, etc.
│   └── Scenes/                           # Sample scenes
├── Editor/
│   ├── COMO.PackageTemplate.Editor.asmdef # Editor assembly definition
│   └── SampleEditor.cs                   # Custom inspector example
└── Tests/
    └── Runtime/
        ├── COMO.PackageTemplate.Tests.asmdef # Test assembly definition
        └── SampleRuntimeTests.cs         # Sample unit tests
```

## Usage

### For Template Users
1. Use this template to create a new repository
2. Update the `package.json` with your package details
3. Replace placeholder content with your actual package code
4. Remove `.gitkeep` files as you add content to directories

### Installing This Package in Unity

#### Method 1: Unity Package Manager (Git URL)
1. Open Unity and go to **Window → Package Manager**
2. Click the **+** button in the top-left corner
3. Select **Add package from git URL**
4. Enter the following URL:
   ```
   https://github.com/XinLeng-Como/como.unity.package-template.git
   ```
5. Click **Add**

#### Method 2: Package Manager (Manual)
1. Clone or download this repository
2. In Unity, go to **Window → Package Manager**
3. Click the **+** button and select **Add package from disk**
4. Navigate to the cloned repository folder
5. Select the `package.json` file
6. Click **Open**

#### Method 3: Packages Folder (Development)
1. Clone this repository into your project's `Packages` folder
2. Unity will automatically detect and import the package

> **Note**: This is a template package. Replace the placeholder content with your actual package code before using in production.

## Unity Package Conformance

This template follows Unity's official custom package guidelines:

✅ **Required Files**:
- `package.json` - Package manifest with all required fields
- Proper semantic versioning (1.0.0)
- Unity version compatibility specified (2022.3+)

✅ **Standard Directory Structure**:
- `Runtime/` - Scripts that run in builds and editor
- `Editor/` - Editor-only scripts and tools
- `Tests/` - Unit tests for the package
- `Tests/Runtime/` and `Tests/Editor/` - Separated test environments

✅ **Package Naming Convention**:
- Follows reverse domain notation: `com.como.unity.package-template`
- Ready for customization with your company/organization details

✅ **Git Repository Compatibility**:
- Can be installed directly via Git URL in Unity Package Manager
- All directories preserved with `.gitkeep` files
- Clean repository structure without Unity project files

📖 **Reference**: [Unity Custom Packages Documentation](https://docs.unity3d.com/6000.1/Documentation/Manual/CustomPackages.html)

## Changelog
### 2025-07-03
- ✅ Initial Unity package structure created
- ✅ Added package.json with standard Unity package manifest
- ✅ Created Runtime/ and Editor/ directories with placeholders
- ✅ Created Tests/Runtime/ and Tests/Editor/ directories
- ✅ Added COMO/Packages/Template/ directory structure
- ✅ Created Scripts/, Prefabs/, Assets/, and Scene/ directories
- ✅ Added .gitkeep files to preserve empty directory structure
- ✅ Added Unity Package Manager installation instructions
- ✅ Included Git URL for easy package installation
- ✅ Verified conformance with Unity's official documentation
- ✅ Added multiple installation methods (Git URL, Manual, Development)
