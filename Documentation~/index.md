# COMO Unity Package Template

## Overview

The COMO Unity Package Template provides a complete starting point for creating Unity custom packages. It follows Unity's official package structure guidelines and includes all necessary files and directories.

## Quick Start

1. **Use this template** to create a new repository
2. **Update package.json** with your package details:
   - Change the package name from `com.como.unity.package-template` to your own
   - Update version, displayName, and description
   - Set your author information
3. **Replace sample content** with your actual functionality
4. **Update documentation** in the `Documentation~/` folder

## Package Structure

This template follows Unity's recommended package layout:

- `Runtime/` - Scripts that run in both the editor and builds
- `Editor/` - Editor-only scripts and tools
- `Tests/Runtime/` - Runtime unit tests
- `Tests/Editor/` - Editor unit tests  
- `Documentation~/` - Package documentation (excluded from builds)
- `Samples~/` - Sample content for users (excluded from builds)

## Sample Content Included

### Runtime Scripts
- `SampleScript.cs` - Example MonoBehaviour component
- Assembly definition with proper namespace organization

### Editor Scripts  
- `SampleEditor.cs` - Custom inspector for SampleScript
- Editor-specific assembly definition

### Tests
- `SampleRuntimeTests.cs` - Example unit tests using NUnit
- Proper test assembly configuration

## Development Workflow

1. **Add your scripts** to the `Runtime/` folder
2. **Create editor tools** in the `Editor/` folder if needed
3. **Write tests** in the appropriate `Tests/` folders
4. **Update documentation** as you add features
5. **Version your package** following semantic versioning

## Installation

Users can install your package via Unity Package Manager using:
```
https://github.com/your-username/your-package-name.git
```

Replace with your actual repository URL.

## Support

For questions or issues, please refer to the repository's issue tracker or documentation.
