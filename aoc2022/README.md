# Advent of Code 2022
This year for https://adventofcode.com instead of solving the puzzles, try to
reimplement reddit solutions in as many languages as possible. See https://www.reddit.com/r/adventofcode/

Languages to try:
* Python
* R
* Julia
* C#
* C (not C++)
* Rust
* Go
* JavaScript
* MATLAB/Octave

## C/C++ VSCode setup
Can be set up with C/C++ extension in either Windows or WSL.

### MSVC
On Windows install Build Tools for Visual Studio 2022 which adds
"x64 Native Tools Command Prompt for VS 2022" & PS to the Windows Start Menu.
https://visualstudio.microsoft.com/downloads/?q=build+tools

Or open the Visual Studio Installer. Installing MSVC requires a subscription.

IMPORTANT! Select "Desktop Development with C++" or `cl.exe` will not be available.
Open the Build Tools Command Prompt and enter `cl.exe` to test.

See VS2022 component ID listing
https://learn.microsoft.com/en-us/visualstudio/install/workload-component-id-vs-build-tools?view=vs-2022

IMPORTANT! Start "x64 Native Tools Command Prompt for VS 2022", navigate to
working folder, and execute `code .` to start VSCode with build tools enabled.

### WSL
Install gcc and gdb using apt.

### Links
Read these links carefully to learn how to run & debug c/c++ in vscode.
* https://code.visualstudio.com/docs/cpp/config-msvc
* https://code.visualstudio.com/docs/cpp/config-wsl
* https://code.visualstudio.com/docs/cpp/config-linux

## C# (Windows)
Requires .NET SDK v6 or v7, https://dotnet.microsoft.com/en-us/download.

## R
Requires R CRAN package `languageserver`. This is available from Ubuntu using,
but instead install from source.

NOTE! Requires `xml2` and `libxml2-dev`, install first using `apt`. May need to
install using `--no-lock`.

## Julia
Requires Julia Language Server

## Golang (_aka_ Go)
A bit of nightmare, but easy if you just install latest version following these [directions](https://go.dev/doc/install), follow VSCode Go plugin [instructions](https://github.com/golang/vscode-go/wiki/features#run-and-test-in-the-editor), and add `"dlvFlags": ["--only-same-user=false"]` to the `launch.json`
