# mvwater-test

---

Build Status

[![Build Status](https://travis-ci.org/mvwater/mvwater-cs.svg?branch=master)](https://travis-ci.org/mvwater/mvwater-cs)

---

Desktop version testing. Don't try to use this, it's all steaming piles of scuffed rat shit.

## Dependencies

- Requires Microsoft Visual C++ 2015-2019 Redistributable. Use the x64 or x86 depending on which version you are trying to compile.
- Requires Microsoft .NET Core (v.3.1) and .NET Framework (v.4.8)

## OSes

- Designed for Microsoft Windows 10 1904
- Could possibly run on macOS 10.14 if ported properly; reliability not guaranteed

## Installation

No installation required. You may run the `.exe` file inside of the `/bin/Debug/` folder, which will remained tracked with daily builds. Do not edit the `.config` or `.pdb` files.

The software is currently still in active development and thus is using the debug build type, which adds in some extra debugging information to the compiled files (the aforementioned `.pdb` files). Release software will not have this file.

As it stands, the program is still too small to warrant adaptation for an installer. As it gains heft, installation may be transitioned to an open-source installer. The most-likely solution is Inno Setup.

## Warnings

- Do NOT delete empty C# functions without checking for references! Only delete functions that are empty AND have zero references!
- It is *very* easy to think that a function has no references. Check the solution in Visual Studio FIRST.

## Contributions

Please read the contributor guidelines [here](https://github.com/mvwater/mvwater-cs/blob/master/CONTRIBUTING.md).
