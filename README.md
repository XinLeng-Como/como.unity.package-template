# como.unity.package-template
Unity package template repository

## Overview
This repository serves as a template for creating Unity custom packages. It follows Unity's official package structure guidelines and includes all necessary directories and files to get started with package development.

## Package Structure
```
├── package.json              # Package manifest
├── Runtime/                  # Runtime scripts
├── Editor/                   # Editor-only scripts
├── Tests/
│   ├── Runtime/             # Runtime tests
│   └── Editor/              # Editor tests
└── COMO/Packages/Template/
    ├── Scripts/             # Additional scripts
    ├── Prefabs/             # Unity prefabs
    ├── Assets/              # General assets
    └── Scene/               # Unity scenes
```

## Usage
1. Use this template to create a new repository
2. Update the `package.json` with your package details
3. Replace placeholder content with your actual package code
4. Remove `.gitkeep` files as you add content to directories

## Changelog
### 2025-07-03
- ✅ Initial Unity package structure created
- ✅ Added package.json with standard Unity package manifest
- ✅ Created Runtime/ and Editor/ directories with placeholders
- ✅ Created Tests/Runtime/ and Tests/Editor/ directories
- ✅ Added COMO/Packages/Template/ directory structure
- ✅ Created Scripts/, Prefabs/, Assets/, and Scene/ directories
- ✅ Added .gitkeep files to preserve empty directory structure
